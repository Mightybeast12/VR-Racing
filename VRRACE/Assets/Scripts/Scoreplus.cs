using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreplus : MonoBehaviour
{
    public ScoreManager SM;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "scoreplus")

        {
            SM.points++;
        }
    }
}
