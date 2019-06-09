using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collect : MonoBehaviour 
{

	[SerializeField] private Inventory inventory;

    void OnTriggerEnter2D (Collider2D other)
	{
		if(other.gameObject.tag == "Water"){
			inventory.AddItem(0, 1);
		}
		else if (other.gameObject.tag == "Remedy")
		{
			inventory.AddItem(1, 1);
		}
		else if(other.gameObject.tag == "Food")
		{
			inventory.AddItem(2, 1);
		}
    }
}
