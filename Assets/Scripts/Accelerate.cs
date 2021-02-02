using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerate : MonoBehaviour
{
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Accelerate")
        {
            rb.AddForce(0, -10, -100);
        }
    }
}
