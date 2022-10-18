using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size_repeat : MonoBehaviour {
    private Vector3 size = new Vector3(5, 0.4f, 1);
    private Vector3 xVal = new Vector3(3, -2, 0);
    private bool veri = false;
    private int count = 0;
    public GameObject player;
    private Vector3 p;
	
	// Update is called once per frame
	void Update ()
    {
        p = player.gameObject.transform.position;
        if (Input.GetKeyDown("space"))
        {
            veri = true;
        }
        if (veri == true)
        {
            count += 1;

            if (xVal.x <= p.x - 15)
            {
                
                size.x = Random.Range(5f, 10f);
                gameObject.transform.localScale = size;
                xVal.x = p.x + 15;
                gameObject.transform.position = xVal;
                //xVal.x = xVal.x + 60 + ((count / 325) * 2);
            }
        }
	}
}
