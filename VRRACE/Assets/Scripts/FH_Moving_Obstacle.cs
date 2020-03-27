using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FH_Moving_Obstacle : MonoBehaviour {
    public List<GameObject> wayPoints;
    public int startingwaypoint = 0;
    public float movementspeed = 3f;
    public int currentwaypoint = 0;



	// Use this for initialization
	void Start () {
        currentwaypoint = startingwaypoint;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3  temporaryVector3 = Vector3.zero;

        temporaryVector3.x = wayPoints[currentwaypoint].transform.position.x;
        temporaryVector3.y = gameObject.transform.position.y;
        temporaryVector3.z = wayPoints[currentwaypoint].transform.position.z;

        transform.LookAt(temporaryVector3);
        transform.Translate((Vector3.forward * movementspeed * Time.deltaTime));

        if (Vector3.Distance(transform.position, temporaryVector3) < movementspeed / 4)
        {
            currentwaypoint++;
            if (currentwaypoint > wayPoints.Count -1)
            {
                currentwaypoint = startingwaypoint;
            }
        }

    }
}
