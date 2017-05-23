using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelAfter;
	public bool splashScreen;

	void Start(){
		if(autoLoadNextLevelAfter<=0){
			Debug.Log ("Level Auto load is disabled, use a positive number in seconds");
		}else{
			Invoke ("LoadNextLevel",autoLoadNextLevelAfter);
		}
	}
	
	public void LoadLevel(string name){
		//Debug.Log("Level Load Request for: "+name);
		Application.LoadLevel(name);
	}
	
	private void LoadNextLevel(){
		if(splashScreen){
			Application.LoadLevel(Application.loadedLevel+1);
		}
	}
	
	public void QuitLevel(){
		Debug.Log("Quit Game Request");
		//Application.Quit();
	}
}
