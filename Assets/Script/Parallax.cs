using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parallax : MonoBehaviour {

    public RawImage Fundo;
    public float speed;
	void Update () {

        Rect r = Fundo.uvRect;
        r.x += speed;
        Fundo.uvRect = r;
    }
}
