using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Fire : MonoBehaviour
{
    public GameObject Laser;
    public float Time_Num;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 0f, Time_Num);
    }

    void Fire()
    {
        Instantiate(Laser, transform.position, transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
