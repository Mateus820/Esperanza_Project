using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{

    [Header("Life")]
	[SerializeField] private int curLife;
	[SerializeField] private int maxLife;
	[SerializeField] private Image lifeBar;

	[Header("Water")]
	[SerializeField] private float waterValue;
	[SerializeField] private Image waterBar;

	void Start() {

		//initial values
        curLife = maxLife;
		InvokeRepeating("SetWater", 2f, 2f);
		StartCoroutine(LessUpdate());
	}

	void SetStats(){
		SetHeart();
	}

    void SetHeart(){
		lifeBar.fillAmount = curLife/100f; //temp code
	}

	public void DecrementLife(int v){
		if(curLife > maxLife){
			curLife = maxLife;
		}
		else if(curLife <= 0){
			SceneManager.LoadScene("GameOver");
		}
		curLife -= v;
	}

	void SetWater(){
		waterValue -= 0.1f;
		waterBar.fillAmount = waterValue;
	}

    IEnumerator LessUpdate(){
        for(;;){
            SetStats();
            yield return new WaitForSeconds(0.1f); //late update speed
        }
    }
}
