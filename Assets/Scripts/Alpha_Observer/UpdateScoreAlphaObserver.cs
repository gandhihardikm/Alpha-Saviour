using UnityEngine;
using System.Collections;

public class UpdateScoreAlphaObserver : ConcreteAlphaObserver {

	//private string target_string=AlphaTargetTextManager.target_alpha_string;

	public UpdateScoreAlphaObserver(ConcreteAlphaState state){
		base.state = state;
	}
	
	public override void update_observer(){
		Debug.Log("In UpdateScoreAlphaObserver::update_observer Reached");
		//AlphaTargetTextManager.target_alpha_string="";
		string updated_state = base.state.getState ();
		if(updated_state==AlphaTargetTextManager.target_alpha_string){
			
			Debug.Log("UpdateScoreAlphaObserver::Target Reached");
			//AlphaTargetTextManager.target_alpha_string="";
			ScoreManager.score=ScoreManager.score+20;
			
		}else if(updated_state.Length>=AlphaTargetTextManager.target_alpha_string.Length){
			
			
			if(!((ScoreManager.score-5)<=0))
				ScoreManager.score=ScoreManager.score-5;
			
		}
	}
}
