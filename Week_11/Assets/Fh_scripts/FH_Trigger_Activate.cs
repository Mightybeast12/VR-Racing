using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FH_Trigger_Activate : MonoBehaviour {
    public GameObject[] activates;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key" || other.gameObject.tag == "Player")
        {
            foreach (GameObject active in activates)
            {
                active.SetActive(true);
            }
        }
    }
}
