using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTeleport : MonoBehaviour {

    public GameObject newBall;

    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject == GameObject.FindGameObjectWithTag("Ball"))
        {

            RollBall.ballOnTheWay = false;
            PinCollisionLogic.pinDown = false;

            obj.gameObject.transform.position = new Vector3(0.2099991f, -1.360001f, -0.12f);
            obj.gameObject.transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 1.0f);
            obj.GetComponent<Rigidbody>().velocity = Vector3.zero;
            obj.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
        
    }
}
