using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    public int MoveSpeed;
    public float Y_Pos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ChangY_Pos", 0f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(MoveSpeed * Time.deltaTime, Y_Pos*Time.deltaTime, 0);
    }

    void ChangY_Pos()
    {
        Y_Pos = Y_Pos * -1;
    }
}
