using UnityEngine;
using System.Collections;

public class UpdateTargetTextObserver : ConcreteAlphaObserver {

	private string target_string=AlphaTargetTextManager.target_alpha_string;
	
	public UpdateTargetTextObserver(ConcreteAlphaState state){
		base.state = state;
	}
	
	public override void update_observer(){
		string updated_state = base.state.getState ();
		Debug.Log ("UpdateTargetTextObserver::"+"Target State"+target_string+"Updated State"+updated_state);
		Debug.Log ("Target State in AlphaTargetTextManager"+AlphaTargetTextManager.target_alpha_string);
		if (updated_state == AlphaTargetTextManager.target_alpha_string) {
			
			Debug.Log ("UpdateTargetTextObserver::Target Reached");
			AlphaTargetTextManager.target_alpha_string="";
			
			AlphaTextGen alphaGen=new AlphaTextGenImpl();
			
			AlphaTargetTextManager.target_alpha_string=alphaGen.getTargetString();
			AlphaTextManager.alpha_string="";
			
			
		}else if(updated_state.Length>=AlphaTargetTextManager.target_alpha_string.Length){
			
			AlphaTextGen alphaGen=new AlphaTextGenImpl();
			
			AlphaTargetTextManager.target_alpha_string=alphaGen.getTargetString();
			
			AlphaTextManager.alpha_string="";
			
		}
	}
}
