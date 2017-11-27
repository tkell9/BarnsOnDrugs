using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {


    public Button playButton;
    public Button optButton;
    public Button exitButton;


    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
   
	}

    

    void LoadMainLevel(string name)
    {
        SceneManager.LoadScene("MainLevel"); 
    }

    void LoadCreditsLevel(string name)
    {
        SceneManager.LoadScene("CreditsLevel");
    }

    void LoadHighscoreLevel(string name)
    {
        SceneManager.LoadScene("HighscoreLevel");
    }

    void ExitApplication()
    {
       
    }





}
