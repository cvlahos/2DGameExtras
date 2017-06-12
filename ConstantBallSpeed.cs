using UnityEngine;
using System.Collections;

public class ConstantBallSpeed : MonoBehaviour 
{
	
	Rigidbody2D rb;
	public float ballSpeed;
	public float boosterSpeed;
	
	public GameManager gameManager;
	
	public int boostCount;

	public CircleCollider2D ballCircCollider;

	Vector2 constantBallSpeed;
	
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D> ();
		ballCircCollider.enabled = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		ballSpeedManager ();

	}

	void ballSpeedManager()
	{
		Vector2 constantBallSpeed = rb.velocity.normalized * ballSpeed;
		
		rb.velocity = constantBallSpeed;

	}
	

	public void LauchBall()
	{
		ballCircCollider.enabled = true;
		transform.parent = null;
		rb.velocity = new Vector2 (0,ballSpeed * Time.deltaTime);
		
	}
	
	
	void OnCollisionEnter2D()
	{
		if (boostCount < gameManager.ballBoostLimit) 
		{
			BoostSpeed ();
		}
		
	}
	
	void BoostSpeed()
	{
		boostCount++;
		ballSpeed = ballSpeed + boosterSpeed;
	}
	
}
