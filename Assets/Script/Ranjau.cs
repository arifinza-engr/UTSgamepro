﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranjau : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        ScoringSystem.theScore -= 50;
        Destroy(gameObject);
    }
}
