using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

    public Transform fuelTank;
    public Transform oxygenTank;
    public Transform CWAsteroid;
    public Transform CCWAsteroid;
    public Transform cassette;

    GameObject[] asteroids;
    GameObject[] fuelTanks;
    GameObject[] oxygenTanks;
    GameObject[] cassetteTapes;

    float randX;
    float randY;

    public int numFuelTanks = 20;
    public int numOxyTanks = 20;
    public int numAsteroids = 20;
    public int numCassettes = 10;

    public float minY = 0;
    public float maxY = 200;

    public float minX = -5;
    public float maxX = 5;

	// Use this for initialization
	void Start () {
        InstantiateObjects();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ClearAllObjects()
    {
        asteroids = GameObject.FindGameObjectsWithTag("Asteroid");
        fuelTanks = GameObject.FindGameObjectsWithTag("Fuel");
        oxygenTanks = GameObject.FindGameObjectsWithTag("Oxygen");
        cassetteTapes = GameObject.FindGameObjectsWithTag("Cassette");


        for (var i = 0; i < asteroids.Length; i++)
        {
            Destroy(asteroids[i]);
        }

        for (var i = 0; i < fuelTanks.Length; i++)
        {
            Destroy(fuelTanks[i]);
        }

        for (var i = 0; i < oxygenTanks.Length; i++)
        {
            Destroy(oxygenTanks[i]);
        }

        for (var i = 0; i < cassetteTapes.Length; i++)
        {
            Destroy(cassetteTapes[i]);
        }
    }

    public void InstantiateObjects(){
        for (int i = 0; i < numFuelTanks; i++)
        {
            randX = Random.Range(minX, maxX);
            randY = Random.Range(minY, maxY);
            Instantiate(fuelTank, new Vector2(randX, randY), Quaternion.identity);
        }

        for (int i = 0; i < numOxyTanks; i++)
        {
            randX = Random.Range(minX, maxX);
            randY = Random.Range(minY, maxY);
            Instantiate(oxygenTank, new Vector2(randX, randY), Quaternion.identity);
        }

        for (int i = 0; i < numAsteroids / 2; i++)
        {
            randX = Random.Range(minX, maxX);
            randY = Random.Range(minY, maxY);
            Instantiate(CCWAsteroid, new Vector2(randX, randY), Quaternion.identity);
        }

        for (int i = 0; i < numAsteroids / 2; i++)
        {
            randX = Random.Range(minX, maxX);
            randY = Random.Range(minY, maxY);
            Instantiate(CWAsteroid, new Vector2(randX, randY), Quaternion.identity);
        } 

        for (int i = 0; i < numCassettes; i++)
        {
            randX = Random.Range(minX, maxX);
            randY = Random.Range(minY, maxY);
            Instantiate(cassette, new Vector2(randX, randY), Quaternion.identity);
        } 
    }


    //make function to instantiate all objects.
    //call that function once at start
    //call that function from loop script upon collision
    //make function to destroy all existing objects with specific tags
        //call this before recreating all objects
    //update prefabs to have those tags
}
