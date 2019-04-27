using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public float fHealth;

	// Use this for initialization
	void Start () {
		fHealth = 100;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Damage(float fDamage)
    {
        fHealth -= fDamage;
    }
}
