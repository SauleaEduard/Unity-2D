using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnlocation;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatToSpawnClone;

    public void spawnSomething(int i)
    {
        whatToSpawnClone[i] = Instantiate(whatToSpawnPrefab[i], spawnlocation[i].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }
}
