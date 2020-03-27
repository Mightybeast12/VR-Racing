using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FH_createobj : MonoBehaviour {
    public GameObject boxprefab;
    public bool unlspawn = true;
    public float timebetween;
    public float spawntimes = 1f;
    public float spawnlimit = 100f;
    public float startForce = 5;
    private float nextTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (nextTime < Time.time)
        {
            if (spawntimes <= spawnlimit || unlspawn == true)
            {
                GameObject newSphere = Instantiate(boxprefab, transform.position, transform.rotation);
                spawntimes++;
                nextTime = Time.time + timebetween;
                Rigidbody sphereRB = newSphere.GetComponent<Rigidbody>();
                sphereRB.velocity = gameObject.transform.forward * startForce;
                //Destroy
            }
        }
    }
}
