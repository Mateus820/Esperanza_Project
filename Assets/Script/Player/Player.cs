using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	[Header("Move")]
	[SerializeField] private float speed;
	[SerializeField] private Rigidbody2D rb;

	[SerializeField] private PlayerStats ps;

	void FixedUpdate(){
        Moviment();
    }

    void Moviment()
    {
		float movH = Input.GetAxis ("Horizontal") * speed;
		float movV = Input.GetAxis ("Vertical") * speed;
		
		rb.velocity = new Vector2 (movH, movV);
    }

	void OnCollisionEnter2D(Collision2D other) {
		if(other.gameObject.tag == "Enemy"){
			ps.DecrementLife(10);
		}	
	}
}
