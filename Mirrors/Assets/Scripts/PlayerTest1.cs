﻿using UnityEngine;
using System.Collections;

public class PlayerTest1 : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "FallTrigger")
        {
            transform.position = spawnPoint.position;
        }
    }
}
