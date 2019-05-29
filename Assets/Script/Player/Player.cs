using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public float movH;	
	public float movV;	
	public float speed;
	public Rigidbody2D rb2d;

	void FixedUpdate(){
        Moviment();
    }

    void Moviment()
    {
		movH = Input.GetAxis ("Horizontal") * speed;
		movV = Input.GetAxis ("Vertical") * speed;

		Vector2 mov = new Vector2 (movH, movV);
		rb2d.velocity = mov;
    }
}
