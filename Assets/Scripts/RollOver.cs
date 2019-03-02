using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollOver : MonoBehaviour {

	private float width;

	// Use this for initialization
	void Start () {
		width = gameObject.GetComponentInChildren<BoxCollider2D>().size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x <= -width)
		{
			transform.Translate(Vector3.right * width * 2);
		}
	}
}
