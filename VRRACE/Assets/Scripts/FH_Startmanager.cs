using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FH_Startmanager : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public void NextLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex < SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
