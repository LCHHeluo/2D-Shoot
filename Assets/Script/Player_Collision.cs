using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Collision : MonoBehaviour
{
    public AudioClip Get_Rocket_Sound;
    public static float Player_Life_Num;
    public Slider UI_Life;
    public GameObject Fill_Area;
    public AudioClip Hit_Sound;
    public GameObject TriggerB_Enemy;
    public GameObject TriggerC_Enemy;
    public GameObject TriggerD_Enemy;
    public GameObject UFO_Boss; 
    public GameObject UFO_Life;
    private void Start()
    {
        Player_Life_Num = 1;
    }

    private void Update()
    {
        UI_Life.value = Player_Life_Num;
        if (Player_Life_Num < 0.09)
        {
            Fill_Area.SetActive(false);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Get_Rocket")
        {
            Score_Total.RocketNum += 1;
            GetComponent<AudioSource>().PlayOneShot(Get_Rocket_Sound);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Player_Life_Num -= 0.1f;
            GetComponent<AudioSource>().PlayOneShot(Hit_Sound);
            StartCoroutine(Alpha());
        }
        if (collision.gameObject.tag == "Laser")
        {
            Player_Life_Num -= 0.1f;
            GetComponent<AudioSource>().PlayOneShot(Hit_Sound);
            Destroy(collision.gameObject);
            StartCoroutine(Alpha());
        }
        if (collision.gameObject.tag == "TriggerB")
            TriggerB_Enemy.SetActive(true);
        if (collision.gameObject.tag == "TriggerC")
            TriggerC_Enemy.SetActive(true);
        if (collision.gameObject.tag == "TriggerD")
            TriggerD_Enemy.SetActive(true);
        if (collision.gameObject.tag == "TriggerE")
        {
            UFO_Boss.SetActive(true);
            UFO_Life.SetActive(true);
        }
    }

    IEnumerator Alpha()
    {
        GetComponent<SpriteRenderer>().color = new Color(1, 0.1f, 0.1f, 0.5f); //顯示偏紅色
        yield return new WaitForSeconds(0.2f);
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f); //顯示原色
    }
}
