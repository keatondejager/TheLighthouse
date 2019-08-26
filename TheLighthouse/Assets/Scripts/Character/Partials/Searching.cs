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

            #region Methods


            public void StartSearch () {
               isSearching = true;
               canMove = false;
               isExamining = false;

               CurrentState = PlayerState.Interacting;
               _SearchParent.SetActive(true);

               _controls.Movement.Disable();
               _controls.Search.Enable();
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
