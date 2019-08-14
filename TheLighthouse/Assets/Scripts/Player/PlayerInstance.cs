using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInstance : PlayerManager
{
   private void Start() {
       base.Initialize();
   }

   override public void Move(Vector3 direction) {
       if (Vector3.Equals(direction, transform.forward))
            return;
       transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
       base.Move(direction);
   }

   private void Update() {
       Move(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
   }
}
