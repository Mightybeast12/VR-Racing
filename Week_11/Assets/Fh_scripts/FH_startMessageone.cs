using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FH_startMessageone : MonoBehaviour {

    public GameObject Hud;
    public float timeon = 15f;
    public float timecompleter = 3f;
   
    private fh_levelmanager currentLevelManager;
    // Use this for initialization
    void Start()
    {
        GameObject go = GameObject.Find("LevelManager");
        currentLevelManager = go.GetComponent<fh_levelmanager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
  
            currentLevelManager.Showmessage("Pressing Q  enables special interactions");
            print("Go");
            //Hud.gameObject.SetActive(true);
            //timecompleter = Time.time + timeon;

        }
    }
}
