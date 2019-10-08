using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistributionBoard : MonoBehaviour
{
    [Header("State Control")]
        [SerializeField] protected DB_State activeState;
        [SerializeField] protected List<DB_State> allStates;
        [SerializeField] protected int stateIndex;
        [SerializeField] protected bool isEnabled;

    [Header("UI Reference")]
        [SerializeField] protected GameObject UIObject;
        [SerializeField] protected Transform PuzzleObjects;
        [SerializeField] protected Transform ReferencePoint;
        private Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {   
        InitializeControllers();
        activeState = allStates[0]; 
    }

    public void OpenPuzzle () {
        UIObject.SetActive(true);
        originalPosition = PuzzleObjects.position;
        PuzzleObjects.position = ReferencePoint.position;

        activeState.gameObject.SetActive(true);
        isEnabled = true;
    }

    public void ClosePuzzle() {
        UIObject.SetActive(false);
        PuzzleObjects.position = originalPosition;

        isEnabled = false;
        InitializeControllers(false);
    }

    private void InitializeControllers (bool firstTime = true) {
        foreach(DB_State item in allStates) {
            if (firstTime) {
                item.Initialize(this);
            }
            item.gameObject.SetActive(false);
        }
    }

    private void Update() {
        if (!isEnabled) {
            return;
        }

        if (activeState) {
            activeState.Step();
        }
    }

    public void StateComplete() {
        activeState.gameObject.SetActive(false);
        activeState = null;
        stateIndex++;
        if (stateIndex < allStates.Count) {
            activeState = allStates[stateIndex];
            if (isEnabled) {
                activeState.gameObject.SetActive(true);
            }
        }
    }


}
