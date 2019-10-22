using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    
    public GameObject ConfirmQuitMenu; // To Be Added 

    public GameObject OptionsMenu;



    public void NewGame () {
        SceneManager.LoadScene(1);
    }   

    public void ContinueGame () {
        // TO BE ADDED
    } 

    public void Options () {
        OptionsMenu.SetActive(true);
    }

    public void QuitGame () {
        ConfirmQuitMenu.SetActive(true);
    }
}

