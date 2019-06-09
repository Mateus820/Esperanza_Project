using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStuck : MonoBehaviour
{
    
    [SerializeField] private Transform followVerify;
    [SerializeField] private float checkTime;
    private bool isMoving = true;
    private Vector2 oldPos;

    private void OnCollisionStay2D(Collision2D other) {
        Follow();
    }

    private void OnCollisionExit2D(Collision2D other) {
        isMoving = true;
    }

    public bool PlayerMovingStatus(){
        return isMoving;
    }

    void Follow() {
        if(!(followVerify.transform.position == transform.position)){
            followVerify.transform.position = Vector2.MoveTowards(followVerify.transform.position, transform.position, checkTime);
            isMoving = true;
        }
        else
            isMoving = false;
    }
}
