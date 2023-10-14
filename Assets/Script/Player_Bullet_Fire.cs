using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet_Fire : MonoBehaviour
{
    public GameObject bullet;

    public float TimeNum; //設定幾秒發射一顆子彈
    public float i; //指標計數

    void Update()
    {
        if (Game_State.State == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                i = i + Time.deltaTime;
                if (i >= TimeNum)
                {
                    Instantiate(bullet, transform.position, transform.rotation);
                    i = 0;
                }

            }
        }
    }
}
