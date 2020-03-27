using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FH_Jumpactivater : MonoBehaviour {
    public GameObject firstplatform;
    public GameObject secondplatform;
    private bool toggleboolb = true;
    private bool toggleboola = false;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() 
    {
        if (Input.GetKeyUp("q"))
        {
            toggleboola = !toggleboola;
            firstplatform.SetActive(toggleboola);
        }

        if (Input.GetKeyUp("q"))
        {
            toggleboolb = !toggleboolb;
            secondplatform.SetActive(toggleboolb);

        }
    }
}
