using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Examining
namespace PlayerManager
{
    public partial class PlayerManager {
        #region Examining 
            [Header("Examine Controls")]
                [SerializeField] protected bool _isExamining;
                public bool isExamining  {
                    get => _isExamining;
                    set {
                        _isExamining = value;
                        _animator.SetBool("isExamining", _isExamining);
                    }
                }

            #region Methods

            #endregion
        #endregion
    }

}
