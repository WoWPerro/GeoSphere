using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerate2 : MonoBehaviour
{
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Accelerate2")
        {
            rb.AddForce(0, 500, -500);
        }
    }
}
