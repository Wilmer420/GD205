﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W2Board : MonoBehaviour
{
    public GameObject player;
    Vector3 initPos;
    public Transform [] hazard;

    // Start is called before the first frame update
    void Start()
    {
        initPos = player.transform.position;
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
            player.transform.position += new Vector3(0,-1,0);

        }

        /*{
            player.transform.position += new Vector3(0, -1, 0);
        }*/

        for (int i = 0; i < hazard.Length; i++)
        {
            if (hazard[i].position == player.transform.position)
            {
                player.transform.position = initPos;
            }
        }

    }
}
