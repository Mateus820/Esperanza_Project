using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PassarTela : MonoBehaviour {

   
    public void inicial(string nome)
    {
        SceneManager.LoadScene(nome);
    }
}
