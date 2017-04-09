using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ReSpawner : MonoBehaviour 
{
	public Transform spawnPoint;
	public Transform playerPrefab;

	public static int coins;

	private static int remainingsLives = 3;
	public static  int RemainingsLives
	{
		get{ return remainingsLives;
		}


	}

	private static int totalAmountCoins = 500;
	public static  int TotalAmountCoins
	{
		get { return totalAmountCoins;
		}


	}



	public static ReSpawner rs;

	// Use this for initialization
	void Start () 
	{

		if(rs == null)
		{
			rs = GameObject.FindGameObjectWithTag("PC").GetComponent<ReSpawner>();
		}

		rs.RespawnPlayer();

		
	}
	
	public void RespawnPlayer()
	{
		Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);

	}

	public void EndGame()
	{

		Debug.Log("EndGame");
		CoinCollector.Reset();


	}


	public static void KillPlayer(Health health)
	{

		Destroy(health.gameObject);
		remainingsLives--;
		if(remainingsLives <= 0)
		{

			rs.EndGame();


		}else 
		{
			rs.RespawnPlayer();
		}


	}

	public static void ChangeLevel()
	{		
		CoinCollector.Coins = coins + 1000 ;

			Application.LoadLevel("Lv1");
			rs.RespawnPlayer();

	}

}
