using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int totalSpheres;
    private int collectedSpheres = 0;
    
    void Start()
    {
        totalSpheres = GameObject.FindGameObjectsWithTag("Sphere").Length; // compute the total number of spheres by looking at the tags
    }
    
    public void CollectSphere()
    {
        collectedSpheres++;
        if (collectedSpheres >= totalSpheres)
        {
            EndGame();
        }
    }
    
    void EndGame()
    {
        Debug.Log("All spheres collected! Game over!");
    }
}
