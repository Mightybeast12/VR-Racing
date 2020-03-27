using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FH_destroyaftercertaintime : MonoBehaviour {
   public  float howlongalive = 3;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Destroy(gameObject, howlongalive);

    }
    

}
