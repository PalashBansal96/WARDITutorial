using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

	//We don't need the start and edit functions here
	
	
	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			other.gameObject.GetComponent<ScoreManager>().score += 1;
			print("Coin collected");
			Destroy(gameObject); //Destroy self.
		}
	}

}
