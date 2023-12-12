using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //variables


    [SerializeField] private GameObject[] BallPrefabArray;
    private int ballIndex;
    private float spawnRangex = 9f;
    private float spawnRangex2 = -26f;
    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float spawnInterval = 1.5f;






    //funciones

    private void SpawnRandomAnimal()
    {
        ballIndex = Random.Range(0, BallPrefabArray.Length);

        Instantiate(BallPrefabArray[ballIndex], RandomSpawnPos(), Quaternion.Euler(90,0,0));


    }

    private Vector3 RandomSpawnPos()
    {
        float randomX = Random.Range(spawnRangex2, spawnRangex);
       

        return new Vector3(randomX, 23, -7);



    }


    //start/update



    private void Start()
    {

        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);

    }


}
