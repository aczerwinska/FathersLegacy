using UnityEngine;
using System.Collections;

public class SceneLoad : MonoBehaviour {

	public string level;
	
	void OnCollisionEnter(Collision coll)
	{
		if(coll.gameObject.tag == "Player")
			Application.LoadLevel(level);
	}

}
