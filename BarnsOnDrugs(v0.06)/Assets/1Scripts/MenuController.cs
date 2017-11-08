using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        SceneManager.LoadScene("MainLevel");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void loadScene()
    {
        SceneManager.LoadScene("MainLevel");	
    }
    void loadScene2()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    void exitGame()
    {
        //Application.Quit;
    }

}
