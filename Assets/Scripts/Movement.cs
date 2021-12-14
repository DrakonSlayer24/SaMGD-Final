using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public float movespeed;
    private float dirX, dirY;
    public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        movespeed = 3f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = joystick.Horizontal * movespeed;
        dirY = joystick.Vertical * movespeed;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirY);
    }
}
