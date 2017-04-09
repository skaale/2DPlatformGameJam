using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesCounter : MonoBehaviour 
{
	private Text lives;
	

	void Awake()
	{
		lives = GetComponent<Text>();

	}

	// Update is called once per frame
	void Update () 
	{

		lives.text = "LIVES:" + ReSpawner.RemainingsLives.ToString();
		
	}
}
