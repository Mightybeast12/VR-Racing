using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crosshair : MonoBehaviour
{
    public Transform Origin;
    public float range;
    public GameObject activate;
    public int scnumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit HIT;
        if (Physics.Raycast(Origin.position,transform.forward,out HIT,range))
        {
            if (HIT.collider.gameObject.tag ==("Objective"))
            {
                activate.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                   WhichScenetoload WL = HIT.transform.gameObject.GetComponent<WhichScenetoload>();
                    scnumber = WL.scenenuber;
                    Debug.Log(scnumber);
                    loadtt();
                                                         
                }
                    
            }
            else
            {
                activate.SetActive(false);
            }
            Debug.Log(HIT.transform.name);
        }
    }

    public void loadtt()
    {
        SceneManager.LoadScene(scnumber);
    }
}
