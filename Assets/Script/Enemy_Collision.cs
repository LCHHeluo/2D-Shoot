using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Collision : MonoBehaviour
{
    public GameObject explosion;
    public GameObject Get_Rocket;
    private int Random_Num;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Rocket")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Score_Total.ScoreNum += 20;
            Random_Num = Random.Range(0, 5); // (0,5]
            Debug.Log("Random=" + Random_Num);
            if (Random_Num == 0)
            {
                Instantiate(Get_Rocket, transform.position, transform.rotation);
            }
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Left_Collider")
        {
            Destroy(gameObject); 
        }
    }
}
