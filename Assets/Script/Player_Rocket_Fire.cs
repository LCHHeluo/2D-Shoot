using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Rocket_Fire : MonoBehaviour
{
    public GameObject rocket;
  
    // Update is called once per frame
    void /*Fixed*/Update()
    {
        if (Game_State.State == true)
        {
            if (Score_Total.RocketNum > 0)
            {
                if (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
                {
                    Instantiate(rocket, transform.position, transform.rotation);
                    Score_Total.RocketNum -= 1;
                }
            }
        }
    }
}
