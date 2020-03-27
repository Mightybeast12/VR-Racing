using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocketscript : MonoBehaviour {

    Rigidbody rigidbody;
    AudioSource audiosource;
    public float Rspeed;
    public float Jpower;
    float rotationspeed;
    float jetpower;
    // Use this for initialization
    void Start () {

              rigidbody = GetComponent<Rigidbody>();
        audiosource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        Thrusting();
        PlayerRotation();
        	
	}
    private void Thrusting()
    {
        jetpower = Rspeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddRelativeForce(Vector3.up * jetpower);
            if (!audiosource.isPlaying)
            {
                audiosource.Play();
            }
           
        }
        else
        {
            audiosource.Stop(); 
        }
    }
    public void PlayerRotation()
    {
     
        rigidbody.freezeRotation = true;

        rotationspeed = Rspeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotationspeed);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * rotationspeed );

        }
        
        rigidbody.freezeRotation = false;
        
    }

 
}
