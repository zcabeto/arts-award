using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow2 : MonoBehaviour {

    public GameObject floor2;
    private Vector3 pos;
    private Vector3 size;
    // Update is called once per frame
    void Update()
    {
        pos.x = floor2.transform.position.x;
        size.x = floor2.transform.localScale.x;
        gameObject.transform.position = new Vector3(pos.x, floor2.transform.position.y - 0.1f, 0f);
        gameObject.transform.localScale = new Vector3(size.x, 0.35f, 0f);
    }
}
