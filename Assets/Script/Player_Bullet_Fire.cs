using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet_Fire : MonoBehaviour
{
    public GameObject bullet;

    public float TimeNum; //�]�w�X��o�g�@���l�u
    public float i; //���Эp��

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
