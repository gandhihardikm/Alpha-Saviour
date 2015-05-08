using UnityEngine;
using System.Collections;

public class ConcreteAlphaObserver : AbstAlphaObserver {


	protected ConcreteAlphaState state;

	public override void update_observer(){


	}



	
	public ConcreteAlphaObserver(){
		
	}
	
	public ConcreteAlphaObserver( ConcreteAlphaState theSubject )
	{
		this.state = theSubject ;
	}
}
