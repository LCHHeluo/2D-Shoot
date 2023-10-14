using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Total : MonoBehaviour
{
    public static int ScoreNum;
    public static int RocketNum;
    public Text UI_Score1;
    public Text UI_Score2;
    public Text UI_Rocket1;
    public Text UI_Rocket2;
    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        RocketNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        UI_Score1.text = "Score " + ScoreNum;
        UI_Score2.text = "Score " + ScoreNum;
        UI_Rocket1.text = " " + RocketNum;
        UI_Rocket2.text = " " + RocketNum;
    }
}
