using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Examining
namespace PlayerManager
{
    public partial class PlayerManager {
        #region Examining 
            [Header("Examine Particulars")] 
                [SerializeField] protected bool _isExamining;
                public bool isExamining  {
                    get => _isExamining;
                    set {
                        _isExamining = value;
                        _animator.SetBool("isExamining", _isExamining);
                    }
                }

                public struct InteractableObject {
                    public string name;
                    public string description;
                    public NarrativeType type;
                }

            [Header("Examine Controls")]
                [SerializeField] protected float _examineZoom;
                [SerializeField] protected Vector2 _examineRotation;
           

            #region Methods

            public void SetExamine (InteractableObject Obj) {
                canMove = false;
                isExamining = true;
                _controls.Movement.Disable();
                _controls.Examine.Enable();

                Debug.Log("Examining: " + Obj.name);
            }   

            public void ExitExamine () {
                canMove = true;
                isExamining = false;
                _controls.Movement.Enable();
                _controls.Examine.Disable();

                Debug.Log("Exit Examine State");
            }

            protected void Examine () {
                if (!isExamining) {
                    return;
                }

                Debug.Log(_examineZoom);
            }

            #endregion
            
        #endregion
    }

}
