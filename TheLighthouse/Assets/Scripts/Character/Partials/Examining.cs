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
                        _ExamineParent.SetActive(_isExamining);
                    }
                }

                [SerializeField] protected Transform _refPoint;
                [SerializeField] protected GameObject _ExamineParent;

                private InteractableObject _activeExamine;

                public struct InteractableObject {
                    public string name;
                    public string description;
                    public NarrativeType type;
                    public Transform mesh;
                    public Vector3 originalPosition;
                    public Quaternion originalRotation;
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

                Obj.mesh.position = _refPoint.position;

                _activeExamine = Obj;

                Debug.Log("Examining: " + Obj.name);
            }   

            public void ExitExamine () {
                canMove = true;
                isExamining = false;
                _controls.Movement.Enable();
                _controls.Examine.Disable();

                _activeExamine.mesh.position = _activeExamine.originalPosition;
                _activeExamine.mesh.rotation = _activeExamine.originalRotation;

                Debug.Log("Exit Examine State");
            }

            protected void Examine () {
                if (!isExamining) {
                    return;
                }

                _activeExamine.mesh.position += -Vector3.forward * _examineZoom / 100f * Time.deltaTime;
                _activeExamine.mesh.Rotate(new Vector3(_examineRotation.y, _examineRotation.x, 0) * 25f * Time.deltaTime, Space.World);
            }

            #endregion
            
        #endregion
    }

}
