using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour 
{
	public class PlayerStats
	{
		public int PlayerHealth = 100;

	}

	public PlayerStats playerStats = new PlayerStats();
	// Update is called once per frame
	void Update () 
	{
		
			
		if(transform.position.y <= -20)
			DamagePlayer(9999999);
		
	}


	public void DamagePlayer(int damage)
	{
		playerStats.PlayerHealth -= damage;
		if( playerStats.PlayerHealth <= 0)
		{

			ReSpawner.KillPlayer(this);

		}

	}






}
