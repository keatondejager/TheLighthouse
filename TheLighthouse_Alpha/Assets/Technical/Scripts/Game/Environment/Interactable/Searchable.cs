﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

namespace Environment {
    public class Searchable : Interactable {
        [Header("Search Specific")]
            [SerializeField] protected SearchableObjectData ObjectInventory;

        public override void OnTriggerEnter(Collider other) {
            if (ObjectInventory.inventory.Count > 0) {
                base.OnTriggerEnter(other);
                PlayerReference.instance.objectInventory = ObjectInventory;
            }
        }

        public override void OnTriggerExit(Collider other) {
            base.OnTriggerExit(other);
            PlayerReference.instance.objectInventory = null;
        }

        public override void Interact() {
            PlayerReference.instance.objectInventory = ObjectInventory;
            base.Interact();
        }
    }
}
