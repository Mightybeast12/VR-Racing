using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FH_Enemy_Resseter : MonoBehaviour {
    public Transform checkpoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.transform.position = checkpoint.position;
        }
    }
}
