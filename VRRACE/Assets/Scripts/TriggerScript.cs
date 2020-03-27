using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public Material rightcolour;
    public Material wrongcolour;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider other)
    {
        if (Input.GetKey("e"))
        {
            if (other.gameObject.tag == ("Righttrigger"))
            {
                other.gameObject.GetComponent<MeshRenderer>().material = rightcolour;
            }
            if (other.gameObject.tag != ("Righttrigger"))
            {
                other.gameObject.GetComponent<MeshRenderer>().material = wrongcolour;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey("e"))
        {
            if (other.gameObject.tag == ("Righttrigger"))
            {
                other.gameObject.GetComponent<MeshRenderer>().material = rightcolour;
            }
            if (other.gameObject.tag != ("Righttrigger"))
            {
                other.gameObject.GetComponent<MeshRenderer>().material = wrongcolour;
            }
        }
    }
}
