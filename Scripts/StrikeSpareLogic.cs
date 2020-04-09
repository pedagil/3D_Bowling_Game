using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StrikeSpareLogic : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
    }

    public Text congtatsText;
    public Text spareText;
    public static float congratsSignTime;

    public void displayMessage()
    {
        if ((ScoreLogic.strikePinCount == 10) && (congratsSignTime > 0))
        {
            congtatsText.text = "s t r i k e !!!";
            congtatsText.transform.Rotate(0*Time.deltaTime, 0* Time.deltaTime, 50 * Time.deltaTime);
        }
        else
        {
            congtatsText.text = "";
        }
    }

    public void displaySpareMessage()
    {
        if ((ScoreLogic.sparePinCount == 10) && (congratsSignTime > 0))
        {
            spareText.text = "s p a r e !!!";
            spareText.transform.Rotate(0 * Time.deltaTime, 0 * Time.deltaTime, 50 * Time.deltaTime);
        }
        else
        {
            spareText.text = "";
        }
    }

	// Update is called once per frame
	void Update () {

        congratsSignTime -= Time.deltaTime;
        //Debug.Log("Time: " + congratsSignTime);

        displaySpareMessage();
        displayMessage();

	}
}
