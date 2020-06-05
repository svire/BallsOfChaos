using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour {


    // When a match is found, the ball is destroyed, and the goal is
    // set to solved
    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if(collidedWith.tag==gameObject.tag)
        {
            GetComponent<Light>().intensity = 0;
            Destroy(collidedWith);
        }

    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
