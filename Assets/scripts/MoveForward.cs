using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    //variables

    [SerializeField] private float dogSpeed;

    // update

    private void Update()
    {
        transform.Translate(Vector3.forward * dogSpeed * Time.deltaTime);
    }
}
