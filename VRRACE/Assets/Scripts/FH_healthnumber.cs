using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FH_healthnumber : MonoBehaviour {

    public Slider healthbar;
    public Text thisIsTheTextObject;

    public float sliderhealth;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        sliderhealth = healthbar.value;
        thisIsTheTextObject.text = sliderhealth.ToString() + "/100";

    }
}
