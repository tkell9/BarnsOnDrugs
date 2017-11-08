using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windmill : MonoBehaviour {
    public float windmillScrollSpeed = 3.5f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.left * Time.deltaTime * windmillScrollSpeed);
    }
}
