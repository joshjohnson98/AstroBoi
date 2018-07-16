using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenTank : MonoBehaviour {
    AudioSource sound;
    Renderer image;
    BoxCollider2D collider2D;
    public float increaseBy = 2000;

    // Use this for initialization
    void Start()
    {
        sound = GetComponent<AudioSource>();
        image = GetComponent<Renderer>();
        collider2D = GetComponent<BoxCollider2D>();
        image.enabled = true;
        collider2D.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("trigger");
        if (col.tag == "Astronaut")
        {
            col.SendMessage("IncreaseOxygen", increaseBy);
            sound.Play();
            image.enabled = false;
            collider2D.enabled = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
