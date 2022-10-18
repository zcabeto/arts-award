using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endless : MonoBehaviour {

    // Use this for initialization
    private int length = 21;
    private int count = 0;
	
	// Update is called once per frame
	void Update ()
    {
        count += 1;
        if (count % 10 == 0)
        {
            count += 1000;
            gameObject.transform.localScale = new Vector3((length + count), 1, 1);
        }
	}
}
