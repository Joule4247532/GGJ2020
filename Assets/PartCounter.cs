﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject FinalProductPrefab;
    public int myId = 0;
    public int myparts=0;
    [SerializeField]
    public bluePrints bp;
    int maxPart=0;
    void Start()
    {
       if(myId==0)
        {
            this.maxPart = 4;
        }
        if (myId == 1)
        {
            this.maxPart = 6;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(myparts==maxPart)
        {
            HasAllPArts();
        }
    }
    void HasAllPArts()
    {
        Instantiate(FinalProductPrefab, this.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
