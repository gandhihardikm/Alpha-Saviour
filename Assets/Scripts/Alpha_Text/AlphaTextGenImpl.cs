using UnityEngine;
using System.Collections;

public class AlphaTextGenImpl : AlphaTextGen {

	protected string[] string_array = { "A","CD","CAB", "BED","DAD","BAD" };
	//	protected string[] string_array = { "AB", "BD","DA","BD" };
	public static int count=-1;
	
	public AlphaTextGenImpl(){
		count++;
		if (count >= string_array.Length)
			count = 0;
	}
	public override string getTargetString(){
		Debug.Log ("Logic for genrating Target String....");
		return string_array [count];
	}
		
}
