using UnityEngine;
using System.Collections;

public class ConcreteDecoratorA : NewDecorator {
	protected GameObject gameObject;
	static int alpha_track=0;
	string[] alphabate_array = { "A", "B", "C","D","E" };

	public override void Operation()
	{
		base.Operation();
		Debug.Log("ConcreteDecoratorA.Operation()");
	}

	public override GameObject getGameObject()
	{
		gameObject = base.getGameObject ();

		//int alphaspawnPointIndex = Random.Range (0, alphabate_array.Length);

		if (alpha_track >= alphabate_array.Length) {
			alpha_track=0;
			Debug.Log("ConcreteDecoratorA.getGameObject()---"+"Displaying alphabate"+alphabate_array[alpha_track]);
		}

		Material newMat = Resources.Load(alphabate_array[alpha_track], typeof(Material)) as Material;

		gameObject.renderer.material = newMat;
		gameObject.name = alphabate_array [alpha_track];
		alpha_track++;
	
		return gameObject;
	}
}
