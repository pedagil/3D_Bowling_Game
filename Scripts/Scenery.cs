using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenery : MonoBehaviour {

    public float patrolChangeDirection;
    public bool executeOnce;

    public GameObject[] fleet;
    public GameObject[] droidFleet;
    public GameObject[] parkedFleet;


    // Use this for initialization
    void Start () {
        patrolChangeDirection = 20;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 v = new Vector3(-61.522f, 37.94f, 209.773f);
        v.y += 0.5f * 0.8f*Mathf.Sin(Time.time * 0.5f + (float)(3.14/2));
        GameObject.FindGameObjectWithTag("spaceship").transform.position = v;


        Vector3 v1 = new Vector3(-66.45f, 36.44f, 208.4f);
        v1.y += 0.5f * 0.8f*Mathf.Sin(Time.time * 0.5f);
        GameObject.FindGameObjectWithTag("spaceship_1").transform.position = v1;

        Vector3 v3 = new Vector3(0.1666305f, 53.8f, 299.1941f);
        v3.y += 0.5f * 1.8f * Mathf.Sin(Time.time * 0.5f * 2);
        GameObject.FindGameObjectWithTag("spaceship_2").transform.position = v3;

        parkedFleet = GameObject.FindGameObjectsWithTag("parketFleet");

        foreach (GameObject parkFl in parkedFleet)
            parkFl.transform.Translate(-Vector3.up * 0.5f * 0.01f * Mathf.Sin(Time.time * 0.5f + (float)(3.14 / 2)));

        patrolChangeDirection -= Time.deltaTime;

        fleet = GameObject.FindGameObjectsWithTag("spaceFleet");
        //Debug.Log(patrolChangeDirection);
        foreach (GameObject fl in fleet)
        {
            
            if (patrolChangeDirection <= 20 && patrolChangeDirection >0 )
                fl.transform.Translate(-Vector3.up * 0.5f/20 /* * Time.time*/);
            else if (patrolChangeDirection <= 0)
            {
                patrolChangeDirection = 20;

                foreach (GameObject fle in fleet)
                {
                    fle.transform.Rotate(0, 0, -90);
                }
                fl.transform.Translate(-Vector3.left * 0.5f/20/** Time.time*/);
            }
        }
        droidFleet = GameObject.FindGameObjectsWithTag("droidFleet");

        foreach (GameObject drFleet in droidFleet)
            drFleet.transform.Translate(-Vector3.back * 0.5f / 60 * Time.time);
    }
}
