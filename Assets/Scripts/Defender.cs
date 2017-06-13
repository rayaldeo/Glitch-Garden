using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {

	private StarDisplay starDisplay;
	public int defenderStarCost;
	
	void Start(){
		starDisplay = GameObject.FindObjectOfType<StarDisplay>();
	}

	void OnTriggerEnter2D(){
		Debug.Log (name + "trigger Enter for Defender");
	}
	
	void Update(){
		
	}
	
	public void AddStars(int amount){
		Debug.Log(amount+" stars has been added");
		starDisplay.AddStars(amount);
	}
}
