using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform player;
    public int PosizioneZ;
    public float Smooth = 0.1f;
    public Vector3 Offset;
    public float speedFollow = 0.5f;
    void FixedUpdate()
    {
        //Made the Camera follow smoother 

        Vector3 Position = player.position + Offset;
        Vector3 SmoothedPosition = Vector3.Lerp(transform.position, Position, Smooth);
        var PosCamera = new Vector3(SmoothedPosition.x, SmoothedPosition.y, PosizioneZ);
        transform.position = PosCamera; 
    }
}




