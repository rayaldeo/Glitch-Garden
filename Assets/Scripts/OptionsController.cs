using UnityEngine;
using UnityEngine.UI;
using System;


public class OptionsController : MonoBehaviour {

	public LevelManager levelManager;
	private MusicManager musicManager;
	public Slider volumeSlider, difficultySlider;
	

	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager>();
		Debug.Log("Music Manager: "+musicManager);
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
		difficultySlider.value =PlayerPrefsManager.GetDifficulty();
	}
	
	// Update is called once per frame
	void Update () {
			try{
			musicManager.ChangeVolume(volumeSlider.value);
			Debug.Log ("This is the music Manager: "+ musicManager);
			}catch(Exception e){
				Debug.Log("No Music Player Present ,Exception: " + e);
			}
	}
	
	
	public void SaveAndExit(){
		PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
		PlayerPrefsManager.SetDifficulty(difficultySlider.value);
		levelManager.LoadLevel("01_Start");
	}
	
	public void SetDefault(){
		volumeSlider.value = volumeSlider.maxValue;
		difficultySlider.value =difficultySlider.maxValue-1f;
	}
	
		
}
