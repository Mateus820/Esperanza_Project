using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	[Header("Move")]
	[SerializeField] private float speed;
	[SerializeField] private Rigidbody2D rb;

	[SerializeField] private Animator anim;

	[Header("References")]
	[SerializeField] private PlayerStats ps;
	[SerializeField] private PlayerStuck playerStuck;

	void FixedUpdate(){
    Moviment();
  }

  void Moviment()
  {
		float movH = Input.GetAxisRaw("Horizontal") * speed;
		float movV = Input.GetAxisRaw("Vertical") * speed;
		
		rb.velocity = new Vector2 (movH, movV);

		//animation
		if(playerStuck.PlayerMovingStatus()){
			anim.SetFloat("MovH", movH);
			anim.SetFloat("MovV", movV);
		}
		else
		{
			anim.SetFloat("MovH", 0f);
			anim.SetFloat("MovV", 0f);
		}
  }

	void OnCollisionEnter2D(Collision2D other) {
		if(other.gameObject.tag == "Enemy"){
			ps.DecrementLife(10);
		}
	}
}
