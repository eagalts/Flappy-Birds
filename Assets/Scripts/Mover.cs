using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	private float speed;

	// Use this for initialization
	void Start () {
		speed = Global.global.scrollSpeed;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (!Global.global.gameOver) {
			transform.Translate(Vector3.left * (speed * Time.fixedDeltaTime));
		}
	}
}
