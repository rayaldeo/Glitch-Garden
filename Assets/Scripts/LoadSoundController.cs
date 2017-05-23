using UnityEngine;
using System.Collections;

public class LoadSoundController : MonoBehaviour {
	
	public AudioSource audioSource;
	// Use this for initialization
	void Awake () {
		audioSource.volume = PlayerPrefsManager.GetMasterVolume();
	}
	
}
