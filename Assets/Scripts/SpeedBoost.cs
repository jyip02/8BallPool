using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    private float speed;
    public float multiplier = 1.4f;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;



    }
    void onTriggerEnter (Collider Other)
    {
       /* if (other.CompareTag == ("Player"))
        {

            Pickup(other);

        }*/

    }
    void Pickup(Collider player)
    {
       /* Instantiate(transform.position, transform.rotation);
        player.transform.localScale *= multiplier;
        Destroy(gameObject);*/
    }

    // Update is called once per frame
    void Update()
    {

    }

}
