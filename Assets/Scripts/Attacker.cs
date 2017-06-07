using UnityEngine;
using System.Collections;


[RequireComponent (typeof (Rigidbody2D))]
public class Attacker : MonoBehaviour {


	private float currentSpeed;
	private GameObject currentTarget;
	private HealthController health;
	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		//Rigidbody2D myRigid = gameObject.AddComponent<Rigidbody2D>();
		//myRigid.isKinematic=true;	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left*currentSpeed*Time.deltaTime);
		if(!currentTarget){
			animator.SetBool("isAttacking", false);
		}
		print(Buttons.selectedDefender);
	
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
		if(currentTarget){
			health =currentTarget.GetComponent<HealthController>();
			if(health){
				health.DealDamage(damage);
			}
		}
	}
	
	public void Attack(GameObject obj){
		currentTarget = obj;
	}
}
