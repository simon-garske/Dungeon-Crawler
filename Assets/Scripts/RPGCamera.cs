﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGCamera : MonoBehaviour {

    public Transform target;
    private Vector3 offset;

    void Start()
    {
        offset = target.position - transform.position;
    }

    void LateUpdate()
    {
        transform.position = target.position - offset;
    }
}
