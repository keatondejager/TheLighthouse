using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{

    protected PlayerInputActions controls;
    // Start is called before the first frame update
    private void OnEnable() {
        controls = new PlayerInputActions();

        controls.PuzzleControls.Close.performed += ctx => SceneManager.LoadScene(0);
        controls.PuzzleControls.Enable();
    }

    private void OnDisable() {
        controls.PuzzleControls.Disable();
    }


}
