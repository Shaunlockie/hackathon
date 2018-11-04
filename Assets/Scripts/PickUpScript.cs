﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour{
    public int PickUpIdent;
    public PickUpHandler pickUpHandler;
	// Use this for initialization
	void Start () {
        

    }

    // Update is called once per frame
    void Update() { }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Player") ) {
            pickUpHandler.PickUpProcessor(PickUpIdent);
            Destroy(this.gameObject);
            
        }
    }
}
