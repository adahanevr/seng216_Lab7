using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    private GameController _gameController;
    void Start()
    {
        _gameController = FindObjectOfType<GameController>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _gameController.CollectSphere();
            Destroy(gameObject); // destroy the sphere
        }
    }
}
