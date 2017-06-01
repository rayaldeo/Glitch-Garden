using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	public GameObject projectile,projectileParent,gun;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	private void Fire(){
		GameObject newProjectile =Instantiate(projectile) as GameObject;
		newProjectile.transform.parent =projectileParent.transform;
		newProjectile.transform.position =gun.transform.position;
	}
}
