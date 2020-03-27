using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FH_Scene_Resetter : MonoBehaviour
{
    public int spawntimes = 0;
    public int spawnlimit = 3000;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        if (spawntimes >= spawnlimit)
        {
        Application.LoadLevel(0);
        }
    }
    
    
       
    
}

