using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{   public GameObject hazard;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
     yield return new WaitForSeconds(1f);
     while (true)
        {
         for (int i = 0; i < 10f; i++)
            {

             Vector3 camera = Camera.main.transform.position;
             Vector3 spawnPosition = new Vector3(Random.Range(-camera.x - 5f, camera.x + 5f), camera.y + 10f, 0f);
             Quaternion spawnRotation = Quaternion.identity;
             Instantiate(hazard, spawnPosition, spawnRotation);
             yield return new WaitForSeconds(1f);

            }
         yield return new WaitForSeconds(10f);
        }
    }
}



