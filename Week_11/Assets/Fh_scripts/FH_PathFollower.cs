using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FH_PathFollower : MonoBehaviour
{


    public Transform[] Path;
    public float speed = 10.0f;
    public float reachDestination = 1.0f;
    public int currentlocation = 0;

    void Start()
    {


    }
    void Update()
    {

        float distance = Vector3.Distance(Path[currentlocation].position, transform.position);
        transform.position = Vector3.MoveTowards(transform.position, Path[currentlocation].position, Time.deltaTime * speed);


        if (distance <= reachDestination)
        {
            currentlocation++;
        }
        if (currentlocation >= Path.Length)
        {
            currentlocation = 0;
        }


    }

    void OnDrawGizmos()
    {

        if (Path.Length > 0)

            for (int i = 0; i < Path.Length; i++)
            {
                if (Path[i] != null)
                {
                    Gizmos.DrawSphere(Path[i].position, reachDestination);
                }
            }
    }

}




