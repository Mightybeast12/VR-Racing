using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FH_ifobjactivedestroy : MonoBehaviour {
    public GameObject ifactive;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (ifactive.activeSelf == true )
        {
            Destroy(gameObject);

        }
	}
}
