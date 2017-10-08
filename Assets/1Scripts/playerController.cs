using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    //private Vector3 startPos;
    //private Transform thisTransform;
    //private MeshRenderer mr;

    private bool scored;
    private int randomNum1;
    private int randomNum2;
    private int randomNum3;
    private string[] GamePadControls = {"Abutton", "BButton", "XButton", "YButton", "LBumper", "RBumper", "LTrigger", "RTrigger", "DpadUp", "DpadDown", "DpadLeft", "DpadRight", "BackButton", "StartButton", "LJoystickVertical", "LJoystickHorizontal", "RJoystickVertical", "RJoystickHorizontal", "LJoystickButton", "RJoystickButton", };
    private string[] chosenControls = { };

    //Keycodes for the three controls so they can be changed in a function below
    public float speed = 5f;
    public string kcUp; // = KeyCode.UpArrow;
    public string kcDown; //= KeyCode.DownArrow;
    public string kcShoot; //= KeyCode.Space;

    

    //this is for setting the keybode later.
    //kcFordward = KeyCode.W;

    // Use this for initialization
    void Start ()
    {
        //String array for every gamepad input. Will return a random item from array to set as keycode.
        //GamePadControls =

        changeControls();
        
    }

    private void Update()
    {
        if (Input.GetButton(kcUp) == true)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }

        if (Input.GetAxis(kcUp) > 0)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }

        if (Input.GetButton(kcDown) == true)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        if (Input.GetAxis(kcDown) > 0)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        if (Input.GetButton(kcShoot) == true)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        if (Input.GetAxis(kcShoot) > 0)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }

    }

    /*private void randomizeControls()
    {
        //kcUp = KeyCode.JoystickButton0;
        int randomNum1 = Random.Range(0, 22);
        int randomNum2 = Random.Range(0, 22);
        int randomNum3 = Random.Range(0, 22); 
    } */

    private void changeControls()
    {
        {
            if (this)
            {
                kcUp = GetRandomStringItem();
                kcDown = GetRandomStringItem();
                kcShoot = GetRandomStringItem();
            }
        }
    }

    public string GetRandomStringItem()
    {
        return GamePadControls[Random.Range(0, GamePadControls.Length)];
    }
}
