using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Put the 
public class FRecep : MonoBehaviour {

    public List<CookableObject> ToCook; //List of stuff that should be cooked
    public int WhatToDo; //Decides what course of action to take when the button attached to it is hit
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.GetDown(OVRInput.Button.One) && WhatToDo == 0) {
            Act();
        } else if (OVRInput.GetDown(OVRInput.Button.Two)) {
            Act();
        }
	}
    
    //When the corresponding button is hit
    public void Act() {
        if(WhatToDo == 0) {
            Cook();
        } else if (WhatToDo == 1) {
            Airlock();
        }
    }

    //Throw objects out of airlock
    private void Airlock() {
        if (true) { //Temp spot for making sure the door is locked
            for (int i = 0; i < ToCook.Count; i++) {
                if (ToCook[i].IsCooked) {
                    Destroy(ToCook[i].gameObject);
                }
            }
        }
    }

    //Cook objects in trigger
    public void Cook() {
        if (true) { //Temp spot for making sure the door is locked
            for (int i = 0; i < ToCook.Count; i++) {
                ToCook[i].Cooked();
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.transform.CompareTag("Cookable")) {
            CookableObject c = other.transform.GetComponent<CookableObject>(); //The object to be cooked.

            ToCook.Add(c);

        }
    }
    


    private void OnTriggerExit(Collider other) {
        if (other.transform.CompareTag("Cookable")) {
            CookableObject c = other.transform.GetComponent<CookableObject>(); //The object to be cooked.

            ToCook.Remove(c);
        }
    }


}
