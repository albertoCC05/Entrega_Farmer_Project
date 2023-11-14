using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBalls : MonoBehaviour
{
    //Variables

    [SerializeField] private float DownSpeed;


    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * DownSpeed);
    }
}
