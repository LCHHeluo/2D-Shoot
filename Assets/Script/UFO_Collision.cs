using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UFO_Collision : MonoBehaviour
{
    public static float UFO_Life_Num; //UFO¥Í©R­È
    public GameObject Explosion; //UFOÃz¬µ
    public Slider UI_Life; //UFO¦å±ø
    public GameObject Fill_Area; // UFO Fill
    // Start is called before the first frame update
    void Start()
    {
        UFO_Life_Num = 1;
    }

    // Update is called once per frame
    void Update()
    {
        UI_Life.value = UFO_Life_Num;
        if (UFO_Life_Num < 0.09)
        {
            Fill_Area.SetActive(false);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            UFO_Life_Num -= 0.1f;
            Instantiate(Explosion, collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Rocket")
        {
            UFO_Life_Num -= 0.2f;
            Instantiate(Explosion, collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
        }
    }
}
