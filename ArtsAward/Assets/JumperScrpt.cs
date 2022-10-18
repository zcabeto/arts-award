using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumperScrpt : MonoBehaviour
{
    public Rigidbody2D Rb;
    public float speed;
    private float count = 0;
    private Vector3 posi = new Vector3(3.5f, -3, 0);
    private bool veri;
    public GameObject player;

    // Update is called once per frame

    void Update()
    {
        gameObject.transform.eulerAngles = new Vector3(0, 0, -10);
        if (veri == false)
        {
            gameObject.transform.position = new Vector3(3.5f, -3, 0);
        }
        
        gameObject.tag = "choc";
        if (Input.GetKeyDown("space"))
        {
            veri = true;
        }
        if (veri == true)
        {

            count = count + 1f;
            if (count % 55 == 0)
            {
                posi.x = player.gameObject.transform.position.x + 10;
                gameObject.transform.position = posi;
            }
            if (count % 100 == 0)
            {
                Vector2 move = new Vector2(0, 25);
                Rb.AddForce(move * speed);
            }
        }
    }
}
