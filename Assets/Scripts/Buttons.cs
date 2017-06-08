using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

	private Buttons[] buttonSelectedArray;
	public static GameObject selectedDefender;
	public GameObject defenderPrefab;

	// Use this for initialization
	void Start () {
		buttonSelectedArray = GameObject.FindObjectsOfType<Buttons>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown(){
		print(name + " Pressed");
		foreach(Buttons thisButton in buttonSelectedArray){
			thisButton.GetComponent<SpriteRenderer>().color = Color.black;
		}
		GetComponent<SpriteRenderer>().color = Color.white;
		selectedDefender = defenderPrefab;
		print(selectedDefender);
	}
	
	
}
