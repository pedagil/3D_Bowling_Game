using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinCollisionLogic : MonoBehaviour {

    public Transform pin;
    public int point = 1;
    public ScoreLogic scoreGameObject;
    public WaitTextLogic waitTextGameObject;
    public GameObject attachedPin;
    public static float waitSignTime;
    public static AudioSource pinsDown;
    public static bool pinDown;

    void Awake()
    {
        waitSignTime = 0.0f;
        scoreGameObject = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreLogic>();
        waitTextGameObject = GameObject.FindGameObjectWithTag("WaitText").GetComponent<WaitTextLogic>();
    }

    private void Start()
    {
        pinsDown = GetComponent<AudioSource>();
        pinDown = false;
    }
    void CheckItFell()
    {
        try
        {
            if (pin.up.y < 0.7f)
            {
                RollBall.ballSound.Stop();
                if (pinDown == false)
                {
                    pinsDown.Play();
                    pinDown = true;
                }
                scoreGameObject.Add(point);
                gameObject.GetComponent<Collider>().enabled = false;

                
                Destroy(attachedPin, 5);
                waitSignTime = 5;
                waitTextGameObject.displayMessage();

            }
        }
        catch
        {
            Debug.Log("Pin Went To Dead Zone!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        CheckItFell();
    }

}
