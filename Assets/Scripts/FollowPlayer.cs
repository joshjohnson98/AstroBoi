using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public GameObject player;
    Vector3 temp;

    float x, y, z;

	void Update () {
        x = gameObject.transform.position.x;
        y = player.transform.position.y;
        z = gameObject.transform.position.z;

        temp = new Vector3(x, y, z);

        gameObject.transform.position = temp;

	}
}
