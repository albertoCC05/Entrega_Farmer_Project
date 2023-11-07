using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    //variables

    [SerializeField] private GameObject doggPrefab;

    // funciones

    private void shoot ()
    {
        Instantiate(doggPrefab, transform.position, Quaternion.Euler);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
        }
    }
}
