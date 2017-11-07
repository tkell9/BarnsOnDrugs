using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duck : MonoBehaviour {

    public float duckSpeed = 3.0f;

    private float deathTimer = 7.0f;
    private float time;

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.left * Time.deltaTime * duckSpeed);

        time += Time.deltaTime;
        if (time >= deathTimer)
        {
            DestroyObject(gameObject);
        }
    }
}
