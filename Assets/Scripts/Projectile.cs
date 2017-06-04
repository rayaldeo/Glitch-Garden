using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float speed;
	public float damage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right *speed *Time.deltaTime);
	}
	
	void OnTriggerEnter2D(Collider2D collider){
		Attacker attacker = collider.gameObject.GetComponent<Attacker>();
		HealthController health = collider.gameObject.GetComponent<HealthController>();
		if(attacker && health){
			health.DealDamage(damage);
			Destroy(gameObject);
		}
	}
	
	
}
