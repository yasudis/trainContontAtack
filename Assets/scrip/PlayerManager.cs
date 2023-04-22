using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public static float healf = 300;
    public static float speedAngle = 2f;
    public static int menyTorel;
    public static float damedgePlaer = 10;
    public static float damedgeTurel;
    public static int score = 0;
    public TextMeshProUGUI textScore;
    public void Update()
    {
        textScore.text = "Score " + score;
    }
}
