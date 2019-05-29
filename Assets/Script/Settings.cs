using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Settings : MonoBehaviour {

	public AudioSource source;
	public  AudioClip [] clips;

	private void Start() {
		
	}

	public void Mute(string name)
	{
		AudioListener.pause = true; 
	}

	public void UnMute(){
		
	}
}
