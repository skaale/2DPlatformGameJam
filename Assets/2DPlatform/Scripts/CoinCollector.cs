using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinCollector : MonoBehaviour 
{
	

	int CoinsToAdd;
	public static int Coins = 500;


	Text text;


	// Use this for initialization
	void Start () 
	{
		text = GetComponent<Text>();

	}

	// Update is called once per frame
	void Update () 
	{	
			
		text.text = "" + Coins;
	}

	//The static declares it static, void is its return type
	public static void AddCoins (int CoinsToAdd)
	{
		Coins -= CoinsToAdd;
		if(Coins <= 0)
		{

			ReSpawner.ChangeLevel();
		}

	}

	public static void Reset()
	{


		Coins = 0;

	}





}