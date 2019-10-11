using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace Player {
    [CreateAssetMenu(fileName = "Menu State", menuName = "Player State/Menu")]
    public class Menus : States {
        [SerializeField] protected GameObject MenuObject;
        [SerializeField] protected GameObject MainMenuObject;
        [SerializeField] protected GameObject OptionsMenuObject;

        private float delay = 0f;
        public override void Initialize(PlayerInputActions _controls) {
            controls = _controls;
            PlayerObject = PlayerReference.instance.manager;
            MenuObject = PlayerReference.instance.menuObject;
            MainMenuObject = PlayerReference.instance.MainMenuObj;
            OptionsMenuObject = PlayerReference.instance.OptionsMenuObj;
            controls.Menus.Exit.performed += ctx => ExitState();
        }

        public override void Step() {
            if (delay > 0) {
                delay -= Time.deltaTime;
                if (delay <= 0) {
                    controls.Menus.Enable();
                }
            }
        }

        public override void EnableState() {
            delay = 2 * Time.deltaTime;
            MenuObject.SetActive(true);
        }

        public override void DisableState() {
            controls.Menus.Disable();
            MenuObject.SetActive(false);
        }

        public override void ExitState () {
            OptionsMenuObject.SetActive(false);
            MainMenuObject.SetActive(true);
            PlayerObject.SetState(_moveState);
        }

        public void QuitGame () {

            controls.Menus.Disable();
            SceneManager.LoadScene(0);
        }
    }
}