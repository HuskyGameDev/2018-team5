using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// allows a hingeJoint to be locked and unlocked if closed

public class DoorLock : MonoBehaviour {
    private const double min = 0.195; // range for registering door as shut
    private const double max = 0.196; // based on zeroing the value
    private bool locked; // tracks whether the hingeJoint is locked
    private Rigidbody door; // reference to the rigidbody of the object with the hingeJoint
	// Use this for initialization
	void Start () {
        door = GetComponent<Rigidbody>();
        locked = false; // able to open from start
	}
	
	// Update is called once per frame
	void Update () {
		if (locked) { door.isKinematic = true; } // prevent the hingeJoint from moving if locked
        else { door.isKinematic = false; } // else allow it to move
	}

    public bool isLocked () // accessor for locked
    {
        return locked;
    }

    public void setLocked() // mutator for locked
    {
        if (transform.rotation.y < max && transform.rotation.y > min) // only allows lock if closed
        {
            locked = !locked;
        }
    }
}
