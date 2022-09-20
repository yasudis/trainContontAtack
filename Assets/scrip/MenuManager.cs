using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject panel;
    //public GameObject panelRespawn;
    static public bool isPaused=false;
    private static int numberOfScence=1;
    private void Start()
    {
        isPaused = false;
    }


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
        if (numberOfScence > 3)
        {
            numberOfScence = 1;
        }
        SceneManager.LoadScene("levelComplete");
    }
    public static void Change—ontinue()
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
    public void OnGUI()
    {
        if (isPaused == true)
        {
            Time.timeScale = 0;
            panel.SetActive(true);
            //panelRespawn.GetComponent<BoxCollider>().enabled = false;
            //mainmusic.Pause();


        }
        if (panel.active==true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }

        //else
       // {
       //     Time.timeScale = 1;
       //     panel.SetActive(false);
            //panelRespawn.GetComponent<BoxCollider>().enabled = true;
            //mainmusic.Play();
            //if (!mainmusic.isPlaying)
            //{ mainmusic.Play(); }

      //  }

    }

    public void OnApplicationFocus(bool hasFocus)
    {
        isPaused = !hasFocus;
    }

    public void OnApplicationPause(bool pauseStatus)
    {
        isPaused = pauseStatus;
    }
   
}
