using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size_repeat2 : MonoBehaviour {
    private Vector3 size = new Vector3(5, 0.4f, 1);
    private Vector3 xVal = new Vector3(8, 1, 0);
    private bool veri = false;
    private int count = 0;
    public GameObject Floor1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            veri = true;
        }
        if (veri == true)
        {
            count += 1;
            if (count % 326 == 0)
            {
                size.x = Random.Range(5f, 10f);
                gameObject.transform.localScale = size;
                xVal.x = Floor1.gameObject.transform.position.x + Random.Range(5f, 8f);
                gameObject.transform.position = xVal;
            }
        }
    }
}
