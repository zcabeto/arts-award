using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour
{

    public GameObject player;

    private void Update()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //Vector2 move = new Vector2(moveHorizontal, 0f);

        Vector3 camPos = Camera.main.transform.position;
        camPos.x = player.transform.position.x;
        Camera.main.transform.position = camPos;
    }
}