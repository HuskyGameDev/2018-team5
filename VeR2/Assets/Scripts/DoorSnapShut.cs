using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSnapShut : MonoBehaviour {
    private const double minAngle = 30.0 / 360.0 + 0.1950903;
    private HingeJoint hinge;
    private
	// Use this for initialization
	void Start () {
        hinge = GetComponent<HingeJoint>();
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(transform.rotation.y - 0.1950903);
        if (transform.rotation.y < minAngle) { hinge.useSpring = true; }
        else { hinge.useSpring = false; }
	}
}
