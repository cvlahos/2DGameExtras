using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour 
{
	Rigidbody ballRB;
	TrailRenderer ballTrail;
	Transform paddleTR;

	public float ballLaunchSpeed;

	float ballMagnitude;

	//MusicManager musicManager;



	// Use this for initialization
	void Start () 
	{
		ballRB = GetComponent<Rigidbody> ();
		ballTrail = GetComponent<TrailRenderer> ();
		paddleTR = GameObject.Find ("Paddle").GetComponent<Transform> ();



		//musicManager = FindObjectOfType<MusicManager> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		ForceDetector ();
		//ballMagnitude = ballRB.velocity.magnitude;
		//slowBallBooster ();
		//Debug.Log (ballMagnitude);
	}
	public void LaunchBall()
	{

		transform.parent = null;
		ballRB.AddForce (ballLaunchSpeed,0,0);
		PaddleCTRL.isBallFired = true;
		PaddleCTRL.isForceOn = false;

	}

	/*void OnTriggerEnter (Collider tri)
	{
		Debug.Log ("Trigger");
	}
	
	void OnCollisionEnter (Collision col)
	{
		Debug.Log ("Collision");
	}
	*/

	void OnCollisionEnter (Collision col)
	{

	}

	public void ForceDetector()
	{
		if (PaddleCTRL.isForceOn == true) 
		{
			ballTrail.enabled = true;
		}
		else if (PaddleCTRL.isForceOn == false)
		
		{

			ballTrail.enabled = false;
		}
	}



	/*
	 //will detect magnitude and make it faster heading towards the paddle if the ball falls under a certain number
	void slowBallBooster()
	{
		if (ballMagnitude < 200f && PaddleCTRL.isBallFired == true) 
		{

			ballRB.velocity += new Vector3 (paddleTR.position.x, paddleTR.position.y, transform.position.z) * 5 * Time.deltaTime;
		}

	}
	*/
}
