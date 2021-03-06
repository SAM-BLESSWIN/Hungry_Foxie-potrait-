﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactermovement : MonoBehaviour
{
    public Playerinput swipecontrols;
    public Transform player;
    public float speed = 3f;
    public float xrange = 1f;
    private Vector3 desireddir;


    private void Start()
    {
        desireddir = player.transform.position;
    }
    private void Update()
    {
        if (swipecontrols.SwipeLeft || Input.GetKey(KeyCode.LeftArrow))
        {
            desireddir.x += -0.75f;
        }
        else if (swipecontrols.SwipeRight || Input.GetKey(KeyCode.RightArrow))
        {
            desireddir.x += 0.75f;
        }
        player.transform.position = Vector3.MoveTowards(player.transform.position, desireddir, speed * Time.deltaTime);
        desireddir.x = Mathf.Clamp(desireddir.x, -1 * xrange, xrange);
    }
}
