using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    //variables

    [SerializeField] private GameObject doggPrefab;
    private float timer;

    // funciones

    private void shoot ()
    {
        Instantiate(doggPrefab, transform.position, Quaternion.Euler(0, -90, 0));
    }

    private void Update()
    {
        timer += Time.deltaTime;
 
        if (timer > 1 && Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
            timer = 0;
        }
    }
}
