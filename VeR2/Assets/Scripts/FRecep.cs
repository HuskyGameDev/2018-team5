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
        if (OVRInput.GetDown(OVRInput.Button.One)) {
            Cook();
        }
	}
    
    //When the corresponding button is hit
    public void Act() {
        if(WhatToDo == 0) {
            Cook();
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

    //Cook objects in trigger
    public void Cook() {
        if (true) { //Temp spot for making sure the door is locked
            for(int i = 0; i < ToCook.Count; i++) {
                ToCook[i].Cooked();
            }
        }
    }
}
