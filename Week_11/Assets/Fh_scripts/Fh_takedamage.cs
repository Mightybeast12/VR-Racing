using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fh_takedamage : MonoBehaviour {

    public FH_playerHealth playerhealth;

    // Use this for initialization
    void Start () {
		//playerhealth 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            attack();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            attack();
        }
    }

    public void attack()
    {
        playerhealth.takedamage();
    }
}
