﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barnScroll : MonoBehaviour
{

    public float barnScrollSpeed = 3.0f;

    private float deathTimer = 10.0f;
    private float time;
 
    public GameObject barnPrefab;

    public float interpolatingPeriod = 1.0f;
    private bool needBarn = false;
    // Use this for initialization
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
       

        transform.Translate(Vector3.left * Time.deltaTime * barnScrollSpeed);
        time += Time.deltaTime;
        if (time >= deathTimer)
        {
            DestroyObject(gameObject);
        }
        needBarn = true;
    }


}