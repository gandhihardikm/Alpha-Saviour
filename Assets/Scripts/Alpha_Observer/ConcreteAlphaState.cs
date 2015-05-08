using UnityEngine;
using System.Collections;

public class ConcreteAlphaState : AbstAlpaState {

	private string subjectState;

	private ArrayList observers = new ArrayList();

	public override void attach(AbstAlphaObserver obj){

		observers.Add (obj);
	}
	public override void detach(AbstAlphaObserver obj){

		observers.Remove (obj);
	}
	public override void notifyObservers(){
		AbstAlphaObserver obj;
		if(observers!=null)
			for( int i=0;i<observers.Count;i++)
		{
			obj=(AbstAlphaObserver)observers[i];
			obj.update_observer();
			
		}


	}


	public string getState() {
		return subjectState ;
	}
	public void setState(string status) {
		Debug.Log ("In ConcreteAlphaState::setState");
		subjectState = status ;
		notifyObservers();
	}
}
