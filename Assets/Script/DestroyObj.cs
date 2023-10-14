using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    public float Time;

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, Time);
    }
}
