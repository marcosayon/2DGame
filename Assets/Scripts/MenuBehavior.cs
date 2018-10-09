using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehavior : MonoBehaviour {
    
    //will play the first level when play button is clicked
    public void PlayGame(){
        SceneManager.LoadScene("LevelOneEnv");
    }

    //will open the options menu when options button is clicked
    public void Options(){
        SceneManager.LoadScene("OptionsMenu");
    }

    //will quit the game when quit button is clicked
    public void QuitGame(){
        Application.Quit();
    }

}
