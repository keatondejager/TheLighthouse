using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;
using Environment;

[RequireComponent(typeof(NarrativeTrigger), typeof(Examinable))]
public class ClueTrigger : MonoBehaviour {

   public Examinable examineControl;

   public int index;

   private void OnEnable() {
       examineControl.OnNarrativeTrigger += Trigger;
   }

   private void OnDisable() {
       examineControl.OnNarrativeTrigger -= Trigger;
   }

   public void Trigger () {
       if (PlayerReference.instance.hasInteractedWithDoor) {
           NarrativeController.instance.TriggerNarrative(index);
       }
   }
}
