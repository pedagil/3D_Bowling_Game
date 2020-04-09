using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject Ball;

    private Vector3 offset;

    private void Start()
    {
        GameObject.FindGameObjectWithTag("MainCamera").transform.position = new Vector3(-59.46f, 50.5f, 144.94f);

        //Ball = GameObject.FindGameObjectWithTag("Ball");

        //offset = transform.position - Ball.transform.position;
    }


    private void Update()
    {
        if (Input.GetKey("p"))
        {
            GameObject.FindGameObjectWithTag("MainCamera").transform.position = new Vector3(-58.29f, 33.82f, 174.95f);

            Ball = GameObject.FindGameObjectWithTag("Ball");

            Ball.transform.position = new Vector3(0.2099991f, -1.360001f, -0.12f);

            offset = transform.position - Ball.transform.position;
        }
    }


    /*According to Unity Scripting API: "For example a follow camera should 
    always be implemented in LateUpdate because it tracks objects that 
    might have moved inside Update"
    Reference: https://docs.unity3d.com/ScriptReference/MonoBehaviour.LateUpdate.html */


    private void LateUpdate()
    {
        //Debug.Log("Ball rotation: " + Ball.transform.rotation);
        try
        {
            if (GameObject.FindGameObjectWithTag("Ball") != null)
            {
                transform.position = Ball.transform.position + offset;
            }
        }
        catch(MissingComponentException mce)
        {
            //Instantiate(Ball, Ball.transform.position, Ball.transform.rotation);
        }
    }
}
