using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FH_playerHealth : MonoBehaviour {
    public float playerhealth = 100f;
    public Slider healthbar;
    public float damage = 50f;
    public float health = 50f;
    public float spawnhp;

    public float currenthealth;
	// Use this for initialization
	void Start () {

        currenthealth = playerhealth;
       spawnhp = playerhealth;
    }
	
	// Update is called once per frame
	void Update () {
        healthbar.value = currenthealth;
    }
    public void takedamage()
    {
        print("Yes - I am hit!");
        currenthealth = currenthealth - damage;
        


    }
    public void givehealth()
    {
        print("Yes health");
        currenthealth = currenthealth + health;



    }

    public void FixedUpdate()
    {
        if (currenthealth <= 0f)
        {
            Application.LoadLevel(0);

            currenthealth = spawnhp;

        }
    }
}
