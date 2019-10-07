using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    [CreateAssetMenu(menuName = "Player State/Puzzle", fileName = "DB Puzzle")]
    public class Puzzle : States
    {

        private DB_Puzzle puzzle;

        [Header("Puzzle State Control")]
            [SerializeField] private bool checkingInput = false;

        private delegate void PuzzleInput();

        private List<PuzzleInput> InputMethods;

        public enum InputTypes {
            AnalogueClockwise = 0, AnalogueAntiClockwise = 1,
            RightTrigger = 2, LeftTrigger = 3,
            SecondaryButton = 4, TertiaryButton = 5,
            LeftAnalogueMove = 5, RightAnalogueMove = 6,
            GrabAndPullVertical = 7, HoldAndPullHorizontal = 8,
            None = 9
        }

        [Header("Analogue State Feedback")]
            [SerializeField] private Vector2 LeftAnalogueInput;
            [SerializeField] private Vector2 RightAnalogueInput;

        [Header("Trigger State Feedback")]
            [SerializeField] private bool isRightTriggerDown = false;
            [SerializeField] private bool isLeftTriggerDown = false;

        [Header("Rotational Input Control")]
            [SerializeField] protected List<Vector2> RotationalAccuracy;
            [SerializeField] protected float InputSensitivity = 0.2f;
            
            [SerializeField] private int currentIndexOfAccuracy = 0;

        [Header("Input Types and Progress")]
            [SerializeField] private InputTypes expectedInput;
            private List<InputTypes> orderedInputExpectations;
            [SerializeField] private float analogueProgress = 0f;
             
        [Header("Instructions")]
            [SerializeField] protected List<string> _instructionText;
            private TMPro.TMP_Text instructionObject;


        public override void Initialize (PlayerInputActions _controls) {
            controls = _controls;

            PlayerObject = PlayerReference.instance.manager;
            controls.PuzzleControls.Close.performed += ctx => ExitState();
            controls.PuzzleControls.PrimaryButton.performed += ctx => StartInput();

            controls.PuzzleControls.PrimaryAxis.performed += ctx => LeftAnalogueInput = ctx.ReadValue<Vector2>();
            controls.PuzzleControls.PrimaryAxis.canceled += ctx => LeftAnalogueInput = Vector2.zero;

            controls.PuzzleControls.SecondaryAxis.performed += ctx => RightAnalogueInput = ctx.ReadValue<Vector2>();
            controls.PuzzleControls.SecondaryAxis.canceled += ctx => RightAnalogueInput = Vector2.zero;

            controls.PuzzleControls.SecondaryButton.performed += ctx => Secondary();
            controls.PuzzleControls.TertiaryButton.performed += ctx => Tertiary();

            controls.PuzzleControls.LeftGrab.performed += ctx => isLeftTriggerDown = true;
            controls.PuzzleControls.LeftGrab.canceled += ctx => isLeftTriggerDown = false;

            controls.PuzzleControls.RightGrab.performed += ctx => isRightTriggerDown = true;
            controls.PuzzleControls.RightGrab.canceled += ctx => isRightTriggerDown = false;

            instructionObject = PlayerReference.instance.instructions;
            
        }

        
        public override void Step() {
            if (checkingInput) {
                instructionObject.text = _instructionText[puzzle.puzzleState + 1];
                switch (expectedInput) {
                    case InputTypes.AnalogueClockwise:
                        if (Vector2.Distance(LeftAnalogueInput.normalized, RotationalAccuracy[currentIndexOfAccuracy].normalized) < InputSensitivity) {
                            currentIndexOfAccuracy++;
                            
                            if (currentIndexOfAccuracy >= RotationalAccuracy.Count) {
                                currentIndexOfAccuracy = 0;
                                checkingInput = false;
                                InputMethods[puzzle.puzzleState].Invoke();
                            } else {
                                puzzle.screwObjects[puzzle.numScrews - 1].Rotate(Vector3.up * (1f/RotationalAccuracy.Count));
                            }
                        }
                    break;
                    case InputTypes.AnalogueAntiClockwise:
                        if (Vector2.Distance(LeftAnalogueInput.normalized, RotationalAccuracy[currentIndexOfAccuracy].normalized) < InputSensitivity) {
                            currentIndexOfAccuracy--;
                            if (currentIndexOfAccuracy < 0) {
                                currentIndexOfAccuracy = RotationalAccuracy.Count - 1;
                            }

                            if (currentIndexOfAccuracy == 0) {
                                currentIndexOfAccuracy = 0;
                                checkingInput = false;
                                InputMethods[puzzle.puzzleState].Invoke();
                            }
                        }
                    break;
                    case InputTypes.GrabAndPullVertical:
                        if (isRightTriggerDown) {
                            analogueProgress += Mathf.Abs(LeftAnalogueInput.y * Time.deltaTime);
                        }

                        if (analogueProgress < 0) {
                            analogueProgress = 0;
                        }

                        if (analogueProgress >= 1f) {
                            checkingInput = false;
                            InputMethods[puzzle.puzzleState].Invoke();
                        }
                    break;
                    case InputTypes.HoldAndPullHorizontal:
                        if (isRightTriggerDown && isLeftTriggerDown) {
                            analogueProgress += LeftAnalogueInput.x * Time.deltaTime;
                        }
                        if (analogueProgress >= 1f) {
                            checkingInput = false;
                            InputMethods[puzzle.puzzleState].Invoke();
                        }
                    break;
                }
            } else {
                instructionObject.text = _instructionText[0];
            }
        
            if (Input.GetKeyDown(KeyCode.Asterisk)) {
                PlayerReference.instance.CheatButtons.SetActive(true);
            }
        }   
        
        private void StartInput () {
            if (checkingInput) {
                return;
            }

            if (puzzle.puzzleState == 7) {
                return;
            }

            if (!puzzle.CheckCurrentRequirement()) {
                return;
            }

            checkingInput = true;
            // Determine what input is to be expected
            analogueProgress = 0f;

            expectedInput = orderedInputExpectations[puzzle.puzzleState];
            //Show the player what to do           
        }

        private void Tertiary() {
            if (checkingInput && expectedInput == InputTypes.TertiaryButton) {
                checkingInput = false;
                InputMethods[puzzle.puzzleState].Invoke();
            }
        }

        private void Secondary() {
            if (checkingInput && expectedInput == InputTypes.SecondaryButton) {
                checkingInput = false;
                InputMethods[puzzle.puzzleState].Invoke();
            }
        }

        public override void EnableState() {
            controls.PuzzleControls.Enable();
            puzzle = PlayerReference.instance.dB_Puzzle;

            puzzle.CheckRequirements();

            InputMethods = new List<PuzzleInput>();     orderedInputExpectations = new List<InputTypes>();

            InputMethods.Add(puzzle.RemoveScrew);       orderedInputExpectations.Add(InputTypes.AnalogueAntiClockwise); //0
            InputMethods.Add(puzzle.RemoveCover);       orderedInputExpectations.Add(InputTypes.SecondaryButton);       //1
            InputMethods.Add(puzzle.RemoveWire);        orderedInputExpectations.Add(InputTypes.GrabAndPullVertical);   //2
            InputMethods.Add(puzzle.PlaceNewSwitch);    orderedInputExpectations.Add(InputTypes.TertiaryButton);        //3
            InputMethods.Add(puzzle.InsertWire);        orderedInputExpectations.Add(InputTypes.TertiaryButton);        //4
            InputMethods.Add(puzzle.PlaceCoverBack);    orderedInputExpectations.Add(InputTypes.SecondaryButton);       //5
            InputMethods.Add(puzzle.NewScrew);          orderedInputExpectations.Add(InputTypes.AnalogueClockwise);     //6
                                                        orderedInputExpectations.Add(InputTypes.None);
            
        }

        public override void DisableState() {
            controls.PuzzleControls.Disable();
            puzzle.ClosePuzzle();
        }
    }
}

