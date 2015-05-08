using UnityEngine;
using System.Collections;

public class ConcreteDecoratorB : NewDecorator {

	protected GameObject gameObject;
	public override void Operation()
	{
		base.Operation();
		Debug.Log("ConcreteDecoratorB.Operation()");
	}
	
	public override GameObject getGameObject()
	{
		gameObject = base.getGameObject ();
		
		gameObject.tag="Pickup";
		gameObject.renderer.material.color = Color.magenta;
		
		return gameObject;
	}
}
