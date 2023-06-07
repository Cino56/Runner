using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundspaw : MonoBehaviour
{
     private GameObject spawnBackGround;

     [SerializeField] private int TimeSpawn = 1;

     [SerializeField] private float SpawnRate = 10f;

     [SerializeField] private GameObject templateBackGround;

     private void Start()
    {
        InvokeRepeating("BackGround", TimeSpawn, SpawnRate);
    }

     private void BackGround()
    {
       spawnBackGround = Instantiate(templateBackGround, transform.position, Quaternion.identity) as GameObject; 
    }
}
