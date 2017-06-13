using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent (typeof(Text))]
public class StarDisplay : MonoBehaviour {

	private int allStars;
	private Text totalStarsText;

	// Use this for initialization
	void Start () {
		totalStarsText= GetComponent<Text>();
	}
	
		
	public void AddStars(int amount){
		print (amount+ " stars added to display");
		allStars +=amount;
		totalStarsText.text =allStars.ToString();
		
	}
	
	public void UseStars(int amount){
		print (amount+ " stars subtracted from the display");
		allStars -=amount;
		totalStarsText.text =allStars.ToString();
	}
}
