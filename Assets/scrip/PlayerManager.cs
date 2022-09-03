using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    
    public static float healf=300;
    public static float speedOfAngle=2f;
    public static int menyTorel;
    public static float damedgePlaer;
    public static float damedgeTurel;
    public static int score = 0;
    public TextMeshProUGUI textOfScore;


    // Start is called before the first frame update
    void Start()
    {
       
        damedgePlaer = 5f;
        speedOfAngle = 2f;

    }
    public void Update()
    {
        
        textOfScore.text = "Score " + score;  
    }

}
