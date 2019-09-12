using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public abstract class States : ScriptableObject {
        
    [Header("Default")]
        [SerializeField] protected PlayerManager PlayerObject;
        public States PreviousState;

        [SerializeField] protected PlayerInputActions controls;

    public virtual void Initialize (PlayerInputActions _controls) {
        controls = _controls;
    }

    public virtual void Step () {
       
    }

    public virtual void EnableState () {
        //Each state has a specific control scheme to enable, all must be overriden.
    }

    public virtual void DisableState () {

    }

}
}

