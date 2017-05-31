using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attacker))]

public class Fox : MonoBehaviour {
	public Animator anim;
	private Attacker attacker;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		attacker = GetComponent<Attacker>();
	}
	
	
	void OnTriggerEnter2D(Collider2D collider){
		GameObject obj = collider.gameObject;
		//Abort if not colliding with a Defender
		if(!obj.GetComponent<Defender>()){
			return;
		}else if(obj.GetComponent<Stone>()){
			//Debug.Log ("Fox collided with " + collider);
			anim.SetTrigger("jumpTrigger");
		}else{
			anim.SetBool("isAttacking",true);
			attacker.Attack(obj);
		}
	}
}
