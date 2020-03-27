﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FH_Physics_Move : MonoBehaviour {
    private Rigidbody rb_Physics_RigidBody;
    public float fl_push_force = 5;
	// Use this for initialization
	void Start ()

    {
        rb_Physics_RigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
{
        Vector3 _temporary_force = Vector3.zero;
        _temporary_force.x = Input.GetAxis("Horizontal") * fl_push_force;
        _temporary_force.z = Input.GetAxis("Vertical") * fl_push_force;
        _temporary_force.y = Input.GetAxis("Vertical") * fl_push_force;



        rb_Physics_RigidBody.AddForce(_temporary_force);

    }
}
