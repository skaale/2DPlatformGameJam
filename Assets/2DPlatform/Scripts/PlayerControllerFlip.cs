using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerFlip : MonoBehaviour

{ 
	public float jumpForce = 6f;
	public float runningSpeed = 1.5f;
	public float dist = 2.2f;
	public float speed = 1.0f;
	public string axisName = "Horizontal";

    public bool facingRight;
	public Animator anima;

	private Rigidbody2D rigidBody;

    void Awake()
    {
		anima = GetComponent<Animator>();

    }

	void Start() 
	{
        facingRight= true;
		rigidBody = GetComponent<Rigidbody2D>();
       
	}


	// Update is called once per frame
	void FixedUpdate () 
	{


        float horizontal = Input.GetAxis(axisName);
		anima.SetFloat("Speed", Mathf.Abs(horizontal));
	
		if (Input.GetMouseButtonDown(0)) 
		{

			Jump();
		}

		transform.position += transform.right * horizontal * speed * Time.deltaTime;
		Flip(horizontal);
        
	}


	/// <summary>
	/// /*Flip the specified horizontal.*/
	/// </summary>
	/// <param name="horizontal">Horizontal.</param>
	void Flip(float horizontal)
    {
       
		if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
		{
			facingRight = !facingRight;

			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale; 


		}
  
    }


	void Jump() 
	{
	if (IsGrounded()) 
		{
			rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
		}
	}


	public LayerMask groundLayer;
	bool IsGrounded() 
	{
		if (Physics2D.Raycast(this.transform.position, Vector2.down, dist ,groundLayer.value)) 
		{
			return true;
		}
		else {
			return false;
		}
	}





}
