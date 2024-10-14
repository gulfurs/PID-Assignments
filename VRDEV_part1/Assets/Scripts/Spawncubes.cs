using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawncubes : MonoBehaviour
{
    public GameObject cubePrefab;
    public Transform spawnPoint;    
    public void OnActivate()
    {
   
        SpawnNewCube();
    }
    public void SpawnNewCube()
    {
        Instantiate(cubePrefab, spawnPoint.position, spawnPoint.rotation);
    }
    // Made by Simon Axelsen
}
