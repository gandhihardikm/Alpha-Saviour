using UnityEngine;
using System.Collections;

public class AlphSphere : MonoBehaviour,IAlphaFactory {

	public GameObject getGameObject(){
		
		return (GameObject)Instantiate(Resources.Load("AlphabateSphere"));
	}
}
