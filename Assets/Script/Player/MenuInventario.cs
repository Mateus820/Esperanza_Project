using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuInventario : MonoBehaviour 
{

	public GameObject Pause, comoJogar;

	void Update()
	{
		print (Time.timeScale);
		if (Input.GetButtonDown("Cancel"))
		{
			PauseUnpause ();
			Menu();		
		}
	}

	void Menu()
	{

		Pause.SetActive(!Pause.activeSelf);
	}

	void PauseUnpause() {
		Time.timeScale = (Time.timeScale != 0) ? 0f : 1f;
	}

	public void ComoJogar() {
		comoJogar.SetActive (!comoJogar.activeSelf);
	}
}
