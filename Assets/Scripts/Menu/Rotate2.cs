using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2 : MonoBehaviour
{
    public Vector3 vec;
    public float speed = 5f;
    void Update()
    {
        transform.Rotate(vec * Time.deltaTime * speed, Space.World);
    }
}
