using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FH_Color : MonoBehaviour
{

    public Material startMaterial;
    public Material endMaterial;
    public bool hasChanged = false;
    public GameObject[] objcolors;

    private Renderer _Renderer;

	// Use this for initialization
	void Start ()
    {
        _Renderer = gameObject.GetComponent<Renderer>();
        _Renderer.material = startMaterial;
	}
    private void OnTriggerEnter(Collider other)
    {
        foreach (GameObject startcolor in objcolors)
        {
            _Renderer = startcolor.GetComponent<Renderer>();
            _Renderer.material = startMaterial;
        }
        if (!hasChanged)
        {
            foreach (GameObject colorless in objcolors)
            {
                _Renderer = colorless.GetComponent<Renderer>();
                _Renderer.material = endMaterial;
                hasChanged = true;
            }
        }
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
