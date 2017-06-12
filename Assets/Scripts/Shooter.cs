using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	public GameObject projectile,gun;
	private  GameObject projectileParent;
	private Animator animator;
	private EnemySpawner myLaneSpawner;

	// Use this for initialization
	void Start () {
		animator = GameObject.FindObjectOfType<Animator>();
		//Create a parent if necessary
		projectileParent = GameObject.Find ("Projectiles");
		if(!projectileParent){
			projectileParent = new GameObject("Projectiles");
		}
		SetMyLaneSpawner();
		//print (myLaneSpawner);
	}
	
	// Update is called once per frame
	void Update () {
		if(IsAttackingAheadInLane()){
			animator.SetBool("isAttacking", true);
			
		}else{
			animator.SetBool("isAttacking", false);
		}
	
	}
	
	//Look through all Enemy spawners, and set myLaneSpawner if found
	void SetMyLaneSpawner(){
		EnemySpawner [] spawnerArray = GameObject.FindObjectsOfType<EnemySpawner>();
		foreach(EnemySpawner spawner  in spawnerArray){
			if(spawner.transform.position.y == transform.position.y){
				myLaneSpawner =spawner;
				return;
			}
		}
		Debug.LogError(name + " Can't find spawner in Lane");
	}
	
	bool IsAttackingAheadInLane(){
		//Exit if no attackers in Lane
		if(myLaneSpawner.transform.childCount <=0){
			return false;
		}
		//If there are attackers, are they ahead?
		foreach(Transform attackers in myLaneSpawner.transform){
			if(attackers.transform.position.x > transform.position.x){
				return true;
			}
		}
		//Attackers in Lane but behind us.
		return false;
	}
	private void Fire(){
		GameObject newProjectile =Instantiate(projectile) as GameObject;
		newProjectile.transform.parent =projectileParent.transform;
		newProjectile.transform.position =gun.transform.position;
	}
}
