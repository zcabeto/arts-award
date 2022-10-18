using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;
    public Rigidbody2D rb;
    private bool onFloor = false;
    private const int MAX_JUMP = 10;
    private const int MAX_RUN = 12;
    //private float constant = 10;
    private bool var = false;
    private int count = 0;
    private int LIFE = 1;
    private Vector2 vel;
    public GameObject f1;
    public GameObject f2;
    //public GUIText coins;
    public GameObject moneyy;
    private Vector3 mon;
    // Update is called once per frame

    void FixedUpdate()
    {

        if (LIFE <= 0)
        {
            var = false;
            print("You died");
            vel.x = 0;
            gameObject.transform.position = new Vector3(-6.5f, -1, 0);
            f1.gameObject.transform.position = new Vector3(1, -2, 0);
            f1.gameObject.transform.localScale = new Vector3(5, 0.4f, 1);
            f2.gameObject.transform.position = new Vector3(6, 0.3f, 0);
            f2.gameObject.transform.localScale = new Vector3(5, 0.4f, 1);
            LIFE = 1;
        }
        //float moveHorizontal = Input.GetAxis("Horizontal");
        gameObject.transform.eulerAngles = new Vector3(0, 180, 0);
        float moveVertical = Input.GetAxis("Vertical");

        if (Input.GetKeyDown("space"))
        {
            var = true;
            LIFE = 1;
        }
        if (var == true)
        {
            count += 1;
            //Vector2 movement = new Vector2(constant, 0f);
            Vector2 vel = rb.velocity;
            vel.x = 11;
            rb.velocity = vel;
        }
        
        if (moveVertical > 0 && onFloor)
        {
            rb.AddForce(new Vector2(0f, 10f) * speed);
        }
        if (rb.velocity.y > MAX_JUMP)
        {
            Vector2 vel = rb.velocity;
            vel.y = MAX_JUMP;
            rb.velocity = vel;
        }

        if (Mathf.Abs(rb.velocity.x) > MAX_RUN)
        {
            Vector2 vel = rb.velocity;
            vel.x = Mathf.Sign(vel.x) * MAX_RUN;
            rb.velocity = vel;
        }

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            onFloor = true;
        }
        if (collision.gameObject.tag == "BAD")
        {
            print("-1");
            LIFE -= 1;
        }
        if (collision.gameObject.tag == "choc")
        {
            mon = moneyy.gameObject.transform.position;
            mon.x -= 1000;
            moneyy.gameObject.transform.position = mon;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            onFloor = false;
        }
    }
}