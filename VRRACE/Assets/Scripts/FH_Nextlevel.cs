using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FH_Nextlevel : MonoBehaviour {

    

    private void OnTriggerEnter(Collider firo)
    {
        if (firo.gameObject.tag == "Player")
        {
            print("go next");
            Application.LoadLevel(3);
        }

    }
}
