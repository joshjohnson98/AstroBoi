using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gauntlet : MonoBehaviour {

	// Use this for initialization
    Rigidbody2D rigid;
	void Start () {
        rigid = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 direction = gameObject.transform.up;
        rigid.AddForce(direction * Time.deltaTime * 1);
	}
}
