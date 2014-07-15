using UnityEngine;
using System.Collections;
 
public class CharacterGUI : MonoBehaviour {

	//BUTTON VARIABLES

	public float buttonWidth = 60;
	public float buttonHeight = 60;
	private int inventoryRows = 6;
	private int inventoryColumns = 6;

	//CHARACTER PANEL VARIABLES

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
		if(Input.GetKey(KeyCode.C)){
			displayCharacterWindow = !displayCharacterWindow;
		}
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
		for(int y = 0; y < inventoryRows; y++){
			for(int x = 0; x < inventoryColumns; x++){
				GUI.Button(new Rect(50 + (x*buttonWidth), 100 + (y*buttonHeight), buttonWidth - 15, buttonHeight - 15),(x + y*inventoryColumns).ToString());
			}
		}
	}

}
