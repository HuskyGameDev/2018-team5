using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour {
    private const double min = 0.195;
    private const double max = 0.196;
    private bool locked;
    private Rigidbody door;
	// Use this for initialization
	void Start () {
        door = GetComponent<Rigidbody>();
        locked = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (locked)
        {
            door.constraints.
        }
	}

    public bool isLocked ()
    {
        return locked;
    }

    public void setLocked()
    {
        if (transform.rotation.y < max && transform.rotation.y > min)
        {
            locked = !locked;
        }
    }
}
