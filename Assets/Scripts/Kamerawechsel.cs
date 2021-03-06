using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamerawechsel : MonoBehaviour {

	public Camera[] cameras;
	private int currentIndex = 1;
	private int count = 0;
	private bool mapOn = false;

	void Start () 
	{
		count = cameras.Length;
		Switch(1);
	}
	
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.C)) 
		{
			currentIndex++;

			if (currentIndex >= 3)
			{
				currentIndex = 1;
			}
			Switch(currentIndex);
				
		}
		if (Input.GetKeyDown (KeyCode.Y)) 
		{
			currentIndex--;

			if (currentIndex < 0)
			{
				currentIndex = 1;
			}
			Switch(currentIndex);

		}		
		if (Input.GetKeyDown (KeyCode.M)) 
		{
			if (mapOn == false) 
			{
				Switch(3);
				mapOn = true;
			} else 
			{
				Switch(1);
				mapOn = false;
			}
		}
	}
	void Switch(int activeIndex)
	{
		for (int i = 0; i < count; i++) 
		{
			if (i != activeIndex) {
				cameras [i].enabled = false;
			} 
			else 
			{
				cameras [i].enabled = true;
			}
		}
	}
}
