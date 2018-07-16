using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
    public HealthBar healthBarScript;
    float fuelHP;
    SpriteRenderer image;
    AudioSource blast;

	// Use this for initialization
	void Start () {
        image = GetComponentInChildren<SpriteRenderer>();
        blast = GetComponent<AudioSource>();

        image.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        fuelHP = healthBarScript.getFuelHP();

        if (fuelHP > 0){
            if (Input.GetKeyDown(KeyCode.Space))
            {
                blast.Play();
            }

            if (Input.GetKey(KeyCode.Space))
            {
                image.enabled = true;
            }
            else
            {
                image.enabled = false;
            }
        }
        else{
            image.enabled = false;
        }

	}
}
