﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void Update()
    {
        if(transform.position.y < -7)
        {
            Destroy(this.gameObject);
        }
    }
}
