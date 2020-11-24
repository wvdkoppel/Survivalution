﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //public float Speed;

    void Update()
    {
        Vector3 Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Target.z = transform.position.z;

        //transform.position = Vector3.MoveTowards(transform.position, Target, Speed * Time.deltaTime / transform.localScale.x);
        //transform.position = Vector3.MoveTowards(transform.position, Target, Speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Target, PlayerStats.movementSpeed * Time.deltaTime);
    }
}
