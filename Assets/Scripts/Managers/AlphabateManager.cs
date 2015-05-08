using UnityEngine;
using System.Collections;

public class AlphabateManager : MonoBehaviour {

	public PlayerHealth playerHealth;
	public float spawnTime = 3f;
	public Transform[] spawnPoints;
	public GameObject alphabate;
	public GameObject decoratedAlphabate;


	void Start () {

		AlphaTextGen alphaGen = new AlphaTextGenImpl ();
		AlphaTargetTextManager.target_alpha_string = alphaGen.getTargetString ();
		Debug.Log ("Target Text is "+alphaGen.getTargetString ());
		IAlphaFactory alphaFactory = gameObject.AddComponent<AlpaCube> ();
		alphabate = alphaFactory.getGameObject();
		InvokeRepeating ("SpawnAlphabates", spawnTime, spawnTime);
	}
	
	void SpawnAlphabates ()
	{
		Debug.Log ("In SpawnAlphabates");
		if(playerHealth.currentHealth <= 0f)
		{
			return;
		}
		
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		alphabate.tag="Pickup";

		if (!alphabate.activeSelf)
			alphabate.SetActive (true);


		ConcreteComponent c = new ConcreteComponent(alphabate);
		ConcreteDecoratorA d1 = new ConcreteDecoratorA();
		ConcreteDecoratorB d2 = new ConcreteDecoratorB();
		
		// Link decorators
		d1.SetComponent(c);
		d2.SetComponent (d1);
	
		
	
		decoratedAlphabate = d2.getGameObject();



		Debug.Log ("Tage name is"+decoratedAlphabate.tag);
		
		Instantiate (decoratedAlphabate, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}
