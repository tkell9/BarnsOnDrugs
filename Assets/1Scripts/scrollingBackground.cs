using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollingBackground : MonoBehaviour {

    //How fast the background scrolls past, can be changed in editor.
    public float scrollSpeed = 0.5f;

    //public Renderer rend;

	// Use this for initialization
	void Start ()
    {
       // rend = GetComponent<Renderer>();
        //rend.enabled = true;
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        Vector2 offset = new Vector2(Time.time * scrollSpeed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;

        //rend.material.mainTextureOffset = offset;

    }
}
