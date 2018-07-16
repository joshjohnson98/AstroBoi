using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tape : MonoBehaviour {

    AudioSource sound;
    Renderer image;
    BoxCollider2D collider2D;

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
            int cassetteBonus = PlayerPrefs.GetInt("cassetteBonus");
            PlayerPrefs.SetInt("cassetteBonus", cassetteBonus + 20);
            sound.Play();
            image.enabled = false;
            collider2D.enabled = false;
        }

    }
}
