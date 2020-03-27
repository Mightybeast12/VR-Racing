using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stable_player_Camera : MonoBehaviour
{

    public GameObject player;
    public Vector3 offset;

    void Start()
    {
  
    }

    void LateUpdate()
    {
        float newXPosition = player.transform.position.x - offset.x;
        float newZPosition = player.transform.position.z - offset.z;
        float newYPosition = player.transform.position.y - offset.y;

        transform.position = new Vector3(newXPosition, newYPosition, newZPosition);
        
    }
}