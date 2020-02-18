using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchOBJ : MonoBehaviour
{

    public GameObject PetrolpiecePreFAB;
    public Transform EngineBlockSPWN;
    public Transform[] TransformTargetList;
    private Transform Target;
     private int NT;

    public float Speed;
    public float spawnspeed;
    private float ogspawnspeed;
    // Start is called before the first frame update
    void Start()
    {
        FindTargets();
        ogspawnspeed = spawnspeed;
    }

    // Update is called once per frame
    void Update()
    {
        spawnspeed -= Time.deltaTime;
        if (spawnspeed <= 0)
        {
            GameObject NewP;
            NewP = Instantiate(PetrolpiecePreFAB, EngineBlockSPWN.position, EngineBlockSPWN.rotation);
            NewP.AddComponent<Rigidbody>().AddForce(Target.position -transform.position * Speed, ForceMode.Impulse);
            spawnspeed = ogspawnspeed;
            Nexttarget();
            
        }
    }

    void Nexttarget()
    {
        NT = Random.Range(0, TransformTargetList.Length);
        Debug.Log(NT);
        Target = TransformTargetList[NT];
    }

    void FindTargets()
    {
        GameObject[] FoundTargets;
          FoundTargets = GameObject.FindGameObjectsWithTag("PetrolTarget");
        foreach (GameObject i in FoundTargets)
        {
            Vector3 positions;
            positions = i.transform.position;


        }
        
        

    }

}
