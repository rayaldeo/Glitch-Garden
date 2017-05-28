using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody2D))]
public class Attacker : MonoBehaviour {


	private float currentSpeed;
	private GameObject currentTarget;

	// Use this for initialization
	void Start () {
		//Rigidbody2D myRigid = gameObject.AddComponent<Rigidbody2D>();
		//myRigid.isKinematic=true;	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left*currentSpeed*Time.deltaTime);
	
	}
	
	void OnTriggerEnter2D(){
		Debug.Log (name + "trigger Enter for Attackers");
	
	}
	
	public void SetCurrentSpeed(float speed){
		currentSpeed=speed;
	}
	//Called from the Animator at the time of the actual Attack
	public void StrikeCurrentTarget(float damage){
		Debug.Log(name + " Caused damage: "+ damage);
	}
	
	public void Attack(GameObject obj){
		currentTarget = obj;
	}
}
