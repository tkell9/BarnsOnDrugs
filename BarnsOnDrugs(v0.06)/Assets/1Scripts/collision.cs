using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour {

    public GameObject player;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "duck")
        {
            Debug.Log("GameOver_Duck");
            GameOver();
        }
        if (col.gameObject.tag == "bad")
        {
            Debug.Log("GameOver_barn");
            GameOver();
        }
        if (col.gameObject.tag == "windmill")
        {
            Debug.Log("GameOver_windmill");
            GameOver();
        }
        if (col.gameObject.tag == "Safe")
        {
            
        }

    }


    void GameOver()
    {
        
        Destroy(GameObject.FindWithTag("Player"));
        Time.timeScale = 0;
        
    }
}
