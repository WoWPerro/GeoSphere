using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float smoothSpeed = 0.125f;
    public Joystick joystick;
    public GameObject scene;
    public GameObject player;
    public Camera camera;
    private float angle;
    private float angle2;

    private void Start()
    {
        angle = scene.transform.rotation.x;
        angle = scene.transform.rotation.z;
    }

    // Update is called once per frame
    void Update()
    {
        //scene.transform.eulerAngles = new Vector3(0, Mathf.Atan2(joystick.Vertical, joystick.Horizontal) * 90 / Mathf.PI, 0);
        //float desiredRotation = Mathf.Atan2(cjoystick.Vertical, joystick.Horizontal);
        //float desiredRotation = camera.transform.rotation.x;
        //float smoothedRotationX = Lerp(scene.transform.rotation.x, joystick.Vertical, smoothSpeed);
        //scene.transform.rotation = Quaternion.Euler(0,0,0);
        //scene.transform.RotateAroundLocal(camera.transform.right, joystick.Vertical/50);
        //scene.transform.rotation *= Quaternion.Euler(joystick.Vertical/100, joystick.Horizontal/100, 0);
        
        scene.transform.RotateAround(player.transform.position, camera.transform.right, joystick.Vertical / 2);
        scene.transform.RotateAround(player.transform.position, camera.transform.forward, -joystick.Horizontal / 2);
        if(Input.touchCount == 0)
        {
            scene.transform.RotateAround(player.transform.position, camera.transform.right, angle + scene.transform.rotation.x);
            scene.transform.RotateAround(player.transform.position, camera.transform.forward, angle + scene.transform.rotation.z);
        }
    }
}
