using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AlphaTargetTextManager : MonoBehaviour {

	public static string target_alpha_string; 
	Text text;     
	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		target_alpha_string = "";
	}
	
	// Update is called once per frame
	void Update () {
		
		text.text = "Target: " + target_alpha_string;
	}
}
