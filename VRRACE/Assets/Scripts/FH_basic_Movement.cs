using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FH_basic_Movement : MonoBehaviour {
    public float fl_MovementSpeed = 3;

	public GameObject OBJTOShoot;
	public float shootspeed;
	public Transform SPWNPoint;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp("a")) 
		{
			transform.Translate (-fl_MovementSpeed, 0, 0);
		}
		if(Input.GetKeyUp("d")) 
		{
			transform.Translate (fl_MovementSpeed, 0, 0);
		}

		if (Input.GetKeyUp(KeyCode.Space))
		{
			ShoottheShot();
		}
	}

	void ShoottheShot()
	{
		GameObject SPWNEDBullet; 
		SPWNEDBullet = Instantiate(OBJTOShoot, SPWNPoint);
		SPWNEDBullet.AddComponent<Rigidbody>().AddForce(Vector3.forward * shootspeed);


	
	}
}
