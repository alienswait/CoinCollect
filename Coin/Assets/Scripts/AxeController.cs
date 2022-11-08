﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeController : MonoBehaviour
{
    public GameObject target;
    void Update()
    {
        
        transform.RotateAround(target.transform.position, Vector3.up, 20 * Time.deltaTime);
    }
}
