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
       // numberOfScence += 1;
    }
    public static void LevelComplete()
    {
        numberOfScence += 1;
        SceneManager.LoadScene("levelComplete");
    }
    public static void ChangeÑontinue()
    {
        
        SceneManager.LoadScene("scene_" + numberOfScence);
    }
    public static void ChangeNewGame()
    {
        numberOfScence = 1;
        SceneManager.LoadScene("scene_" + numberOfScence);

    }
    public static void ChangeNextLevel()
    {
        
        SceneManager.LoadScene("scene_" + numberOfScence);

    }

}
