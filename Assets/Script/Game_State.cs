using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_State : MonoBehaviour
{
    public static bool State = true;
    public GameObject GamePass;
    public GameObject GameOver;
    public GameObject Replay_btn;
    public GameObject Exit_btn;
    // Start is called before the first frame update
    void Start()
    {
        State = true;
        Player_Collision.Player_Life_Num = 1;
        UFO_Collision.UFO_Life_Num = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player_Collision.Player_Life_Num <= 0)
        {
            State = false;
            GameOver.SetActive(true);
            Replay_btn.SetActive(true);
            Exit_btn.SetActive(true);
        }
        if (Player_Collision.Player_Life_Num > 0 && UFO_Collision.UFO_Life_Num <= 0.09) 
        {
            State = false;
            GamePass.SetActive(true);
            Replay_btn.SetActive(true);
            Exit_btn.SetActive(true);
        }
    }
}
