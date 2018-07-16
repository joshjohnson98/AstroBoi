using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burst : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Burst");
        if (col.tag == "Astronaut")
        {
            col.SendMessage("Dash");
        }
    }
}
