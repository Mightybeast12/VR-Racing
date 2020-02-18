using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    public float EnemymoveSPD;
    public int CurrentLOC = 0;
  

    public int Target = 1;
    public GameObject[] Gettransform;

   

    // Start is called before the first frame update
    void Start()
    {
        Gettransform = GameObject.FindGameObjectsWithTag("Waypoint");
        if (Gettransform.Length == 0)
        {
            Debug.Log("Nowhere to go");

        }
       

    }

    // Update is called once per frame
    void Update()
    {
        
        float TIMELEFT = Vector3.Distance(Gettransform[Target].transform.position, transform.position);
        
        transform.position = Vector3.MoveTowards(transform.position, Gettransform[Target].transform.position, Time.deltaTime * EnemymoveSPD);

        if (TIMELEFT <=  0f)
        {
            Target++;
        }
        if (TIMELEFT >= Gettransform.Length)

        {
            Target = 0;
        }

    }
}
