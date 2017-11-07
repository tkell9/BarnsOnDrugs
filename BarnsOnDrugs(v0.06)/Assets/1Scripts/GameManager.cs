using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    
    public Transform barn;
    public Transform windmill;
    public Transform duckTopSpawn;
    public Transform duckMidSpawn;
    public Transform duckBotSpawn;
    public GameObject duckPrefab;

    public Transform UpKeyLocation;
    public Transform DownKeyLocation;
    public Transform ShootKeyLocation;
    public float interpolatingPeriod = 1.0f;


    public float objectSpeed;

    //private Time time;
    private float time;
    private int randomDuckSpawning;
    private int randomNumDuck;
    private int randomNumBarn;



    private bool successfulBarnStorm = false;



    // Use this for initialization
    void Start ()
    {
        //Instantiate<GameObject>(duckPrefab, new Vector3(9.76f, 3.83f, 8.92f), Quaternion.identity);

    }
	
	// Update is called once per frame
	void Update ()
    {
        time += Time.deltaTime;
        if(time > interpolatingPeriod)
        {
            Debug.Log("Spawn ducks");
            rngesus();
            duckSpawner();
            time -= interpolatingPeriod;
        }

    }

    //If statement chooses either top, mid, or low based on the random numbers generated every X seconds.
    void duckSpawner()
    {
        if (randomNumDuck == 1)
        {
            Instantiate<GameObject>(duckPrefab, new Vector3(9.76f, 3.83f, 4.5f), Quaternion.identity);
        }

        if (randomNumDuck == 2)
        {
            Instantiate<GameObject>(duckPrefab, new Vector3(9.76f, 2.79f, 4.5f), Quaternion.identity);
        }

        if (randomNumDuck == 3)
        {
               Instantiate<GameObject>(duckPrefab, new Vector3(9.76f, 1.73f, 4.5f), Quaternion.identity);

        }                                
    }




    void rngesus()
    {
        randomNumDuck = Random.Range(1, 4);
        randomNumBarn = Random.Range(2, 3);
    }
}