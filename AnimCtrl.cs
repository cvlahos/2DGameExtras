using UnityEngine;
using System.Collections;

public class AnimCtrl : MonoBehaviour 
{
	public Animator animatorForPaddle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown(KeyCode.LeftArrow)) 
		{

			animatorForPaddle.Play ("fancyLeft");

		}
	
	
		if (Input.GetKeyDown(KeyCode.RightArrow)) 
		{
			animatorForPaddle.Play ("fancyRight");
		}
	
	}
}
