using UnityEngine;
using System.Collections;
 
public class CharacterGUI : MonoBehaviour {

	public bool displayCharacterWindow = false;
	private const int CHARACTER_PANEL_ID = 0;
	private Rect characterPanelRect = new Rect(10,10, 500, 500);
	private int CharacterPanel = 0;
	private string[] characterPanelNames = new string[]{"Inventory"};



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		if (displayCharacterWindow)
			characterPanelRect = GUI.Window (CHARACTER_PANEL_ID, characterPanelRect, characterWindow, " Frankie ");
		}

	public void characterWindow(int id){
			CharacterPanel = GUI.Toolbar(new Rect( 5, 25, characterPanelRect.width-10, 50 ), CharacterPanel, characterPanelNames);
			switch(CharacterPanel){
				case 0:
					DisplayInventory();
					break;
			}
				 

	}

	private void DisplayInventory(){
		// Debug.Log ("Inventory");
		GUI.Box(new Rect(5, 120, 100, 46), "Fabular");
		GUI.Box(new Rect(5, 190, 100, 46), "Drinks");
		GUI.Box(new Rect(5, 260, 100, 46), "Food");

	}

}
