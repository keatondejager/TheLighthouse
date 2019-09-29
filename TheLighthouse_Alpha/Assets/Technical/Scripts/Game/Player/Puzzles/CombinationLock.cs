using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CombinationLock : MonoBehaviour
{
    [Header("Reference")]
        [SerializeField] protected List<TMP_Text> digitDisplay;
        [SerializeField] protected GameObject PuzzleUI;
        [SerializeField] protected Transform ActiveIndicator;

    [Header("Puzzle")]
        [SerializeField] protected List<int> correctSolution;
        [SerializeField] protected List<int> _currentGuess;
        
        private int IndicatorIndex = 0;
        private PlayerInputActions controls;

    private void Start() {
        Player.PlayerReference.instance.combinationLock = this;

        controls = new PlayerInputActions();

        controls.PuzzleControls.PrimaryButton.performed += ctx => CheckSolution();

        controls.PuzzleControls.ShiftCursorLeft.started += ctx => MoveCursorLeft();
        controls.PuzzleControls.ShiftCursorRight.started += ctx => MoveCursorRight();

        controls.PuzzleControls.DigitDown.started += ctx => ShiftDigit(-1);
        controls.PuzzleControls.DigitUp.started += ctx => ShiftDigit(1);
    }

    public void OpenPuzzle () {
        PuzzleUI.SetActive(true);
        controls.PuzzleControls.Enable();
        UpdateDisplay();
    }  

    public void ClosePuzzle () {
        PuzzleUI.SetActive(false);
        controls.PuzzleControls.Disable();
    }

    protected void MoveCursorLeft () {
        IndicatorIndex--;
        if (IndicatorIndex < 0) {
            IndicatorIndex = digitDisplay.Count - 1;
        }
        UpdateIndicator();
    } 

    protected void MoveCursorRight () {
        IndicatorIndex++;
        if (IndicatorIndex >= digitDisplay.Count) {
            IndicatorIndex = 0;
        }
        UpdateIndicator();
    }

    private void UpdateIndicator () {
        Vector3 newPosition = ActiveIndicator.position;
        newPosition.x = digitDisplay[IndicatorIndex].transform.position.x;
        ActiveIndicator.position = newPosition;
    }

    protected void ShiftDigit (int direction) {
        _currentGuess[IndicatorIndex] += direction;
        if (_currentGuess[IndicatorIndex] > 9) {
            _currentGuess[IndicatorIndex] = 0;
        } else if (_currentGuess[IndicatorIndex] < 0) {
            _currentGuess[IndicatorIndex] = 9;
        }

        UpdateDisplay();
    }

    protected void CheckSolution () {
        bool isCorrect = true;
        for (int i = 0; i < correctSolution.Count; i++) {
            isCorrect = isCorrect && correctSolution[i] == _currentGuess[i];
        }

        if (isCorrect) {
            Debug.Log("Nice");
        }
    }

    protected void UpdateDisplay () {
        for (int i = 0; i < digitDisplay.Count; i++) {
            digitDisplay[i].text = _currentGuess[i].ToString();
        }
        UpdateIndicator();
    }

}
