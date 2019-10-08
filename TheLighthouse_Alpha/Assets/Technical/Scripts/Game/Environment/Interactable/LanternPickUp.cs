using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

namespace Environment
{
    public class LanternPickUp : Interactable
    {
        [Header("Lantern Specific")]
            [SerializeField] protected GameObject LanternObject;

        public override void OnTriggerEnter(Collider other) {
            base.OnTriggerEnter(other);
        }
    }

}
