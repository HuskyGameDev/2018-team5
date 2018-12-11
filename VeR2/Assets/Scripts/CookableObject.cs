﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookableObject : MonoBehaviour {

    public bool IsCooked;
    Renderer ObjMat;

	// Use this for initialization
	void Start () {
        IsCooked = false;
        ObjMat = transform.GetComponent<Renderer>();
	}

    public void Cooked() {
        if (!IsCooked) {
            IsCooked = true;
            ObjMat.material.color = Color.red;
        }
    }
}
