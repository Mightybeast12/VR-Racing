using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_camera : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float horizontal = 0.0f;
    private float verticle = 0.0f;
    public float cameraxlimitleft = 0f;
    public float cameraxlimitright = 0f;
    public float cameraylimitup = 0f;
    public float cameraylimitdown = 0f;
    public Camera PlayerCam;




    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        horizontal += speedH * Input.GetAxis("Mouse X");
        verticle -= speedV * Input.GetAxis("Mouse Y");

        print("H: " + horizontal);
        if (horizontal < cameraxlimitleft)
        {
            horizontal = cameraxlimitleft;
        }
        if (horizontal > cameraxlimitright)
        {
            horizontal = cameraxlimitright;
        }
        if (verticle > cameraylimitdown)
        {
            verticle = cameraylimitdown;
        }
        if (verticle < cameraylimitup)
        {
            verticle = cameraylimitup;
        }
        print("Y: " + verticle);

        transform.eulerAngles = new Vector3(verticle, horizontal, 1.0f);

        //transform.eulerAngles

    }
}