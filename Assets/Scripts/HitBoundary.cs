using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoundary : MonoBehaviour
{

    //GameObject player;

    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Astronaut");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Boundary collision!");
        //Destroy(player);
    }

}
