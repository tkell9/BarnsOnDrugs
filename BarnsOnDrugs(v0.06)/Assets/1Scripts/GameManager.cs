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
    public GameObject barnPrefab;
    public GameObject windmillPrefab;

    public GameObject leftKey;
    public GameObject midKey;
    public GameObject rightKey;


    public Transform UpKeyLocation;
    public Transform DownKeyLocation;
    public Transform ShootKeyLocation;
    private float interpolatingPeriod = 5.0f;

    private float time2;

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
            barnSpawner();
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

    void barnSpawner()
    {
        if (randomNumBarn == 1)
        {
            Instantiate<GameObject>(barnPrefab, new Vector3(19.44f, -1.218f, 4.5f), Quaternion.identity);
        }

        if (randomNumBarn == 2)
        {
            Instantiate<GameObject>(windmillPrefab, new Vector3(16.35f, -1.67f, 4.5f), Quaternion.identity);
        }

        if (randomNumBarn == 3)
        {
            Instantiate<GameObject>(barnPrefab, new Vector3(19.44f, -1.218f, 4.5f), Quaternion.identity);

        }
    }

    void rngesus()
    {
        randomNumDuck = Random.Range(1, 4);
        randomNumBarn = Random.Range(1, 4);
    }
}