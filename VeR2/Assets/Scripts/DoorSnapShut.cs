using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this code allows a HingeJoint to toggle the spring depending on how close it is to being shut

public class DoorSnapShut : MonoBehaviour {
    private const double minAngle = 30.0 / 360.0 + 0.1950903; // 30 deg converted to decimal and adjusted to match 0
    private HingeJoint hinge; // reference to hingeJoint to turn on and off spring
    private
	// Use this for initialization
	void Start () {
        hinge = GetComponent<HingeJoint>(); 
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.rotation.y < minAngle) { hinge.useSpring = true; } // if it is close to shut, turn spring on
        else { hinge.useSpring = false; } // else, turn spring off so it swings freely
	}
}
