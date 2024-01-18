using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    float currentTime;
    public float startingTime = 30f;

    [SerializeField] Text CountdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        CountdownText.text = currentTime.ToString("0");
        
        if( currentTime >= 0)
        {
            currentTime = 0;
        }
        
    }
}
