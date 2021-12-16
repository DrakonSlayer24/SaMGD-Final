using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;


[RequireComponent(typeof(AudioSource))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float movespeed;
    private float dirX, dirZ, dirY;
    public float volume = 0.5f;
    public AudioClip BreakSound;
    AudioSource audio;
    int health = 20;
    public Text healthText;

    public Joystick joystick;

    public PhotonView view;

    // Start is called before the first frame update
    void Start()
    {
        movespeed = 3f;
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = joystick.Horizontal * movespeed;
        dirZ = joystick.Vertical * movespeed;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 10, ForceMode.VelocityChange);
        }
        healthText.text = health.ToString();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);
    }

}
