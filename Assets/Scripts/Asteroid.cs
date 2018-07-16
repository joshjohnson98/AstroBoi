using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

    public float GavityPullSpeed = 50;
    public float AsteroidRotationSpeed = 0.5f;
    //public float OrbitSpeed = 2;

    public Rigidbody2D AstronautRB;
    public GameObject AstronautObject;
    public bool isNear;
    public Vector2 direction;

    public bool isUpright; // Check whether orientation is correct
    public bool jointIsEnabled; // Check whether wheel joint is connected

    //public TargetJoint2D targetJoint;
    //public RelativeJoint2D relJoint;

    // Use this for initialization
    void Start()
    {
        //relJoint = AstronautObject.GetComponent<RelativeJoint2D>();
        //targetJoint = AstronautObject.GetComponent<TargetJoint2D>();
        //asteroidObj = gameObject.GetComponent<Rigidbody2D>();
        isNear = false;
        isUpright = false;
        //relJoint.enabled = false;
        //targetJoint.enabled = false;
        jointIsEnabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the asteroid
        gameObject.transform.Rotate(0, 0, AsteroidRotationSpeed);
        
        // Start orbitting if astronaut is near
        if(isNear)
        {
            if (isUpright)
            {
                //targetJoint.enabled = false;
            }
        }
 

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Astronaut")
        {
            isNear = true;
            
            direction = new Vector2(other.transform.position.x - gameObject.transform.position.x, other.transform.position.y - gameObject.transform.position.y);
            // TODO: Reorient the Astronaut till feet are towards asteroid

            // Pulls the astronaut towards the surface once triggered
            AstronautRB.AddForce(-direction * GavityPullSpeed * Time.deltaTime, ForceMode2D.Impulse);

            // Reorients the astronaut so his feet are on the ground
            //if(!targetJoint.isActiveAndEnabled)
            //{
            //    targetJoint.enabled = true;
            //    AstronautRB.transform.Rotate(Vector2.up);
            //}

        }
    }

	public void DestroyAsteroid()
	{
        Destroy(gameObject);
	}


}



