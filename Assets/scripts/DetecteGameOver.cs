using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetecteGameOver : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.y <= 0)
        {
            Destroy(gameObject);
            Debug.Log("GAME OVER");

            Time.timeScale = 0;
        }



    }
}
