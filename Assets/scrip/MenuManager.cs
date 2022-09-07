using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
     private static int numberOfScence=1;


    public void ChangeMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void ChangeRestart()
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
        numberOfScence += 1;
    }
    public static void LevelComplete()
    {
        numberOfScence += 1;
        SceneManager.LoadScene("LevelComplete");
    }
    public static void Change—ontinue()
    {
        
        SceneManager.LoadScene("scene_" + numberOfScence);
    }


}
