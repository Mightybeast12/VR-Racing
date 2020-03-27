using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FH_gethp : MonoBehaviour {

    public FH_playerHealth playerhealth;

    // Use this for initialization
    void Start()
    {
        //playerhealth 
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            health();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && playerhealth.currenthealth <= 50f)
        {
            health();
            DestroyObjectDelayed();
        }
    }
        
    public void health()
    {
        playerhealth.givehealth();

        
    }

    void DestroyObjectDelayed()
    {
        // Kills the game object in 5 seconds after loading the object
        Destroy(gameObject, 0.05f);
    }



}

