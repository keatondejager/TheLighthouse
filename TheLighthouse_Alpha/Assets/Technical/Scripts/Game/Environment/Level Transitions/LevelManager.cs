using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{   
    AsyncOperation loadProgress;
    public int SceneToLoad = 0;

    public void QuitGame () {
        SceneManager.LoadScene(0);
    }

    public void LevelTransitionStart () {
        loadProgress = SceneManager.LoadSceneAsync(SceneToLoad, LoadSceneMode.Single);
        loadProgress.allowSceneActivation = false;
    }

    public void DoLevelTransition () {
        loadProgress.allowSceneActivation = true;
    }
}
