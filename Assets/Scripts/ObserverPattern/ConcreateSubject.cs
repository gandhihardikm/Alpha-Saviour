using UnityEngine;
using System.Collections;

public class ConcreateSubject : MonoBehaviour,ISubject {


	private ArrayList enemies = new ArrayList();
	

	public void attach(IObserver obj)
	{
		enemies.Add (obj);
	}

	public void detach (IObserver obj)
	{
		enemies.Remove (obj);
	}

	public void notifyObserver ()
	{
		IObserver obj;
		if (enemies != null) 
			for (int i=0; i<enemies.Count; i++) {
				obj = (IObserver)enemies[i];
				obj.update_observer();
			}
	}
}
