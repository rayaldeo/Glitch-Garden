using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelAfter;

	void Start(){
		Invoke ("LoadNextLevel",autoLoadNextLevelAfter);
	}
	
	public void LoadLevel(string name){
		Debug.Log("Level Load Request for: "+name);
		Application.LoadLevel(name);
	}
	
	private void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel+1);
	}
	
	public void QuitLevel(){
		Debug.Log("Quit Game Request");
		//Application.Quit();
	}
}
