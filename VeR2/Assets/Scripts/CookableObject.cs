using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookableObject : MonoBehaviour {

    bool IsCooked;
    Renderer ObjMat;

	// Use this for initialization
	void Start () {
        IsCooked = false;
        ObjMat = transform.GetComponent<Renderer>();
	}

    public void Cooked() {
        IsCooked = true;
        ObjMat.material.color = Color.red;
    }
}
