using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour {

	public float health;

	public void DealDamage(float dmg){
		health -=dmg;
		if(health <0){
			//Optionally Trigger Die Animation
			DestroyObject();
		}
	}
	
	public void SetHealth(float value){
		health = value;
	}
	
	public void DestroyObject(){
		Destroy(gameObject);
	}
}
