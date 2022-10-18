using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper2_script : MonoBehaviour
{
    public Rigidbody2D Rb;
    public float speed;
    private float count = 0;
    private Vector3 posi = new Vector3(8, -2, 0);
    private bool veri;
    public GameObject player;

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            veri = true;
        }
        if (veri == true)
        {

            count = count + 1f;
            if (count % 50 == 0)
            {
                posi.x = player.gameObject.transform.position.x + 20;
                gameObject.transform.position = posi;
            }
            if (count % 100 == 0)
            {
                Vector2 move = new Vector2(0f, 25f);
                Rb.AddForce(move * speed);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }
}