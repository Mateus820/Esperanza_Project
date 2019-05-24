using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Configuracoes : MonoBehaviour {

	public AudioSource music;
	public  AudioClip [] clips;

	public void AudioJogo (AudioClip Nclip)
	{
		music.clip = Nclip;
		music.Play ();
		music.Pause ();
		music.UnPause ();

		AudioListener.pause = true; 
		AudioListener.pause = false;
	}


}
