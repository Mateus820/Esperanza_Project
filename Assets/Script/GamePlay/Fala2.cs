using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fala2 : MonoBehaviour
{

    public Text fala2 = null;
    public int contador = 0;

    public void Next()
    {
        contador++;
         
		if (contador == 1) {
			fala2.text = "A guerra esta mais violenta, pessoas estao morrendo todos os dias, a cada dia que passa a esperanca vai sumindo do coracao do povo. ";
		} else if (contador == 2) {
			fala2.text = "Continua...";
		} else if (contador == 3) {
		
			SceneManager.LoadScene ("Inicial");
		}
    }
}