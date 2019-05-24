using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MovEnemy : MonoBehaviour {

    SpriteRenderer sprite;
    public float speed;
    public bool negativo, horiz, vert;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

        negativo = false;
    }

    void Update()
    {
        Movimentação();
    }

    public void Movimentação()
	{
			
       if (horiz) { transform.Translate(Vector2.right * speed * Time.deltaTime); sprite.flipX = negativo; }
        else if (vert) { transform.Translate(Vector2.up * speed * Time.deltaTime); sprite.flipY = negativo; }
    }

    private void OnCollisionEnter2D(Collision2D colider)
    {
        speed *= -1;
        negativo = !negativo;
    }
}

