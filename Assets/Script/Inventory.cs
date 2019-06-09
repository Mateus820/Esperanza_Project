using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [Header("Values")]
    [SerializeField] private int waterQt;   //index: 0
    [SerializeField] private int remedyQt;  //index: 1
    [SerializeField] private int foodQt;    //index: 2

    [Header("UI")]
    [SerializeField] private Text UI_water;
    [SerializeField] private Text UI_remedy;
    [SerializeField] private Text UI_food;

    [Header("References")]
    [SerializeField] private PlayerStats ps;

    void Start() {
        UpdateInventory();
    }

    void UpdateInventory(){
        UI_water.text = "Water: x" + waterQt;
        UI_remedy.text = "Remedy: x" + remedyQt;
        UI_food.text = "Food: x" + foodQt;
    }

    public void AddItem(int type, int quantity){
        switch(type){
            case 0:
                waterQt += quantity;
            break;
            case 1:
                remedyQt += quantity;
            break;
            case 2:
                foodQt += quantity;
            break;
            default:
                print("ERRO, can't add item!, CODE: Inventory");
            break;
        }
        UpdateInventory();
    }

    public void OnClick(int type){
        switch (type)
        {
            case 0:
                if(waterQt <= 0) return;
                waterQt--;
                ps.ApplyItem(0, 10);
            break;
            case 1:
                if(remedyQt <= 0) return;
                remedyQt--;
                ps.ApplyItem(1, 20);
            break;
            case 2:
                if(foodQt <= 0) return;
                foodQt--;
                ps.ApplyItem(2, 10);
            break; 
            default:
                print("ERRO, No Food Selected!, CODE: Inventory");
            break;
        }
        UpdateInventory();
    }
}
