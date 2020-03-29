using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FH_TiggerandCollideactivate : MonoBehaviour {
    public GameObject activeobj;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            activeobj.SetActive(true);
        }
    }
    public void OnCollisionEnter(Collision collided)
    {
        if (collided.collider.gameObject.tag == "Player")
        {
            GetComponent<Renderer>().material.color = Color.green;
            activeobj.SetActive(true);
         
        }
    }

}
