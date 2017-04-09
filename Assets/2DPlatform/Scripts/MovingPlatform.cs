using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour 
{
	private Vector3 posA;
	private Vector3 posB;

	private Vector3 nexPos;


	public Transform childTransform;

	public Transform transformB;

	public float speed = 1.5f;

	// Use this for initialization
	void Start () 
	{
		posA = childTransform.localPosition;
		posB = transformB.localPosition;
		nexPos = posB;
	}


	// Update is called once per frame
	void Update () 
	{
		Move();

	}

	public void Move()
	{

		childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition,nexPos,speed*Time.deltaTime);

	}



}
