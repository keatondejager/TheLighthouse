using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
                [SerializeField] protected TMP_Text _objectName;
                [SerializeField] protected TMP_Text _objectDescription;
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
                [Range(1f, 2.5f)][SerializeField] protected float _MaxZoom = 1f;
           

            #region Methods

            public void SetExamine (InteractableObject Obj) {

                CurrentState = PlayerState.Examining;

                canMove = false;
                isSearching = false;
                isExamining = true;
                _controls.Movement.Disable();
                _controls.Examine.Enable();

                Obj.mesh.position = _refPoint.position;

                _objectName.text = Obj.name;
                _objectDescription.text = Obj.description;

                _activeExamine = Obj;

                Debug.Log("Examining: " + Obj.name);
            }   

            public void ExitExamine () {
                isExamining = false;

                CurrentState = _previousState;

                canMove = CurrentState == PlayerState.Movement;
                isSearching = CurrentState == PlayerState.Interacting;

                if (canMove) {
                    _controls.Movement.Enable();
                }
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
                if (_activeExamine.mesh.position.z > _refPoint.position.z + _MaxZoom) {
                    _activeExamine.mesh.position = _refPoint.position + Vector3.forward * _MaxZoom;
                } else if (_activeExamine.mesh.position.z < _refPoint.position.z - _MaxZoom) {
                    _activeExamine.mesh.position = _refPoint.position - Vector3.forward * _MaxZoom;
                }
                _activeExamine.mesh.Rotate(new Vector3(_examineRotation.y, _examineRotation.x, 0) * 50f * Time.deltaTime, Space.World);
            }

            #endregion
            
        #endregion
    }

}
