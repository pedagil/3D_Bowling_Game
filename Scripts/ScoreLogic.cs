using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreLogic : MonoBehaviour {

    public RollBall rollBallClass;
    public GameObject ball;
    public static int playerOneScore = 0;
    public static int playerTwoScore = 0;
    public static int strikePinCount = 0;
    public static int sparePinCount = 0;
    //public int DBG_add;
    public Text text;
    public static int playerActive;

    // Use this for initialization
    void Start ()
    {
        //DBG_add = 0;

        playerActive = 1;

        playerOneScore = 0;
        playerTwoScore = 0;

        strikePinCount = 0;

        //ball = GameObject.Find("Ball");
        //rollBallClass = ball.GetComponent<RollBall>();
    }
	
    public void Add(int pinDown)
    {
        //DBG_add++;
        //Debug.Log("Function Add was called! Count:" + DBG_add);
        
        strikePinCount += pinDown;
        sparePinCount += pinDown;

        if (RollBall.ballCount == 2)
        {
            strikePinCount = 0;
            sparePinCount = 0;
        }

        if (playerActive == 1 && RollBall.ballCount>=3)
        {
            playerOneScore += pinDown;
        }
        else if (playerActive == 2 && RollBall.ballCount>=3)
        {
            playerTwoScore += pinDown;
        }
        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        text.text = "Player 1 Score " + playerOneScore + "\nPlayer 2 Score " + playerTwoScore;
    }

    private void Update()
    {
        Add(0);

        //Debug.Log("Strike count: " + strikePinCount);
        //Debug.Log("Spare count: " + sparePinCount);

        //Debug.Log("Ball Count: " + RollBall.ballCount);
        //Debug.Log("Ball Count: " + rollBallClass.ballCount);
    }
}
