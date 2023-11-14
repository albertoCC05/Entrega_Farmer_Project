using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyDogs : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.x <= -28) 
        {
            Destroy(gameObject);
        }
    }
}
