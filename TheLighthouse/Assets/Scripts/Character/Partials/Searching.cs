using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Searching
namespace PlayerManager
{
    public partial class PlayerManager {
        #region Searching 
            [Header("Search Controls")]
                [SerializeField] protected bool _isSearching;
                public bool isSearching  {
                    get => _isSearching;
                    set {
                        _isSearching = value;
                        _animator.SetBool("isSearching", _isSearching);
                    }
                }

                [SerializeField] protected GameObject _SearchParent;

                [SerializeField] protected List<Item> _items;
                [SerializeField] protected List<GameObject> _itemDisplay;

            #region Methods


            public void StartSearch (List<Item> inventory) {
               isSearching = true;
               canMove = false;
               isExamining = false;

               CurrentState = PlayerState.Interacting;
               _SearchParent.SetActive(true);

               _controls.Movement.Disable();
               _controls.Search.Enable();

                foreach (GameObject obj in _itemDisplay) {
                    obj.SetActive(false);
                }

               for (int i = 0; i < inventory.Count; i++) {
                   for (int j = 0; j < _items.Count; j++) {
                       if (inventory[i] == _items[j]) {
                           _itemDisplay[j].SetActive(true);
                       }
                   }
               }
            }

            protected void Search () {
                if (!isSearching) {
                    return;
                }

            }

            public void ExitSearch () {
                CurrentState = PlayerState.Movement;
                canMove = CurrentState == PlayerState.Movement;

                isSearching = false;
                isExamining = false;

                _controls.Search.Disable();
                _controls.Movement.Enable();

                _SearchParent.SetActive(false);
            }

            #endregion
        #endregion
    }
}
