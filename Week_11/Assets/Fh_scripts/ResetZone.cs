﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetZone : MonoBehaviour
{

    public Transform respawn;
    public FH_Scene_Resetter reset;


    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider other)     
    {
        
        if (other.gameObject.tag == "Player")

        {
            other.gameObject.transform.position = respawn.position;
            reset.spawntimes++;
        }



    }
}

