using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBuy : MonoBehaviour {

    
    public GameObject moneyy;
    public int price;
    private float money;

    private void OnMouseDown()
    {
        money = moneyy.gameObject.transform.position.x;
        if (money >= price)
        {
            print(money);
            money -= price;
            print("You have bought this item, your points are: ");
            print(money);
        }
        else
        {
            print("You do not have enough points to buy this");
        }
    }
}