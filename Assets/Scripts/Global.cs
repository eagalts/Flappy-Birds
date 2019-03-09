using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Global : MonoBehaviour {

	public static Global global;
	
	public float scrollSpeed = 2.0f;
	public int score = 0;
	public bool gameOver = false;
	public Text scoreText;
	public GameObject gameOverText;

	// Use this for initialization
	void Awake () {
		if (global == null) {
			global = this;
		} else if (this != global) {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
