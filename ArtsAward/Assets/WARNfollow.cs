using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WARNfollow : MonoBehaviour {

    public GameObject player;
    public GameObject s2s;
    private int count = 0;
    private Vector3 pos;
    private bool veri;

    private void Start()
    {
        gameObject.transform.position = new Vector3(9, 0, 0);
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown("space"))
        {
            veri = true;
        }
        if (veri)
        {
            count += 1;

            if (count > 100 && count < 200)
            {
                pos.y = player.gameObject.transform.position.y;
                pos.x = s2s.gameObject.transform.position.x - 1.5f;
            }
            if (count > 200)
            {
                pos.y = 10;
                count = 0;
            }
            gameObject.transform.position = pos;
        }
	}
}
