using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

namespace Environment {
    public class Searchable : Interactable {

        //matt added all of this
        private PlayerManager player;

        [Header("Reference")]
        public SearchableObject ObjectBeingSearched;

        protected override void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (!player)
                {
                    player = PlayerReference.instance.manager;
                }
                PlayerReference.instance.searchObject = ObjectBeingSearched;
                player.OnInteractEnter += Interact;
                Prompt.SetActive(true);
            }
        }

        protected override void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (!player)
                {
                    player = PlayerReference.instance.manager;
                }
                PlayerReference.instance.searchObject = null;
                player.OnInteractEnter -= Interact;
                Prompt.SetActive(false);
            }
        }

        public override void Interact() {
            Debug.Log("We are searching an object");
            PlayerReference.instance.searchObject = ObjectBeingSearched;
        }
    }
}
