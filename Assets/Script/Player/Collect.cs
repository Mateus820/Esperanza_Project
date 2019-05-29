using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collect : MonoBehaviour 
{
	public Text ponto;
	public int contador;
    public AudioSource coleta;

    void OnTriggerEnter2D (Collider2D other)
	{
       

		if (other.tag == "Comida")
		{
            contador++;
            Destroy(other.gameObject);
            ponto.text = "" + contador;
            coleta.Play();
			Destroy (other.gameObject);
			ponto.text = "" + contador;
		}
		if ( contador == 244)
		{
			SceneManager.LoadScene ("Vitória");
		}

    }
}
