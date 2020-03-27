using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FH_Rifle : MonoBehaviour
{
    public float damage = 20f;
    public float range = 100f;
    public float health = 100f;
    public Camera fpsCam;
   // public GameObject[] destroyable;
   // string objtags;
    


    // Use this for initialization
    void Start()
    {
       
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }

    }
    void Fire()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
           
            if (hit.collider.gameObject.tag == "Destroy")
            {
                health = health - damage;
                if (health <= 0f)
                {

                    Destroy(hit.collider.gameObject);
                    health = 100f;
                }
              /*  if (hit.collider.gameObject.tag == "destroyable")
                {
                    health = health - damage;
                    if (health <= 0f)
                    {

                        Destroy(hit.collider.gameObject );
                        health = 100f;
                    }
                }*/
            }
        }



    }
}
