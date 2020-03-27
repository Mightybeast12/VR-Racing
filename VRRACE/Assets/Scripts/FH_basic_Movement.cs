using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FH_basic_Movement : MonoBehaviour {
    public float fl_MovementSpeed = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp("w")) 
		{
			transform.Translate (0, fl_MovementSpeed, 0);
		}
		if(Input.GetKeyUp("s")) 
		{
			transform.Translate (0, -fl_MovementSpeed, 0);
		}
	}
}
