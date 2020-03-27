using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FH_objmove : MonoBehaviour {

    public GameObject walle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("a"))
        {
            walle.transform.Rotate(Vector3.left);
        }
	}
}
