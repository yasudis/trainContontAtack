using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void ChangeRestart(int numberOfScence)
    {
        
        SceneManager.LoadScene("scene_"+numberOfScence);

    }

    public void ChangeExit()
    { 
        Application.Quit();
        Debug.Log("Exit");
    }
    public  static void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }


}
