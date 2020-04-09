using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaitTextLogic : MonoBehaviour {


    public Text waitText;

    public Text credits;

    public bool cButtonPressed;

    private void Start()
    {
        //credits = GameObject.FindGameObjectWithTag("credits").GetComponent<tex>;
        cButtonPressed = false;
    }

    public void displayMessage()
    {
        if (PinCollisionLogic.waitSignTime > 0)
        {
                waitText.text = "Please wait...";
                StrikeSpareLogic.congratsSignTime = 3;
        }
        else if( PinCollisionLogic.waitSignTime <= 0.0f)
        {
            waitText.text = "";

        }
    }

    public void displayRollingCredits()
    {
        if ((cButtonPressed == true))
        {
            credits.text = "developed by\nPetros portokalakis\nFor the Graphics course\n\nTechnical university of crete, june 2017";
        }
        else
        {
            credits.text = " ";
        }
    }

	// Update is called once per frame
	void Update () {

        displayRollingCredits();

        if (Input.GetKey("c"))
        {
            Debug.Log("C Pressed!");
            if (cButtonPressed == false)
            {
                cButtonPressed = true;
            }
            else
                cButtonPressed = false;
        }

        PinCollisionLogic.waitSignTime -= Time.deltaTime;
        displayMessage();
        //Debug.Log(PinCollisionLogic.waitSignTime);
        //Debug.Log("Flag: " + RollBall.testTryFlag);
        //Debug.Log("Player 1 score: " + ScoreLogic.playerOneScore);  
    }
}
