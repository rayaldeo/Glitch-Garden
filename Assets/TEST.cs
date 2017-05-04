using UnityEngine;
using System.Collections;

public class TEST : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print (PlayerPrefsManager.GetMasterVolume());
		PlayerPrefsManager.SetMasterVolume(0.4f);
		print (PlayerPrefsManager.GetMasterVolume());
		
		print ("Is Level 1 Unlocked? " + PlayerPrefsManager.IsLevelUnlocked(1));
		PlayerPrefsManager.UnlockLevel(1);
		print ("Is Level 1 Unlocked? " + PlayerPrefsManager.IsLevelUnlocked(1));
		
		print ("What is the difficulty? " + PlayerPrefsManager.GetDifficulty());
		PlayerPrefsManager.SetDifficulty(1f);
		print ("What is the difficulty? " + PlayerPrefsManager.GetDifficulty());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
