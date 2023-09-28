using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class charcontrol : MonoBehaviour
{
    float currentspeed, walkingspeed = 2, runningspeed = 4;
    // Start is called before the first frame update
    void Start()
    {
        currentspeed = walkingspeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += currentspeed * transform.forward * Time.deltaTime;
        }
   
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position -= currentspeed * transform.forward * Time.deltaTime;
        }

    }


}