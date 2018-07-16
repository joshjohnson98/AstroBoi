using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateClockWise : MonoBehaviour {
    public float AsteroidRotationSpeed = -10f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, 0, AsteroidRotationSpeed);
    }
}
