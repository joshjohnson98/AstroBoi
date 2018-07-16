using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLoop : MonoBehaviour {
    public GameObject ObjectsSpawner;
    SpawnObjects spawn;

    void Start()
    {
        spawn = ObjectsSpawner.GetComponent<SpawnObjects>();
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("trigger");
        if (col.tag == "Astronaut")
        {
            col.SendMessage("SendToStart");

            spawn.ClearAllObjects();
            spawn.InstantiateObjects();

        }
        if (col.tag == "Shrapnel")
        {
            col.SendMessage("SendToStart");

        }
    }

}
