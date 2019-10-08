using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyState : DB_State
{

    public int ActualState = 0;

    public override void Initialize(DistributionBoard myManager) {
        base.Initialize(myManager);
    }
    public override void ControlsSetUp() {
        
    }
    public override void Step() {

    }

    public int GetState () {
        return ActualState;
    }

    protected override void OnEnable() {
        
    }

    protected override void OnDisable() {
        
    }



}
