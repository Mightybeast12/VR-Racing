using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_color : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
    }
	
	// Update is called once per frame
	void Update () { }


    void OnCollisionEnter(Collision collision)
    {

        //print(collision.gameObject.tag);

         if (collision.gameObject.tag == "Player")
        {
			print ("I'm hit");
			GetComponent<Renderer>().material.color = Color.blue;
        }


    }

}