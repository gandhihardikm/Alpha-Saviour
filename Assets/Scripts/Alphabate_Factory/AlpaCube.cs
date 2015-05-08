using UnityEngine;
using System.Collections;

public class AlpaCube : MonoBehaviour,IAlphaFactory {

	//public GameObject alphabate;

	public GameObject getGameObject(){

		return (GameObject)Instantiate(Resources.Load("Alphabate"));
	}

}
