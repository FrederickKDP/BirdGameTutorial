using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public Transform[] wallsArray;
    public float restTime = 3f, spawnTime = 3f;

    private void Start()
    {
        InvokeRepeating("SpawnWall", restTime, spawnTime);
    }

    void SpawnWall()
    {
        int selectedWall = 0;
        selectedWall = Random.Range(0,wallsArray.Length);
        Instantiate(wallsArray[selectedWall]);
    }
}
