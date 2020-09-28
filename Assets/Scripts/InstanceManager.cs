﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToCreate;
    public Transform point;

    // Start is called before the first frame update
    void Start()
    {
        CreateObject();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateObject()
    {
        Instantiate(objectToCreate, point);
    }
}
