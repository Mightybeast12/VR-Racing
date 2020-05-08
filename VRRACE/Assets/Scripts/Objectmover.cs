using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectmover : MonoBehaviour {

	public float maxy;
	private bool swt;
	public float howlong;
	private float og;
	 void Start()
	{
		og += howlong;
	}


	void Update () 
	{
		if (howlong <= 0f)
		{
			swt = !swt;
			howlong += og;
		}
		transform.Rotate(0, 30 * Time.deltaTime, 0);
		
		if (swt)
		{
		
			transform.localScale += new Vector3(0f, 1f * Time.deltaTime , 0f);
		}
		if (!swt)
		{
		transform.localScale -= new Vector3(0f, 1f * Time.deltaTime ,0f) ;
		}
		howlong -= Time.deltaTime;

	}
}
