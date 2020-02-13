﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W2Board : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) //left//
        {
            player.transform.position += new Vector3(0, 0, 1);

        }
        if (Input.GetKeyDown(KeyCode.D)) //right//
        {
            player.transform.position += new Vector3(0, 0, -1);

        }
        //if (Input.GetKeyDown(KeyCode.Q)) //up//
        {
            //player.transform.position += new Vector3(0, 1, 0);

        }
        //if (Input.GetKeyDown(KeyCode.E)) //down//
        {
           //player.transform.position += new Vector3(0, -1, 0);

        }
        if (Input.GetKeyDown(KeyCode.W)) //forward//
        {
            player.transform.position += new Vector3(1, 0, 0);

        }
        if (Input.GetKeyDown(KeyCode.S)) //backwards//
        {
            player.transform.position += new Vector3(-1, 0, 0);

        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            player.transform.position = new Vector3(0,1,0);

        }
    }
}
