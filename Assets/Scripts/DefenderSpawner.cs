using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {

	public Camera myCamera;
	private GameObject defenderParent;

	// Use this for initialization
	void Start () {
		defenderParent = GameObject.Find ("Defenders");
		if(!defenderParent){
			defenderParent = new GameObject("Defenders");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown(){
		//print ("clicked Position: "+Input.mousePosition);
		print ("clicked Position: "+SnapTwoGrid(CalculateWorldPointOfMouseClick()));
		GameObject newDefender =Instantiate (Buttons.selectedDefender,SnapTwoGrid(CalculateWorldPointOfMouseClick()),Quaternion.identity) as GameObject;
		newDefender.transform.parent = defenderParent.transform;
	}
	
	Vector2 SnapTwoGrid(Vector2 rawWorldPosition){
		float newX =Mathf.Round(rawWorldPosition.x);
		float newY = Mathf.Round(rawWorldPosition.y);
		return new Vector2(newX, newY);
	}
	
	Vector2 CalculateWorldPointOfMouseClick(){
		float mouseX = Input.mousePosition.x;
		float mouseY = Input.mousePosition.y;
		float distanceFromCamera = 10f;
		Vector3 weirdTripplet = new Vector3(mouseX,mouseY,distanceFromCamera);
		Vector2 worldPos = myCamera.ScreenToWorldPoint(weirdTripplet);
		return worldPos;
	}
}
