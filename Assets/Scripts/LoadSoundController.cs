using UnityEngine;
using System.Collections;

public class LoadSoundController : MonoBehaviour {
	
	public AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource.volume = PlayerPrefsManager.GetMasterVolume();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
