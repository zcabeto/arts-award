using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s2s_script : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;
    private int count = 0;
    public GameObject player;
    private Vector3 pos;
    private bool veri;
    //private string GB = "NONE";
    //private int BG;
    private void Start()

    {
        gameObject.transform.position = new Vector3(10, 0, 0);
    }
    private void Update()
    {
        //print(GB);    
    if (Input.GetKeyDown("space"))
        {
            veri = true;
        }
        if (veri)
        {
            count += 1;
            if (count > 100 && count < 200)
            {
                pos.x = player.gameObject.transform.position.x + 9.5f;
            }
            if (count >= 200 && count <= 250)
            {
                //BG = Random.Range(0, 2);
                //if (BG == 0)
                {
                    //GB = "GOOD";
                }
                //if (BG == 1)
                {
                    //GB = "BAD";
                }
                //gameObject.tag = GB;
                //print("ROCKET SENT");
                gameObject.tag = "BAD";
                pos.y = player.gameObject.transform.position.y;
                count = 0;
            }
            gameObject.transform.position = pos;
        }
    }
    void OnCollisionEnter2D(Collision2D thing)
    {
        if (thing.gameObject.tag == "Floor" || thing.gameObject.tag == "UnderFloor")
        {
            //print("ROCKET DESTROYED");
            pos.y = 10;
        }
        if (thing.gameObject.tag == "Player")
        {
            //print("ROCKET RECIEVED");
            pos.y = 10;
        }
    }
}