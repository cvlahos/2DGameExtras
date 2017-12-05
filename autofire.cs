using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFire : MonoBehaviour
{
	public float timeAtLastShot = 0f; // used for auto_fire option B
	public float timeInbetweenShots; // this is your shot deley variable used in both options  // the higher the number the longer the delay

	float timer; // time is stored in this variable

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer += Time.deltaTime; //// think of time.deltaTime as real world seconds // += adds and assigns at the same time just like-- timer = timer + Time.deltaTime;

		auto_fireA (); // function call

	}
		
	// these are two different functions that do the same thing- pick which one you like best

	void auto_fireA()
	{
		if (Input.GetKey(KeyCode.Space) && (timer >= timeInbetweenShots))
		{
			Debug.Log ("fire");
			timer = 0f; //reset the timer so the if statement above is false - until the timer is greater than or equal to the timeInbetweenShots (shot delay)

		}
	}

	//another option you can use if you understand the logic
	void auto_fireB()
	{
		//Debug.Log (Time.time);
		if (Input.GetKey(KeyCode.Space) && (Time.time - timeAtLastShot) >= timeInbetweenShots)
		{
			Debug.Log ("fire");
			timeAtLastShot = Time.time;

		}

	}


}