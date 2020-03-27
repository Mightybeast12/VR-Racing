using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_detector : MonoBehaviour
{
    public float force = 20;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
  void OnCollisionEnter(Collision collision)
  {

       //print("hit " + collision.gameObject.name);

       


        if (collision.gameObject.tag == "Player")
        {
            GetComponent<Renderer>().material.color = Color.red;
            print("hit2 " + collision.gameObject.name);
            Vector3 dir = collision.contacts[0].point - transform.position;

             //We then get the opposite (-Vector3) and normalize it
            dir = -dir.normalized;
             //And finally we add force in the direction of dir and multiply it by force. 
            //This will push back the player
           GetComponent<Rigidbody>().AddForce(dir * force);
            //GetComponent<Renderer>().material.color = Color.red;
        }

       
   }

}
