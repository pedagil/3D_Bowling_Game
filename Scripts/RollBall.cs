using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollBall : MonoBehaviour {
    public float ballSpeed = 1000f;
    public float moveSpeed = 5f;
    public ScoreLogic scoreLogic;
    public static int ballCount;
    public static int testTryFlag;

    public UnityEngine.Transform vec;
    public static bool ballOnTheWay;
    public bool goRight;
    public static AudioSource ballSound;
    public static float leftRightSpeed;

    GameObject GameObj;
    PinPositionReset PPRObj;

    void Start()
    {
        testTryFlag = 1;
        ballCount = 0;
        leftRightSpeed = -1.5f;
        goRight = false;

        ballSound = GetComponent<AudioSource>();

        GameObj = GameObject.Find("mainBowlingLane");
        PPRObj = (PinPositionReset)GameObj.GetComponent(typeof(PinPositionReset));

        vec = GameObject.FindGameObjectWithTag("Ball").transform;
        ballOnTheWay = false;
        //First player, first try.
        //playerTry = 1;
    }

    void OnMouseDown()
    {

        ballSound.Play();
        //PinCollisionLogic.pinsDown.Play();
        ballOnTheWay = true;
        if (ballCount % 2 != 0)
        {
            ScoreLogic.sparePinCount = 0;
        }

        ballCount++;
        GetComponent<Rigidbody>().AddForce(ballSpeed * transform.forward);
        if (RollBall.ballCount % 2 == 0)
        {
            if (ScoreLogic.playerActive == 1)
            {
                
                ScoreLogic.playerActive = 2;
                PPRObj.playerChangePinPosition();
            }
            else if (ScoreLogic.playerActive == 2)
            {
                ScoreLogic.playerActive = 1;
                PPRObj.playerChangePinPosition();
            }
        }
        else
        {
            ScoreLogic.strikePinCount = 0;
        }
        
        
    }

    void Update()
    {
        //Debug.Log(vec.position.x);

        if (ballOnTheWay == false)
        {
            vec.transform.Translate(leftRightSpeed * Time.deltaTime, 0, 0);
        }
        Vector3 move = Vector3.zero;
        move.x = Input.GetAxis("Horizontal");

        transform.position += move * moveSpeed * Time.deltaTime;

    }
}
