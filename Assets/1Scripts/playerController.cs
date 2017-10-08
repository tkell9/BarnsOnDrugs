using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    //private Vector3 startPos;
    //private Transform thisTransform;
    //private MeshRenderer mr;

    private bool scored;
    private string[] GamePadControls = {"AButton", "BButton", "XButton", "YButton", "LBumper", "RBumper", "LTrigger", "RTrigger", "DpadUp", "DpadDown", "DpadLeft", "DpadRight", "BackButton", "StartButton", "LJoystickVertical", "LJoystickHorizontal", "RJoystickVertical", "RJoystickHorizontal", "LJoystickButton", "RJoystickButton", };
    private string[] GamePadControlsCopy = { "AButton", "BButton", "XButton", "YButton", "LBumper", "RBumper", "LTrigger", "RTrigger", "DpadUp", "DpadDown", "DpadLeft", "DpadRight", "BackButton", "StartButton", "LJoystickVertical", "LJoystickHorizontal", "RJoystickVertical", "RJoystickHorizontal", "LJoystickButton", "RJoystickButton", };
    private string[] cuurentControls = { };

    //Keycodes for the three controls so they can be changed in a function below
    public float speed = 5f;
    public string kcUp; // = KeyCode.UpArrow;
    public string kcDown; //= KeyCode.DownArrow;
    public string kcShoot; //= KeyCode.Space;

    private int randomNum1;
    private int randomNum2;
    private int randomNum3;
        


    //this is for setting the keycode later.
    //kcFordward = KeyCode.W;

    
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

        if (Input.GetAxis(kcUp) > 0.1f)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            
        }

        if (Input.GetButton(kcDown) == true)
        {
            transform.position -= Vector3.up * speed * Time.deltaTime;
        }

        if (Input.GetAxis(kcDown) > 0.1f)
        {
            transform.position -= Vector3.up * speed * Time.deltaTime;
        }

        if (Input.GetButton(kcShoot) == true)
        {
            
        }

        if (Input.GetAxis(kcShoot) > 0)
        {
            
        }

    }

    private void randomizeNumbers()
    {
        int randomNum1 = Random.Range(0, 22);
        int randomNum2 = Random.Range(0, 22);
        int randomNum3 = Random.Range(0, 22); 
    } 


    /*public int[] GenerateUniqueRandom(int amount, int min, int max)
    {
        int[] arr = new int[amount];
        for (int index = 0; index < amount; index++)
        {
            bool done = false;
            while (!done)
            {
                int num = Random.Range(min, max);
                int jindex = 0;
                for (jindex = 0; jindex < index; jindex++)
                {
                    if (num == arr[jindex])
                    {
                        break;
                    }
                }
                if (jindex == index)
                {
                    arr[index] = num;
                    done = true;
                }
            }
        }
        return arr;
    } */

    private void changeControls()
    {
        {
            if (this)
            {
                //kcUp = GamePadControls[randomNum1];

                string NewUp = GamePadControls[randomNum1];
                GamePadControls[randomNum1].Remove(randomNum1);

                kcUp = NewUp;

                Debug.Log(NewUp);


                string NewDown = GamePadControls[randomNum1];
                GamePadControls[randomNum1].Remove(randomNum1);

                kcDown = NewDown;

                Debug.Log(NewDown);


                string NewShoot = GamePadControls[randomNum1];
                GamePadControls[randomNum1].Remove(randomNum1);

                kcShoot = NewShoot;

                Debug.Log(NewShoot);

                //kcUp = GetRandomStringItem();

                //kcDown = GetRandomStringItem();

                //kcShoot = GetRandomStringItem();

                
                

            }
        }
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
        else { kcUp = GetRandomStringItem(); }


        if (kcDown == kcShoot)
        {
            kcDown = GetRandomStringItem();
        }
        else { kcDown = GetRandomStringItem(); }


        if (kcShoot == kcUp)
        {
            kcShoot = GetRandomStringItem();
        }
        else { kcShoot = GetRandomStringItem(); }
    }


    public string GetRandomStringItem()
    {
        return GamePadControls[Random.Range(0, GamePadControls.Length)];
    }
}
