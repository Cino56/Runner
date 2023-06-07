using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundspawner : MonoBehaviour
{
    [SerializeField] private GameObject templatePlatforms;

    private GameObject spawnPlatforms;
   
    private void Start()
    {
       InvokeRepeating("Platforms", 1, 2.5f);
    }

    private void Platforms()
    {
        spawnPlatforms = Instantiate(templatePlatforms, transform.position, Quaternion.identity) as GameObject;
    }
}
