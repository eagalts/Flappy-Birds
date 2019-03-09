using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {
	private Rigidbody2D rb2d; //Создаём приватную переменную типа Rigidbody2D с названием rb2d
	private Animator anim;
	private bool isDead = false;

	[SerializeField]
	private float jumpForce = 200f;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (!isDead) { // 
			if (Input.GetKeyDown(KeyCode.Space) ||
				Input.GetMouseButtonDown(0)) {
					anim.SetTrigger("Flap");
					rb2d.velocity = new Vector2(0, 0);
					rb2d.AddForce(transform.up * jumpForce);
			}
		}
	}

	void OnCollisionEnter2D(Collision2D other) {
		anim.SetTrigger("Die");
		isDead = true;
	}
}
