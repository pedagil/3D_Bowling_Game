/* If for some reason, ball does not make it through the teleport zone,
 * there is a button designed to place the ball back to its
 * proper position for the game to be continued. */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetBallButton : MonoBehaviour {

    public Button ballResetButton;

    // Use this for initialization
    void Start () {
        Button btn = ballResetButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
	}


    // TaskOnClick() has the exact same functionality as the DestroyPins
    void TaskOnClick()
    {
        RollBall.ballOnTheWay = false;
        PinCollisionLogic.pinDown = false;

        //Debug.Log("Button Clicked!");

        GameObject.FindGameObjectWithTag("Ball").transform.position = new Vector3(0.2099991f, -1.360001f, -0.12f);
        GameObject.FindGameObjectWithTag("Ball").transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 1.0f);
        GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody>().velocity = Vector3.zero;
        GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}
