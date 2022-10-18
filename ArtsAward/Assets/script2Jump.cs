using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script2Jump : MonoBehaviour
{
    public Rigidbody2D Rb;
    public float speed;
    private float count = 0;
    private Vector3 posi = new Vector3(8, -3, 0);
    private bool veri;
    public GameObject Jump1;

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
                posi.x = Jump1.gameObject.transform.position.x + 10;
                gameObject.transform.position = posi;
            }
            if (count % 100 == 0)
            {
                Vector2 move = new Vector2(0f, 25f);
                Rb.AddForce(move * speed);
            }
        }
    }
}