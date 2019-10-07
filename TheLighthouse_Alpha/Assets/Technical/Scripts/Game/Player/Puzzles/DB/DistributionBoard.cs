using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistributionBoard : MonoBehaviour
{

    [SerializeField] protected DB_State activeState;

    [SerializeField] protected List<DB_State> allStates;
    [SerializeField] protected int stateIndex;

    // Start is called before the first frame update
    void Start()
    {   
        foreach(DB_State item in allStates) {
            item.Initialize(this);
            item.gameObject.SetActive(false);
        }
         activeState = allStates[0]; 
         activeState.Initialize(this);

         activeState.gameObject.SetActive(true);
    }

    private void Update() {
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

            activeState.gameObject.SetActive(true);
        }
        
    }


}
