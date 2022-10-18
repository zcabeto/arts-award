using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins_set : MonoBehaviour {

    public GameObject m;
    public UnityEngine.UI.Text text;
    private Vector3 mon;
	// Update is called once per frame
	void Update ()
    {
        mon = m.gameObject.transform.position;
        text.text = "Points: " + mon.x;
	}
}