using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrapnel : MonoBehaviour {
    public float speed = 1;
    public bool isDead;
    LoadScene loadScene;
    Rigidbody2D rigid;
	// Use this for initialization
    void Start () {
        loadScene = GetComponent<LoadScene>();
        isDead = false;
        rigid = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 direction = gameObject.transform.up;
        gameObject.transform.Translate(Vector3.up * Time.deltaTime * speed);
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("should destroy asteroid");
        //if (col.gameObject.tag == "Asteroid")
        //{
        //    col.SendMessage("DestroyAsteroid");
        //}

        if (col.gameObject.tag == "Astronaut")
        {
            isDead = true;
            loadScene.LoadByIndex(2);
        }
    }

    public void SendToStart()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, -0.80f, gameObject.transform.position.z);
    }
}
