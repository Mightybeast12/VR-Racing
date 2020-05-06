using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreTXT;
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        scoreTXT.text = "Score : " + points;
    }

    // Update is called once per frame
    void Update()
    {
        scoreTXT.text = "Score : " + points;
    }
}
