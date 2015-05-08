using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class AlphaTextManager : MonoBehaviour {

	public static string alpha_string; 
	Text text;                      // Reference to the Text component.

	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		alpha_string = "";
	}
	
	// Update is called once per frame
	void Update () {
	
		text.text = "PICKUPS: " + alpha_string;
	}
}
