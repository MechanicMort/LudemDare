﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAttack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        print("ge");
        if (collider.tag == "Player")
        {
            print("damage");
            collider.SendMessage("Damage", 5);
        }
    }
}
