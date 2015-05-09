using UnityEngine;
using System.Collections;

public class SceneLoad : MonoBehaviour {

	public string level;
	public float xPosition;
	public float yPosition;
	public float zPosition;
	public float xScale;
	public float yScale;
	public float zScale;


	

	void OnCollisionEnter(Collision coll)
	{
		if (coll.collider.tag == "Player") { //coll.gameObject.tag == "Player"
			DontDestroyOnLoad(coll.transform);
			coll.transform.position = new Vector3(xPosition, yPosition, zPosition);
			coll.transform.localScale = new Vector3(xScale, yScale, zScale);
			Application.LoadLevel(level);
		}
	}

}
