using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionBalls : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "pockets")

        {
            Destroy(gameObject);
        }
    }
}
