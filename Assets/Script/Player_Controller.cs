using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public int MoveSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Game_State.State == true)
        {
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(MoveSpeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-MoveSpeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, MoveSpeed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, -MoveSpeed * Time.deltaTime, 0);
            }
        }
    }
}
