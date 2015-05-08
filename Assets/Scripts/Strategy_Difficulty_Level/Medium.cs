// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;

public class Medium : MonoBehaviour, IGameDifficulty
{

	public Medium ()
	{
	}

	public void instantiate() {
		EnemyAttack._setAttackDamage (10);
		PlayerShooting._setDamagePerShot (15);
	}

	public void calculateScore() {
			Debug.Log("Medium : " + gameObject.GetComponent<EnemyHealth> ().tag);
			if (gameObject.GetComponent<EnemyHealth> ().tag == "Zombunny") {
				// gameObject.GetComponent<EnemyHealth> ().scoreValue -= 3;
				ScoreManager.score += (gameObject.GetComponent<EnemyHealth> ().scoreValue - 3);
			} 
			if (gameObject.GetComponent<EnemyHealth> ().tag == "Zombear") {
				//gameObject.GetComponent<EnemyHealth> ().scoreValue -= 3;
				ScoreManager.score += (gameObject.GetComponent<EnemyHealth> ().scoreValue - 3);
			}
			if (gameObject.GetComponent<EnemyHealth> ().tag == "Hellephant") {
				//gameObject.GetComponent<EnemyHealth> ().scoreValue -= 5;
				ScoreManager.score += (gameObject.GetComponent<EnemyHealth> ().scoreValue - 5);
			} 
	}
}

