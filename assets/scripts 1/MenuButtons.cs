using UnityEngine;
using System.Collections;

public class MenuButtons : MonoBehaviour {
	
	public bool isQuitButton = false;
	
	void OnMouseEnter()
		
	{
		
		renderer.material.color = Color.red; 
		
	}
	
	void OnMouseExit()
		
	{ renderer.material.color = Color.white; 
		
	}
	
	void OnMouseUp()
	{
		//Are We Dealing With A Quit Button
		if( isQuitButton )
		{
			//QuitTheGame
			Application.Quit();
		}
		else
		{
			//LoadTheGame
			Application.LoadLevel("Test_akademik");
		}
	}
}
