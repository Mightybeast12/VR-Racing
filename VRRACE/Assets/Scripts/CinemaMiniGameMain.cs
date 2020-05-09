using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinemaMiniGameMain : MonoBehaviour
{
    public Vector3 offset;
    public GameObject pointer;
    public ScoreMng SM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit HIT;
        Ray rayspawn = Camera.main.ScreenPointToRay(Input.mousePosition);
        
       
           if (Physics.Raycast(rayspawn, out HIT))
        {
            if (HIT.collider.gameObject.tag == ("enemy"))
                {
               

                if (Input.GetMouseButtonDown(0))
                {
                    HIT.collider.transform.gameObject.SetActive(false);
                    SM.AddScore(1,1);
                    Debug.Log(HIT);
                }
            }
                
               
                Debug.Log(HIT);
            }
            
            pointer.transform.position = HIT.point + offset;
        }
      
        
    }

