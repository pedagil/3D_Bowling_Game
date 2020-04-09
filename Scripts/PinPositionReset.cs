using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinPositionReset : MonoBehaviour
{
    public GameObject pin1;
    public GameObject pin2;
    public GameObject pin3;
    public GameObject pin4;
    public GameObject pin5;
    public GameObject pin6;
    public GameObject pin7;
    public GameObject pin8;
    public GameObject pin9;
    public GameObject pin10;

    public RollBall rollBallClass;
    public GameObject ball;

    private void Awake()
    {
        setPinsAndBallOnPosition();
    }

    public void playerChangePinPosition()
    {
        Destroy(GameObject.FindGameObjectWithTag("Pin_1"));
        Destroy(GameObject.FindGameObjectWithTag("Pin_2"));
        Destroy(GameObject.FindGameObjectWithTag("Pin_3"));
        Destroy(GameObject.FindGameObjectWithTag("Pin_4"));
        Destroy(GameObject.FindGameObjectWithTag("Pin_5"));
        Destroy(GameObject.FindGameObjectWithTag("Pin_6"));
        Destroy(GameObject.FindGameObjectWithTag("Pin_7"));
        Destroy(GameObject.FindGameObjectWithTag("Pin_8"));
        Destroy(GameObject.FindGameObjectWithTag("Pin_9"));
        Destroy(GameObject.FindGameObjectWithTag("Pin_10"));

        setPinsAndBallOnPosition();
    }

    private void Start()
    {

    }

    private void Update()
    {

    }
    public void setPinsAndBallOnPosition()
    {
        Instantiate(pin1, pin1.transform.position, pin1.transform.rotation);
        Instantiate(pin2, pin2.transform.position, pin2.transform.rotation);
        Instantiate(pin3, pin3.transform.position, pin3.transform.rotation);
        Instantiate(pin4, pin4.transform.position, pin4.transform.rotation);
        Instantiate(pin5, pin5.transform.position, pin5.transform.rotation);
        Instantiate(pin6, pin6.transform.position, pin6.transform.rotation);
        Instantiate(pin7, pin7.transform.position, pin7.transform.rotation);
        Instantiate(pin8, pin8.transform.position, pin8.transform.rotation);
        Instantiate(pin9, pin9.transform.position, pin9.transform.rotation);
        Instantiate(pin10, pin10.transform.position, pin10.transform.rotation);
    }
}




