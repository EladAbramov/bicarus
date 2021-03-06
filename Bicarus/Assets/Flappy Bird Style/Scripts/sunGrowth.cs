﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunGrowth : MonoBehaviour {

    private bool growthFlag = true;
    public float timeCounter = 1f;
    public float growthFacor = 0.005f;
    private float growthTimeCounter;
    // Use this for initialization
    void Start()
    {
        growthTimeCounter = timeCounter;
    }

    // Update is called once per frame
    void Update()
    {
        
       if (GameControl.instance.gameOver == true)
        {
           growthFlag = false;
        }
        //timeCounter += Time.deltaTime;
        timeCounter -= Time.deltaTime;
       if (timeCounter <= 0f && growthFlag)
        {
            /*
            Vector2 tmp = gameObject.transform.localScale;
            tmp.x += 0.1f;
            tmp.y += 0.1f;
            gameObject.transform.localScale = tmp;
            */
            transform.localScale += new Vector3(growthFacor, growthFacor, 0);
            timeCounter = growthTimeCounter;
        }

    }
}
