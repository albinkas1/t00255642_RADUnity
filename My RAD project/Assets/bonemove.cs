using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.XR;

public class bonemove : MonoBehaviour
{
    public GameObject ball;

    float currentSpeed, walkingSpeed = 2, runningSpeed = 4;
    private float turningSpeed = 180;
    Animator bonestuff;

    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = walkingSpeed;
        bonestuff = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bonestuff.SetBool("Walking", false);


        if (Input.GetKey(KeyCode.W))
        {
            bonestuff.SetBool("Walking", true);
            transform.position += currentSpeed * transform.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            bonestuff.SetBool("Walking", true);
            transform.position -= currentSpeed * transform.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime);
        }

        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBall = Instantiate(ball);

            ballthrow ballthrow = newBall.GetComponent<ballthrow>();

            ballthrow.ImThrowingYou(this);
        }
    }
}
