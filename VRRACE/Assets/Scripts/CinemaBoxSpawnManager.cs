using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinemaBoxSpawnManager : MonoBehaviour
{
    public Transform[] spawnablelocations;
    public GameObject whattospawn;
  
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
     
        if (Input.GetKeyDown("k"))
        {
            int rng = Random.Range(0, spawnablelocations.Length);
            Debug.Log(rng);
           GameObject gg = Instantiate(whattospawn, spawnablelocations[rng]);
        }
    }
}
