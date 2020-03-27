using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FH_Spawner : MonoBehaviour {

    public int int_numberOfTimes = 1;
    public bool bool_infinite = false;
    public float fl_timeBetween = 1f;
    public GameObject go_spawner;
    public Transform objspawnlocation;

    public float fl_Nexttime;
    private int int_countsofar = 0;

	// Use this for initialization
	void Start () {
        fl_Nexttime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (go_spawner != null)
        {
            if (bool_infinite || int_countsofar < int_numberOfTimes)
            {
                Instantiate(go_spawner, objspawnlocation.position, objspawnlocation.rotation);
                int_countsofar++;
                fl_Nexttime = Time.time + fl_timeBetween;
            }
        }
	}
}
