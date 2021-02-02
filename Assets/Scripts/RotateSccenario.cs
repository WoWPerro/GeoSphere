using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSccenario : MonoBehaviour
{
    public int speedz = 20;
    public int speedx = 0;
    public int speedy = 0;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(speedx, speedy, speedz) * Time.deltaTime);
    }
}
