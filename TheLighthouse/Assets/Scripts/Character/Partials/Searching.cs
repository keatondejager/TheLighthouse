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
            #region Methods




            protected void Search () {
                if (!isSearching) {
                    return;
                }
            }

            #endregion
        #endregion
    }
}
