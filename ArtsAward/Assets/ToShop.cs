using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToShop : MonoBehaviour {

    public GameObject character;
    public GameObject start;
    public GameObject j1;
    public GameObject s2s;
    public GameObject s2sW;
    public GameObject fb;
    public GameObject f1;
    public GameObject f2;
    public GameObject bf1;
    public GameObject bf2;
    public GameObject sb;
    public GameObject ps;
    public GameObject eb;
    public GameObject a;
    public GameObject w;
    public GameObject Fb;
    public GameObject cs;


    List<GameObject> shopThings = new List<GameObject>();
    private bool check = false;
    private int other = 0;

    public ToShop()
    {
        shopThings.Add(sb);
    }

    // Update is called once per frame
    private void Update()
    {
        other += 1;
        if (other > 20)
        {
            check = !check;
        }
    }
    private void OnMouseDown()
    {
        if (check == false)
        {
            other = 0;
            print("In");
            character.SetActive(false);
            start.SetActive(false);
            j1.SetActive(false);
            s2s.SetActive(false);
            s2sW.SetActive(false);
            fb.SetActive(false);
            f1.SetActive(false);
            f2.SetActive(false);
            bf1.SetActive(false);
            bf2.SetActive(false);
            sb.SetActive(true);
            ps.SetActive(true);
            eb.SetActive(true);
            a.SetActive(true);
            w.SetActive(true);
            Fb.SetActive(true);
            cs.SetActive(true);
        }
        if (check == true)
        {
            other = 0;
            print("Out");
            character.SetActive(true);
            start.SetActive(true);
            j1.SetActive(true);
            s2s.SetActive(true);
            s2sW.SetActive(true);
            fb.SetActive(true);
            f1.SetActive(true);
            f2.SetActive(true);
            bf1.SetActive(true);
            bf2.SetActive(true);
            sb.SetActive(false);
            ps.SetActive(false);
            eb.SetActive(false);
            a.SetActive(false);
            w.SetActive(false);
            Fb.SetActive(false);
            cs.SetActive(false);
        }
        
    }
}
