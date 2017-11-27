using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{

    public GameObject leftKey;
    public GameObject midKey;
    public GameObject rightKey;


    bool hasKeyReset;

    private void Awake()
    {

    }

    void Start()
    {
        hasKeyReset = true;
    }

    void keyReset()
    {
        if (hasKeyReset == true)
        {
            //Resets the positions to 0
            leftKey.transform.position = new Vector3(0, 0, 0);
            midKey.transform.position = new Vector3(0, 0, 0);
            rightKey.transform.position = new Vector3(0, 0, 0);
            hasKeyReset = false;
        }


    }
}