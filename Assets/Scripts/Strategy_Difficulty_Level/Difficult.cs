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
public class Difficult : MonoBehaviour, IGameDifficulty
{

	public Difficult ()
	{
	}

	public void instantiate() {
		EnemyAttack._setAttackDamage (15);
		PlayerShooting._setDamagePerShot (10);
	}

	public void calculateScore() {

			Debug.Log("Difficulty : " + gameObject.CompareTag ("Zombunny"));
			if (gameObject.CompareTag ("Zombunny")) {
			//	gameObject.GetComponent<EnemyHealth> ().scoreValue -= 5;
				ScoreManager.score += (gameObject.GetComponent<EnemyHealth> ().scoreValue - 5);
			} 
			if (gameObject.CompareTag ("Zombear")) {
				// gameObject.GetComponent<EnemyHealth> ().scoreValue -= 5;
				ScoreManager.score += (gameObject.GetComponent<EnemyHealth> ().scoreValue - 5);
			}
			if (gameObject.CompareTag ("Hellephant")) {
				ScoreManager.score += (gameObject.GetComponent<EnemyHealth> ().scoreValue - 10);
			} 
	}
}

