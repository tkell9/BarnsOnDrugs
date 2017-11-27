using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour {


    public float timeLeft = 10f;
    public bool stop = true;

    public Collider2D playerCollider;
    public Collider2D barnCollider;

    public Text keyUp;
    public Text keyDown;
    public Text keyShoot;

    //private Vector3 startPos;
    //private Transform thisTransform;
    //private MeshRenderer mr;
    //private bool scored;

    private string[] GamePadControls = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "`", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "=", "tab", "[", "]", "", ";", "'", ",", ".", "/"};
    //private string[] GamePadControlsCopy = { "AButton", "BButton", "XButton", "YButton", "LBumper", "RBumper", "LTrigger", "RTrigger", "DpadUp", "DpadDown", "DpadLeft", "DpadRight", "BackButton", "StartButton", "LJoystickButton", "RJoystickButton", };
    //private string[] cuurentControls = { };
    public float minY, maxY;

    //private bool spriteReset;

    //Keycodes for the three controls so they can be changed in a function below
    private float speed = 5f;
    public string kcUp; // = KeyCode.UpArrow;
    public string kcDown; //= KeyCode.DownArrow;
    public string kcShoot; //= KeyCode.Space;

    public Transform key1;
    public Transform key2;
    public Transform key3;

    private string whatControlWasChosenLeft;
    private string whatControlWasChosenMid;
    private string whatControlWasChosenRight;

    public Vector2 playerPosition;

    public GameObject AButtonSprite;
    public GameObject BButtonSprite;
    public GameObject XButtonSprite;
    public GameObject YButtonSprite;
    public GameObject RTButtonSprite;
    public GameObject LTButtonSprite;
    public GameObject RBButtonSprite;
    public GameObject LBButtonSprite;
    public GameObject DPUButtonSprite;
    public GameObject DPRButtonSprite;
    public GameObject DPDButtonSprite;
    public GameObject DPLButtonSprite;
    public GameObject BackButtonSprite;
    public GameObject StartButtonSprite;
    public GameObject LJoystickButtonSprite;
    public GameObject RJoystickButtonSprite;

    private GameObject[] buttons = { };
    private GameObject gameOverPanel;

    //this is for setting the keycode later.
    //kcFordward = KeyCode.W;


    void Start()
    {
        //String array for every keyboard input. Will return a random item from array to set as keycode.
        //GamePadControls =

        kcUp = "w";
        kcDown = "s";
        kcShoot = "space";

        minY = -4.0f;
        maxY = 4.0f;

        chooseCorrectSprite();
        gameOverPanel = GameObject.Find("gameOverPanel");
        gameOverPanel = GameObject.FindGameObjectWithTag("gameOverPanel");
        //gameOverPanel.SetActive(false);
        //gameObject.renderer.enabled = false;
        gameOverPanel.gameObject.SetActive(false);
    }



    private void Update()
    {
        keyUp.text = kcUp;
        keyDown.text = kcDown;
        keyShoot.text = kcShoot;

        //spriteController();

        if (Input.GetKey(kcUp) == true)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }


        if (Input.GetKey(kcDown) == true)
        {
            transform.position -= Vector3.up * speed * Time.deltaTime;
        }


        if (Input.GetKey(kcShoot) == true)
        {
            
        }



        



        //Get players current position
        Vector3 playerPos = transform.position;
        playerPos.z = transform.position.z;

        //Constraints
        if (playerPos.y < minY) playerPos.y = minY;
        if (playerPos.y > maxY) playerPos.y = maxY;

        transform.position = playerPos;


        if (Input.GetKeyDown("space"))
        {   


            //Left over code when "Space" was used as the debug key
            //chooseCorrectSprite();
            //whatControlWasChosenLeft = kcUp;
            //whatControlWasChosenMid = kcDown;
            //whatControlWasChosenRight = kcShoot;
        }

    }


    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "duck")
        {
            GameOver();
        }
        if (col.gameObject.tag == "barn")
        {
            GameOver();
        }
        if (col.gameObject.tag == "windmill")
        {
            GameOver();
        }
        if (col.gameObject.tag == "Safe")
        {
            changeControls2();
        }

    }


    void GameOver()
    {
        Destroy(GameObject.FindWithTag("Player"));
        Time.timeScale = 0;
        gameOverPanel.gameObject.SetActive(true);
    }




    void changeControls2()
    {
        kcUp = GetRandomStringItem();

        kcDown = GetRandomStringItem();

        kcShoot = GetRandomStringItem();

        if (kcUp == kcDown)
        {
            kcUp = GetRandomStringItem();
        }
        else
        {
            kcUp = GetRandomStringItem();
        }

        if (kcDown == kcShoot)
        {
            kcDown = GetRandomStringItem();
        }
        else
        {
            kcDown = GetRandomStringItem();
        }

        if (kcShoot == kcUp)
        {
            kcShoot = GetRandomStringItem();
        }
        else
        {
            kcShoot = GetRandomStringItem();
        }
    }



    public string GetRandomStringItem()
    {
        return GamePadControls[Random.Range(0, GamePadControls.Length)];
    }


    //Bunch of if statements that will spawn the correct sprite prefab when the controls change.
    //Just dont look at this ever again.
    //Unused code but I will leave it as is so that I dont break anything.
    void chooseCorrectSprite()
    {
        GameObject[] buttons = GameObject.FindGameObjectsWithTag("button");
        for (int i = 0; i < buttons.Length; i++)
        {
            Destroy(buttons[i]);
        }

    }
    /*void spriteController()
    {
        //LEFT
        while (whatControlWasChosenLeft == "AButton")
            Instantiate(AButtonSprite, new Vector3(-2.96f, 3.42f, 4.6f), Quaternion.identity);



        while (whatControlWasChosenLeft == "BButton")
            Instantiate(BButtonSprite, new Vector3(-2.96f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenLeft == "XButton")
            Instantiate(XButtonSprite, new Vector3(-2.96f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenLeft == "YButton")
            Instantiate(YButtonSprite, new Vector3(-2.96f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenLeft == "RBumper")
            Instantiate(RBButtonSprite, new Vector3(-2.96f, 3.42f, 4.6f), Quaternion.identity);



        while (whatControlWasChosenLeft == "LBumper")
            Instantiate(LBButtonSprite, new Vector3(-2.96f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenLeft == "RTrigger")
            Instantiate(RTButtonSprite, new Vector3(-2.96f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenLeft == "LTrigger")
            Instantiate(LTButtonSprite, new Vector3(-2.96f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenLeft == "DpadUp")
            Instantiate(DPUButtonSprite, new Vector3(-2.96f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenLeft == "DpadLeft")
            Instantiate(DPLButtonSprite, new Vector3(-2.96f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenLeft == "DpadDown")
            Instantiate(DPDButtonSprite, new Vector3(-2.96f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenLeft == "DpadRight")
            Instantiate(DPRButtonSprite, new Vector3(-2.96f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenLeft == "BackButton")
            Instantiate(BackButtonSprite, new Vector3(-2.96f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenLeft == "StartButton")
            Instantiate(StartButtonSprite, new Vector3(-2.96f, 3.42f, 4.6f), Quaternion.identity);

        while (whatControlWasChosenLeft == "LJoystickButton")
            Instantiate(LJoystickButtonSprite, new Vector3(-2.96f, 3.42f, 4.6f), Quaternion.identity);

        while (whatControlWasChosenLeft == "RJoystickButton")
            Instantiate(RJoystickButtonSprite, new Vector3(-2.96f, 3.42f, 4.6f), Quaternion.identity);


        //MID
        while (whatControlWasChosenMid == "AButton")
            Instantiate(AButtonSprite, new Vector3(0f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenMid == "BButton")
            Instantiate(BButtonSprite, new Vector3(0f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenMid == "XButton")
            Instantiate(XButtonSprite, new Vector3(0f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenMid == "YButton")
            Instantiate(YButtonSprite, new Vector3(0f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenMid == "RBButton")
            Instantiate(RBButtonSprite, new Vector3(0f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenMid == "LButton")
            Instantiate(LBButtonSprite, new Vector3(0f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenMid == "RTButton")
            Instantiate(RTButtonSprite, new Vector3(0f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenMid == "LTButton")
            Instantiate(LTButtonSprite, new Vector3(0f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenMid == "DPUutton")
            Instantiate(DPUButtonSprite, new Vector3(0f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenMid == "DPLButton")
            Instantiate(DPLButtonSprite, new Vector3(0f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenMid == "DPDButton")
            Instantiate(DPDButtonSprite, new Vector3(0f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenMid == "DPRButton")
            Instantiate(DPRButtonSprite, new Vector3(0f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenMid == "BackButton")
            Instantiate(BackButtonSprite, new Vector3(0f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenMid == "StartButton")
            Instantiate(StartButtonSprite, new Vector3(0f, 3.42f, 4.6f), Quaternion.identity);

        while (whatControlWasChosenMid == "LJoystickButton")
            Instantiate(LJoystickButtonSprite, new Vector3(-0f, 3.42f, 4.6f), Quaternion.identity);

        while (whatControlWasChosenMid == "RJoystickButton")
            Instantiate(RJoystickButtonSprite, new Vector3(-0f, 3.42f, 4.6f), Quaternion.identity);



        //RIGHT
        while (whatControlWasChosenRight == "AButton")
            Instantiate(AButtonSprite, new Vector3(2.95f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenRight == "BButton")
            Instantiate(BButtonSprite, new Vector3(2.95f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenRight == "XButton")
            Instantiate(XButtonSprite, new Vector3(2.95f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenRight == "YButton")
            Instantiate(YButtonSprite, new Vector3(2.95f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenRight == "RBButton")
            Instantiate(RBButtonSprite, new Vector3(2.95f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenRight == "LButton")
            Instantiate(LBButtonSprite, new Vector3(2.95f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenRight == "RTButton")
            Instantiate(RTButtonSprite, new Vector3(2.95f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenRight == "LTButton")
            Instantiate(LTButtonSprite, new Vector3(2.95f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenRight == "DPUutton")
            Instantiate(DPUButtonSprite, new Vector3(2.95f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenRight == "DPLButton")
            Instantiate(DPLButtonSprite, new Vector3(2.95f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenRight == "DPDButton")
            Instantiate(DPDButtonSprite, new Vector3(2.95f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenRight == "DPRButton")
            Instantiate(DPRButtonSprite, new Vector3(2.95f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenRight == "BackButton")
            Instantiate(BackButtonSprite, new Vector3(2.95f, 3.42f, 4.6f), Quaternion.identity);


        while (whatControlWasChosenRight == "StartButton")
            Instantiate(StartButtonSprite, new Vector3(2.95f, 3.42f, 4.6f), Quaternion.identity);

        while (whatControlWasChosenRight == "LJoystickButton")
            Instantiate(LJoystickButtonSprite, new Vector3(2.96f, 3.42f, 4.6f), Quaternion.identity);

        while (whatControlWasChosenRight == "RJoystickButton")
            Instantiate(RJoystickButtonSprite, new Vector3(2.96f, 3.42f, 4.6f), Quaternion.identity);
    */
}


