using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Colisao : MonoBehaviour {

	public Image barraVida;
	public Sprite[] vidas;
	public GameObject player;

	public int vida;

	private void PerderVida()
	{ 
		{
			vida--;
		}
	}

	void Update(){

			switch (vida) {

			case 0:
				barraVida.sprite = vidas [5];
				break;
			case 1:
				barraVida.sprite = vidas [4];
				break;

			case 2:
				barraVida.sprite = vidas [3];
				break;

			case 3:
				barraVida.sprite = vidas [2];
				break;

			case 4: 
				barraVida.sprite = vidas [1];
				break;

			case 5:
				barraVida.sprite = vidas [0];
				break;
			}

		if (vida <= 0) {
			SceneManager.LoadScene ("GameOver");
		}

	}


	void OnCollisionEnter2D (Collision2D coll) 
	{

		if (coll.gameObject.CompareTag ("Enemy"))
		{
			PerderVida ();
		}
	}

}