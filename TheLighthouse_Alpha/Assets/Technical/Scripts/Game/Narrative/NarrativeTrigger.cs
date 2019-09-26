using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Environment;

public class NarrativeTrigger : MonoBehaviour
{
    public enum TriggerType {
        Examine = 0, Search = 1, EnterSpace = 2
    }

    public TriggerType triggerType = TriggerType.Examine;
    public ushort CueIndex = 0; 

    public Examinable inCaseOfExamine;
    public Interactable inCaseOfSearch;

    private bool hasReferences = false;
    
    private void OnEnable() {
        if (triggerType == TriggerType.Examine) {
            if (inCaseOfExamine.isNarrativeTrigger) {
                inCaseOfExamine.OnNarrativeTrigger += CueNarrative;
                hasReferences = true;
            } 
        }

        if (triggerType == TriggerType.Search) {
            if (inCaseOfSearch.isNarrativeTrigger) {
                inCaseOfSearch.OnNarrativeTrigger += CueNarrative;
                hasReferences = true;
            } 
        }
    }

    private void OnDisable() {
        RemoveReferences();
    }

    private void RemoveReferences () {
        if (!hasReferences) {
            return;
        }

        if (triggerType == TriggerType.Examine) {
            if (inCaseOfExamine.isNarrativeTrigger) {
                inCaseOfExamine.OnNarrativeTrigger -= CueNarrative;
                hasReferences = false;
            } 
        }

        if (triggerType == TriggerType.Search) {
            if (inCaseOfSearch.isNarrativeTrigger) {
                inCaseOfSearch.OnNarrativeTrigger -= CueNarrative;
                hasReferences = false;
            } 
        }
    }

    public void CueNarrative () {
        NarrativeController.instance.TriggerNarrative(CueIndex);
        RemoveReferences();
    }

    private void OnTriggerEnter(Collider other) {
        if (triggerType == TriggerType.EnterSpace && other.CompareTag("Player")) {
            NarrativeController.instance.TriggerNarrative(CueIndex);
        }
    }




}
