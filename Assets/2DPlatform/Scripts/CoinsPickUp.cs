using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsPickUp : MonoBehaviour
{
	
	public int CoinsToAdd;
	public AudioSource audiocoins;

	void OnTriggerEnter2D()
	{
		audiocoins.Play();
        CoinCollector.AddCoins(CoinsToAdd);
		Destroy(this.gameObject);
	}




}
