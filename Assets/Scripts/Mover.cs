using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	[SerializeField]
	private float speed = 2.0f;


	// Use this for initialization
	// Помимо Start есть awake, но запускается раньше старт (срабатывает как только обьекты загрузились)
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//У любого обьекта есть transform
		transform.Translate(Vector3.left * (Time.fixedDeltaTime * speed)); 
		//время потраченное для прорисовки последнего кадра. 
		//Стоит использовать только для определения величины в одном кадре которую нужно изменять, чтобы плавно переместить объект
		//Скорость: 2 еденицы в секунду.
	}
}
