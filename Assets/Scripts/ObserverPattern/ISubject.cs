using UnityEngine;
using System.Collections;

public interface ISubject {

	//void attach(IObserver obj);
	//void detach(IObserver Obj);
	void notifyObserver();
}
