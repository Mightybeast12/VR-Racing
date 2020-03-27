using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fh_levelmanager : MonoBehaviour {
    public Transform lastgoodchepoint;
    public Canvas infobar;
    public Canvas messageBox;

    public Text messagetextonscreen;
    public Text statusText;
    public float timeonscreen = 2.5f;

    private float timeComplete = 0f;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (timeComplete < Time.time)
        {
            messageBox.gameObject.SetActive(false);
        }
		
	}

    public void Showmessage(string Currentmessage)
    {
        messagetextonscreen.text = Currentmessage;
        messageBox.gameObject.SetActive(true);
        timeComplete = Time.time + timeonscreen;
    }
}
