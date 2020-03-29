using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocketscript : MonoBehaviour {

    Rigidbody RB3D;
    AudioSource rocketsound;
    public float RotationSPD;
    public float Thrust;
    float rotationspeed;
    float jetpower;

    void Start () {

              RB3D = GetComponent<Rigidbody>();
        rocketsound = GetComponent<AudioSource>();
    }
	void Update () {
        Thrusting();
        PlayerRotation();
     	
	}
    private void Thrusting()
    {
        jetpower = RotationSPD * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            RB3D.AddRelativeForce(Vector3.up * jetpower);
            if (!rocketsound.isPlaying)
            {
                rocketsound.Play();
            }
            }
        else
        {
            rocketsound.Stop(); 
        }
    }
    public void PlayerRotation()
    {
     
        RB3D.freezeRotation = true;

        rotationspeed = RotationSPD * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotationspeed);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * rotationspeed );

        }
        
        RB3D.freezeRotation = false;
        
    }

 
}
