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

	[Header("Food")]
	[SerializeField] private float foodValue;
 
	[Header("Stats")]
	[SerializeField] private bool thirsty;
	[SerializeField] private bool hungry;

	void Start() {

		//initial values
        curLife = maxLife;

		//Loop methods
		InvokeRepeating("SetWater", 0.1f, 0.1f);
		InvokeRepeating("SetStats", 0.1f, 0.1f);
	}

	void SetStats(){
		SetHeart();
	}

    void SetHeart(){
		lifeBar.fillAmount = ConvertValue(curLife, 0, maxLife, 0, 1); //temp code
	}

	void SetWater(){
		if(waterValue > 0){
			thirsty = false;
			waterValue -= 0.1f;
		}
		if(waterValue <= 0){
			thirsty = true;
		}
		float result = ConvertValue(waterValue, 0, 100, 0, 1);
		waterBar.fillAmount = result;
	}

	public void DecrementLife(int v){
		if(curLife > maxLife){
			curLife = maxLife;
		}
		curLife -= v;
		if(curLife <= 0){
			SceneManager.LoadScene("GameOver");
		}
	}

	public void ApplyItem(int id, int value){
		switch (id)
		{
			case 0:
				waterValue += value;
			break;
			case 1:
				curLife += value;
			break;
			case 2:
				foodValue += value;
			break;
			default:
				print("ERRO, id not found!, CODE: PlayerStats");
			break;
		}
	}

	public float ConvertValue(float value, float inMin, float inMax, float outMin, float outMax){
        return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
        //(80 - 0) * (1 - 0) / (100 - 0) + 0;
    }
}
