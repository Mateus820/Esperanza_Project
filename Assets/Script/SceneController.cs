using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneController : MonoBehaviour {

    [SerializeField] private float transitionDelay;
    [SerializeField] private float enterDelay;

    [Header("References")]
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject img;

    void Start() {
        img.SetActive(true);
        StartCoroutine(FadeIn());    
    }

    public void ChangeScene(string name)
    {
        img.SetActive(true);
        StartCoroutine(FadeOut(name));
    }

    IEnumerator FadeOut(string name){
        yield return new WaitForSeconds(transitionDelay);
        anim.SetTrigger("FadeOut");
        yield return new WaitForSeconds(1.5f); //Never remove and don't change the time delay
        SceneManager.LoadScene(name);
    }

    IEnumerator FadeIn(){
        yield return new WaitForSeconds(enterDelay);
        anim.SetTrigger("FadeIn");
    }
    
    public void ActiveImg(){
        img.SetActive(true);
    }

    public void DesactiveImg(){
        img.SetActive(false);
    }

    public void ExitGame(){
        Application.Quit();
    }
}
