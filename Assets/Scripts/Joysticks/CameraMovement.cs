using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMovement : MonoBehaviour
{
    public Transform target; //player
    public float distance;
    public Joystick Camjoystick;
    private float CamSpeed = 10;
    private float dirX, dirZ, dirY;
    private Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        dirX = Camjoystick.Horizontal * CamSpeed;
        dirZ = Camjoystick.Vertical * CamSpeed;
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(dirX, 10, dirZ);
    }
}
