using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    public HealthBar healthBarScript;
    float fuelHP;
    public bool isDead;
    public Text scoreText;
    public int score;
	public float speed = 100;
	public float rotationSpeed;
    public float dashForce = 500;
    private bool dash = false; 

	Rigidbody2D rigid;

    void Awake()
    {
        PlayerPrefs.SetInt("cassetteBonus", 0);
    }

	// Use this for initialization
	void Start ()
	{
		rigid = gameObject.GetComponent<Rigidbody2D>();
        isDead = false;
	}

	// Update is called once per frame
	void Update ()
	{
        if (!isDead)
        {
            score = (int) Time.timeSinceLevelLoad + PlayerPrefs.GetInt("cassetteBonus");
            scoreText.text = "Score: " + score.ToString();
            PlayerPrefs.SetInt("score", score);
        }
        
        fuelHP = healthBarScript.getFuelHP();
		Vector2 direction = gameObject.transform.up;

        if (Input.GetKey(KeyCode.Space)&& fuelHP > 0)
		{
			//gameObject.transform.Translate(direction * Time.deltaTime * speed, Space.World);

			rigid.AddForce(direction * Time.deltaTime * speed);
		}

		if (Input.GetKey(KeyCode.D))
		{
			gameObject.transform.Rotate(Vector3.forward, -rotationSpeed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.A))
		{
			gameObject.transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
		}
        if(dash) {
            rigid.AddForce(direction * Time.deltaTime * 500, ForceMode2D.Impulse);
            dash = false;  
        }
	}

    public void Dash() {
        dash = true; 
    }

    public void SendToStart() {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, -0.10f, gameObject.transform.position.z); 
    }
}