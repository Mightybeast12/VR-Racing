using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FH_TriggerWithActivate : MonoBehaviour {
    public bool bl_activate = false;
    public GameObject objectactivate;
    private fh_levelmanager currentLevelManager;
	// Use this for initialization
	void Start () {
        GameObject go = GameObject.Find("LevelManager");
        currentLevelManager = go.GetComponent<fh_levelmanager>();
			}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey("e"))
        {
            bl_activate = true;
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag ==  "Player")
        {
            currentLevelManager.Showmessage("Press E to Activate!");
            objectactivate.SetActive(bl_activate);
        }
    }
}
