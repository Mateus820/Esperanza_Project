using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameTime : MonoBehaviour
{

    [Header("Time Variables")]
    [SerializeField] private int hour;
    [SerializeField] private float minute;

    [Header("DayNightCycle")]
    [SerializeField] private Image colorSource;
    [SerializeField] private Color[] skyLight;

    void Start() {

        //10AM - 5PM = 255,255,255,255
        // 6PM - 7PM = 240,170,110,255
        //       8PM = 120,130,220,255 
        //9PM - 10PM = 60, 80, 170,255 //Night starts 9PM
        //11PM - 3AM = 35, 50, 120,255 
        // 4AM - 5AM = 120,150,180,255 //Night ends 4AM
        // 6AM - 9AM = 160,190,255,255
        skyLight = new Color[24]
        {
            new Color(0.14f, 0.20f, 0.47f, 1),
            new Color(0.14f, 0.20f, 0.47f, 1),
            new Color(0.14f, 0.20f, 0.47f, 1),
            new Color(0.14f, 0.20f, 0.47f, 1),
            new Color(0.47f, 0.51f, 0.86f, 1),
            new Color(0.47f, 0.51f, 0.86f, 1),
            new Color(0.63f, 0.75f, 1, 1),
            new Color(0.63f, 0.75f, 1, 1),
            new Color(0.63f, 0.75f, 1, 1),
            new Color(0.63f, 0.75f, 1, 1),
            new Color(1, 1, 1, 1),
            new Color(1, 1, 1, 1),
            new Color(1, 1, 1, 1),
            new Color(1, 1, 1, 1),
            new Color(1, 1, 1, 1),
            new Color(1, 1, 1, 1),
            new Color(1, 1, 1, 1),
            new Color(1, 1, 1, 1),
            new Color(0.94f, 0.67f, 0.43f, 1),
            new Color(0.94f, 0.67f, 0.43f, 1),
            new Color(0.47f, 0.51f, 0.86f, 1),
            new Color(0.24f, 0.31f, 0.67f, 1),
            new Color(0.24f, 0.31f, 0.67f, 1),
            new Color(0.14f, 0.20f, 0.47f, 1)
        };

        //initial Values
        hour = 0;
        minute = 0f;

        StartCoroutine(TimeCounter());
    }

    void SetColor(){
        //colorSource.color = new Color(skyLight[hour].r, skyLight[hour].g, skyLight[hour].b, 100f);
    }

    public void SetDayTime(int hour, float minute){

        if(this.hour > 24 && this.hour < 0){
            print("Invalid Argument!, CODE: GameTime");
            return;
        }

        if(this.minute > 60 && this.minute < 0){
            print("Invalid Argument!, CODE: GameTime");
            return;
        }

        this.hour = hour;
        this.minute = minute;
    }

    IEnumerator TimeCounter(){
        for(;;){
            if(minute < 60 && minute >= 0){
                minute++;
            }
            else if(minute >= 60){
                hour++;

                if(hour >= 24){
                    hour = 0;
                }

                minute = 0f;
            }
            else{
                print("ERRO, time out of scale, CODE: GameTime");
            }

            SetColor();

            yield return new WaitForSeconds(0.1f);
        }
    }
}
