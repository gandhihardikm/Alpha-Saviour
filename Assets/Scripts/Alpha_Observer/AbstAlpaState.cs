using UnityEngine;
using System.Collections;

public abstract class AbstAlpaState  {
	
	public abstract void attach(AbstAlphaObserver obj);
	public abstract void detach(AbstAlphaObserver obj);
	public abstract void notifyObservers();
}
