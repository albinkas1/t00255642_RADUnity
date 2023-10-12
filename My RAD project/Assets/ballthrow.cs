using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballthrow : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //DealWithHits thingIHit = collision.gameObject.GetComponent<DealWithHits>();
        //if (thingIHit != null)
        //{
            //thingIHit.IHitYou();
        //}
    }

    public void ImThrowingYou(bonemove bonemove)
    {
        transform.position = bonemove.transform.position + 2 * Vector3.up + 3 * bonemove.transform.forward;
        rb = GetComponent<Rigidbody>();

        rb.velocity = 10 * (2 * Vector3.up + 3 * bonemove.transform.forward);


    }
}
