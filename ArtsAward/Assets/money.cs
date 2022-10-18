using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money : MonoBehaviour {

    public GameObject player;
    private float mon;
    private Vector3 pos = new Vector3(0, 0, 0);
	// Update is called once per frame
	void Update ()
    {
        mon = player.gameObject.transform.position.x + 6.5f;
        mon = mon / 10;
        mon = (int)mon;
        pos.x = mon;
        if (pos.x < -10)
        {
            pos = new Vector3(0, 0, 0);
        }
        gameObject.transform.position += pos;
        
	}
}
