using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public GameObject[] attackerArray;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		foreach(GameObject thisAttacker in attackerArray){
			if(IsTimeToSpawn(thisAttacker)){
				Spawn(thisAttacker);
			}
		}
	}
	
	bool IsTimeToSpawn(GameObject attackerGameObject){
		Attacker attacker = attackerGameObject.GetComponent<Attacker>();
		float meanSpawnDelay = attacker.rateOfShowWithinSeconds;
		float spawnPerSecond =1/meanSpawnDelay;
		if(Time.deltaTime > meanSpawnDelay){
			Debug.LogWarning("Spawn rate capped by frame rate");
		}
		float threshold = spawnPerSecond *Time.deltaTime;
		return Random.value < threshold ? true:false;
		
	}
	
	void Spawn(GameObject myGameObject){
		GameObject myAttacker = Instantiate(myGameObject) as GameObject;
		myAttacker.transform.parent = transform;
		myAttacker.transform.position = transform.position;
		
	}
}
