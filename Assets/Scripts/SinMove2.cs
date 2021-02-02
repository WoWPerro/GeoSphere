using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinMove2 : MonoBehaviour
{
    public int movementx;
    public int movementy;
    public int movementz;
    private Vector3 _startPosition;

    void Start()
    {
        _startPosition = transform.position;
    }

    void Update()
    {
        transform.position = _startPosition + new Vector3(Mathf.Sin(Time.time) * movementx, Mathf.Sin(Time.time) * movementy, Mathf.Sin(Time.time) * movementz);
    }
}
