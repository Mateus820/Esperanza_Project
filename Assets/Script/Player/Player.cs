using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	[SerializeField] private float speed;
	[SerializeField] private Rigidbody2D rb;

	void FixedUpdate(){
        Moviment();
    }

    void Moviment()
    {
		float movH = Input.GetAxis ("Horizontal") * speed;
		float movV = Input.GetAxis ("Vertical") * speed;
		
		rb.velocity = new Vector2 (movH, movV);
    }
}
