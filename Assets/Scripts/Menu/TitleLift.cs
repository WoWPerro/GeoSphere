using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleLift : MonoBehaviour
{
    public float speed;
    private Vector3 _startPosition;
    // Start is called before the first frame update

    void Start()
    {
        _startPosition = transform.position;
    }

    void Update()
    {
        transform.position = _startPosition + new Vector3(0.0f, Mathf.Sin(Time.time) * speed, 0.0f);
    }
}
