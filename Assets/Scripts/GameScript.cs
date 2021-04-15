using UnityEngine;
using UnityEngine.Video;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour {

	private int totalBlueInHouse,totalRedInHouse,totalGreenInHouse,totalYellowInHouse;
	public Canvas PanelVideo;

	public GameObject frameRed,frameGreen, frameBlue, frameYellow;

	public GameObject redPlayerI_Border,greenPlayerI_Border,bluePlayerI_Border,yellowPlayerI_Border;

	public Vector3 redPlayerI_Pos,greenPlayerI_Pos,bluePlayerI_Pos,yellowPlayerI_Pos;

	public Button RedPlayerI_Button,GreenPlayerI_Button,BluePlayerI_Button,YellowPlayerI_Button;

	public GameObject blueScreen, greenScreen, redScreen, yellowScreen;
	public Text blueRankText, greenRankText, redRankText, yellowRankText;

	private string playerTurn = "RED";
	public Transform diceRoll;
	public Button DiceRollButton;
	public Transform redDiceRollPos, greenDiceRollPos, blueDiceRollPos, yellowDiceRollPos;

	private string currentPlayer = "none";
	private string currentPlayerName = "none";

	public GameObject redPlayerI,greenPlayerI,bluePlayerI,yellowPlayerI;

	private int redPlayerI_Steps,greenPlayerI_Steps,bluePlayerI_Steps,yellowPlayerI_Steps;
	//selection of dice numbers animation...
	private int selectDiceNumAnimation;

	//--------------- Dice Animations------
	public GameObject dice1_Roll_Animation,dice2_Roll_Animation,dice3_Roll_Animation,dice4_Roll_Animation,dice5_Roll_Animation,dice6_Roll_Animation;

	// Players movement corenspoding to blocks...
	public List<GameObject> redMovementBlocks = new List<GameObject>();
	public List<GameObject> greenMovementBlocks = new List<GameObject>();
	public List<GameObject> yellowMovementBlocks = new List<GameObject>();
	public List<GameObject> blueMovementBlocks = new List<GameObject>();

	// Random generation of dice numbers...
	private System.Random randomNo;
	public GameObject confirmScreen,gameCompletedScreen;

	//===== UI Button ===================
	public void yesGameCompleted()
	{
		SoundManagerScript.buttonAudioSource.Play ();
		SceneManager.LoadScene ("Game");
	}

	public void noGameCompleted()
	{
		SoundManagerScript.buttonAudioSource.Play ();
		SceneManager.LoadScene ("Main Menu");
	}

	public void yesMethod()
	{
		SoundManagerScript.buttonAudioSource.Play ();
		SceneManager.LoadScene ("Main Menu");
	}

	public void noMethod()
	{
		SoundManagerScript.buttonAudioSource.Play ();
		confirmScreen.SetActive (false);
	}

	public void ExitMethod()
	{
		SoundManagerScript.buttonAudioSource.Play ();
		confirmScreen.SetActive (true);
	}
	// -============== GAME COMPLETED ROUTINE ==========================================================
	IEnumerator GameCompletedRoutine()
	{
		yield return new WaitForSeconds (1.5f);
		gameCompletedScreen.SetActive (true);
	}

	// =================== ROLL DICE RESULT ============================================================

	// DICE Initialization after players have finished their turn---------------
	void InitializeDice ()
	{
		DiceRollButton.interactable = true;

		dice1_Roll_Animation.SetActive (false);
		dice2_Roll_Animation.SetActive (false);
		dice3_Roll_Animation.SetActive (false);
		dice4_Roll_Animation.SetActive (false);
		dice5_Roll_Animation.SetActive (false);
		dice6_Roll_Animation.SetActive (false);	

		//================= CHECKING PLAYERS WHO WINS SURING GAMEPLAY===================================

		switch (MainMenuScript.howManyPlayers) {
		case 2:
			if (totalRedInHouse > 0) {
				SoundManagerScript.winAudioSource.Play ();
				redScreen.SetActive (true);					
				StartCoroutine ("GameCompletedRoutine");
				playerTurn = "NONE";
			}

			if (totalGreenInHouse > 0) {
				SoundManagerScript.winAudioSource.Play ();
				greenScreen.SetActive (true);
				StartCoroutine ("GameCompletedRoutine");
				playerTurn = "NONE";
			}
			break;

		case 3:
				// If any 1 of 3 player wins==============================================
			if (totalRedInHouse > 0 && totalBlueInHouse < 1 && totalYellowInHouse < 1 && playerTurn == "RED") {
				if (!redScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}

				redScreen.SetActive (true);
				Debug.Log ("Red Player WON");
				playerTurn = "BLUE";
			}

			if (totalBlueInHouse > 0 && totalRedInHouse < 1 && totalYellowInHouse < 1 && playerTurn == "BLUE") {
				if (!blueScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				blueScreen.SetActive (true);
				Debug.Log ("Blue Player WON");
				playerTurn = "YELLOW";
			}

			if (totalYellowInHouse > 0 && totalRedInHouse < 1 && totalBlueInHouse < 1 && playerTurn == "YELLOW") {
				if (!redScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				yellowScreen.SetActive (true);
				Debug.Log ("Yellow Player WON");
				playerTurn = "RED";				
			}
				// If any 2 of 3 player wins============================================== 
			if (totalRedInHouse > 0 && totalBlueInHouse > 0 && totalYellowInHouse < 1) {
				if (!redScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				if (!blueScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				redScreen.SetActive (true);
				blueScreen.SetActive (true);
				StartCoroutine ("GameCompletedRoutine");
				Debug.Log ("GAME ENDED");	
				playerTurn = "NONE";
			}

			if (totalBlueInHouse > 0 && totalYellowInHouse > 0 && totalRedInHouse < 1) {
				if (!blueScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				if (!yellowScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				yellowScreen.SetActive (true);
				blueScreen.SetActive (true);
				StartCoroutine ("GameCompletedRoutine");
				Debug.Log ("GAME ENDED");	
				playerTurn = "NONE";
			}

			if (totalYellowInHouse > 0 && totalRedInHouse > 0 && totalBlueInHouse < 1) {
				if (!yellowScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				if (!redScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				redScreen.SetActive (true);
				yellowScreen.SetActive (true);
				StartCoroutine ("GameCompletedRoutine");
				Debug.Log ("GAME ENDED");	
				playerTurn = "NONE";
			}
				
			break;

		case 4:
				// If any 1 of 4 player wins=======================================================================
			if (totalRedInHouse > 0 && totalBlueInHouse < 1 && totalGreenInHouse < 1 && totalYellowInHouse < 1 && playerTurn == "RED") {
				if (!redScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}

				redScreen.SetActive (true);					
				Debug.Log ("Red Player WON");
				playerTurn = "BLUE";
			}

			if (totalBlueInHouse > 0 && totalRedInHouse < 1 && totalGreenInHouse < 1 && totalYellowInHouse < 1 && playerTurn == "BLUE") {
				if (!blueScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				blueScreen.SetActive (true);
				Debug.Log ("Blue Player WON");
				playerTurn = "GREEN";
			}

			if (totalGreenInHouse > 0 && totalRedInHouse < 1 && totalBlueInHouse < 1 && totalYellowInHouse < 1 && playerTurn == "GREEN") {
				if (!greenScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				greenScreen.SetActive (true);					
				Debug.Log ("Green Player WON");
				playerTurn = "YELLOW";
			}

			if (totalYellowInHouse > 0 && totalRedInHouse < 1 && totalBlueInHouse < 1 && totalGreenInHouse < 1 && playerTurn == "YELLOW") {
				if (!yellowScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				yellowScreen.SetActive (true);					
				Debug.Log ("Yellow Player WON");
				playerTurn = "RED";				
			}
				// If any 2 of 4 player wins=======================================================================
			if (totalRedInHouse > 0 && totalBlueInHouse > 0 && totalGreenInHouse < 1 && totalYellowInHouse < 1 && (playerTurn == "RED" || playerTurn == "BLUE")) {	
				if (!redScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				if (!blueScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				redScreen.SetActive (true);
				blueScreen.SetActive (true);
				Debug.Log ("RED & BLUE - ALREADY WON");
				playerTurn = "GREEN";
			}

			if (totalBlueInHouse > 0 && totalGreenInHouse > 0 && totalRedInHouse < 1 && totalYellowInHouse < 1 && (playerTurn == "BLUE" || playerTurn == "GREEN")) {		
				if (!blueScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				if (!greenScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}	
				blueScreen.SetActive (true);
				greenScreen.SetActive (true);
				Debug.Log ("GREEN & BLUE - ALREADY WON");
				playerTurn = "YELLOW";
			}

			if (totalGreenInHouse > 0 && totalYellowInHouse > 0 && totalBlueInHouse < 1 && totalRedInHouse < 1 && (playerTurn == "GREEN" || playerTurn == "YELLOW")) {		
				if (!greenScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				if (!yellowScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				greenScreen.SetActive (true);
				yellowScreen.SetActive (true);
				Debug.Log ("GREEN & YELLOW - ALREADY WON");
				playerTurn = "RED";
			}

			if (totalYellowInHouse > 0 && totalRedInHouse > 0 && totalBlueInHouse < 1 && totalGreenInHouse < 1 && (playerTurn == "YELLOW" || playerTurn == "RED")) {		
				if (!redScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				if (!yellowScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				redScreen.SetActive (true);
				yellowScreen.SetActive (true);
				Debug.Log ("YELLOW & RED - ALREADY WON");	
				playerTurn = "BLUE";				
			}

				//	Diagonally----Red Vs Green ... Yellow Vs Blue winning
			if (totalYellowInHouse > 0 && totalBlueInHouse > 0 && totalRedInHouse < 1 && totalGreenInHouse < 1 && (playerTurn == "YELLOW" || playerTurn == "BLUE")) {
				if (!yellowScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				if (!blueScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				yellowScreen.SetActive (true);
				blueScreen.SetActive (true);
				Debug.Log ("BLUE & YELLOW - ALREADY WON");					
					
				if (playerTurn == "BLUE") {
					playerTurn = "GREEN";
				} else {
					if (playerTurn == "YELLOW") {
						playerTurn = "RED";
					} 
				}
			}
			if (totalRedInHouse > 0 && totalGreenInHouse > 0 && totalYellowInHouse < 1 && totalBlueInHouse < 1 && (playerTurn == "RED" || playerTurn == "GREEN")) {
				if (!redScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				if (!greenScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				redScreen.SetActive (true);
				greenScreen.SetActive (true);
				Debug.Log ("RED & GREEN - ALREADY WON");					
					
				if (playerTurn == "RED") {
					playerTurn = "BLUE";
				} else {
					if (playerTurn == "GREEN") {
						playerTurn = "YELLOW";
					} 
				}
			}
			if (totalRedInHouse > 0 && totalGreenInHouse > 0 && totalBlueInHouse > 0 && totalYellowInHouse < 1) {
				if (!redScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				if (!greenScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				if (!blueScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				redScreen.SetActive (true);
				greenScreen.SetActive (true);
				blueScreen.SetActive (true);
				StartCoroutine ("GameCompletedRoutine");
				playerTurn = "NONE";
			}

			if (totalRedInHouse > 0 && totalGreenInHouse > 0 && totalYellowInHouse > 0 && totalBlueInHouse < 1) {
				if (!redScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				if (!greenScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				if (!yellowScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				redScreen.SetActive (true);
				greenScreen.SetActive (true);
				yellowScreen.SetActive (true);
				StartCoroutine ("GameCompletedRoutine");
				playerTurn = "NONE";
			}

			if (totalBlueInHouse > 0 && totalGreenInHouse > 0 && totalYellowInHouse > 0 && totalRedInHouse < 1) {
				if (!blueScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				if (!greenScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				if (!yellowScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				blueScreen.SetActive (true);
				greenScreen.SetActive (true);
				yellowScreen.SetActive (true);
				StartCoroutine ("GameCompletedRoutine");
				playerTurn = "NONE";
			}

			if (totalBlueInHouse > 0 && totalRedInHouse > 0 && totalYellowInHouse > 0 && totalGreenInHouse < 1) {
				if (!blueScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				if (!redScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				if (!yellowScreen.activeInHierarchy) {
					SoundManagerScript.winAudioSource.Play ();
				}
				blueScreen.SetActive (true);
				redScreen.SetActive (true);
				yellowScreen.SetActive (true);
				StartCoroutine ("GameCompletedRoutine");
				playerTurn = "NONE";
			}
			break;
		}
		/////////////////////////////////////////////////////////////////////////////////////////////////////
		/// //////////////////////////////////////////////////////////////////////////////////////////////////////
		/// /////////////////////////////////////////////////////////////////////////////////////
		//======== Getting currentPlayer VALUE=======
		if (currentPlayerName.Contains ("RED PLAYER")) {
			if (currentPlayerName == "RED PLAYER I") {
				Debug.Log ("currentPlayerName = " + currentPlayerName);
				currentPlayer = RedPlayerI_Script.redPlayerI_ColName;
			}

		}

		if (currentPlayerName.Contains ("BLUE PLAYER")) {
			if (currentPlayerName == "BLUE PLAYER I")
				currentPlayer = BluePlayerI_Script.bluePlayerI_ColName;
			
		}

		if (currentPlayerName.Contains ("GREEN PLAYER")) {
			if (currentPlayerName == "GREEN PLAYER I") {
				Debug.Log ("currentPlayerName = " + currentPlayerName);
				currentPlayer = GreenPlayerI_Script.greenPlayerI_ColName;
			}

		}

		if (currentPlayerName.Contains ("YELLOW PLAYER")) {
			if (currentPlayerName == "YELLOW PLAYER I")
				currentPlayer = YellowPlayerI_Script.yellowPlayerI_ColName;
			
		}
			

		//================== Player Home=========================================================
		if (currentPlayerName != "none") {
			switch (MainMenuScript.howManyPlayers) {
			case 2:
				if (currentPlayerName.Contains ("RED PLAYER")) {
					if (currentPlayer == RedPlayerI_Script.redPlayerI_ColName && (currentPlayer == "Home" && RedPlayerI_Script.redPlayerI_ColName == "Home")) {
						SoundManagerScript.dismissalAudioSource.Play ();
						redPlayerI.transform.position = redPlayerI_Pos;
						RedPlayerI_Script.redPlayerI_ColName = "none";
						redPlayerI_Steps = 0;
						playerTurn = "GREEN";
					}
						
					} 
				if (currentPlayerName.Contains ("GREEN PLAYER")) {
					if (currentPlayer == GreenPlayerI_Script.greenPlayerI_ColName && (currentPlayer == "Home" && GreenPlayerI_Script.greenPlayerI_ColName == "Home")) {
						SoundManagerScript.dismissalAudioSource.Play ();
						greenPlayerI.transform.position = greenPlayerI_Pos;
						GreenPlayerI_Script.greenPlayerI_ColName = "none";
						greenPlayerI_Steps = 0;
						playerTurn = "RED";
					
					}
					

					}
				break;

			case 3:
				if (currentPlayerName.Contains ("RED PLAYER")) {
					if (currentPlayer == RedPlayerI_Script.redPlayerI_ColName && (currentPlayer == "Home" && RedPlayerI_Script.redPlayerI_ColName == "Home")) {
						SoundManagerScript.dismissalAudioSource.Play ();
						redPlayerI.transform.position = redPlayerI_Pos;
						RedPlayerI_Script.redPlayerI_ColName = "none";
						redPlayerI_Steps = 0;
						playerTurn = "YELLOW";
					}

				}

				if (currentPlayerName.Contains ("YELLOW PLAYER")) {
					if (currentPlayer == YellowPlayerI_Script.yellowPlayerI_ColName && (currentPlayer == "Home" && YellowPlayerI_Script.yellowPlayerI_ColName == "Home")) {
						SoundManagerScript.dismissalAudioSource.Play ();
						redPlayerI.transform.position = redPlayerI_Pos;
						YellowPlayerI_Script.yellowPlayerI_ColName = "none";
						yellowPlayerI_Steps = 0;
						playerTurn = "BLUE";
					}
				
				}

				if (currentPlayerName.Contains ("BLUE PLAYER")) {
					if (currentPlayer == BluePlayerI_Script.bluePlayerI_ColName && (currentPlayer != "Home" && BluePlayerI_Script.bluePlayerI_ColName != "Home")) {
						SoundManagerScript.dismissalAudioSource.Play ();
						bluePlayerI.transform.position = redPlayerI_Pos;
						BluePlayerI_Script.bluePlayerI_ColName = "none";
						bluePlayerI_Steps = 0;
						playerTurn = "RED";
					}
				 
				 
				}
				break;

					
				}
			}
		////////////////////////////////////////
			
			switch (MainMenuScript.howManyPlayers) {
			case 2:
				if (playerTurn == "RED") {
					diceRoll.position = redDiceRollPos.position;

					frameRed.SetActive (true);
					frameGreen.SetActive (false);
					frameBlue.SetActive (false);
					frameYellow.SetActive (false);					
				}
				if (playerTurn == "GREEN") {
					diceRoll.position = greenDiceRollPos.position;

					frameRed.SetActive (false);
					frameGreen.SetActive (true);
					frameBlue.SetActive (false);
					frameYellow.SetActive (false);					
				}	

				GreenPlayerI_Button.interactable = false;
				RedPlayerI_Button.interactable = false;
				 
				//=============ANIMATED ROUND BORDER=======
				redPlayerI_Border.SetActive (false);
				greenPlayerI_Border.SetActive (false);
			 
				//======================================
				break;

			case 3:
				if (playerTurn == "RED") {
					diceRoll.position = redDiceRollPos.position;

					frameRed.SetActive (true);
					frameGreen.SetActive (false);
					frameBlue.SetActive (false);
					frameYellow.SetActive (false);					
				}
				if (playerTurn == "YELLOW") {
					diceRoll.position = yellowDiceRollPos.position;

					frameRed.SetActive (false);
					frameGreen.SetActive (false);
					frameBlue.SetActive (false);
					frameYellow.SetActive (true);					
				}
				if (playerTurn == "BLUE") {
					diceRoll.position = blueDiceRollPos.position;

					frameRed.SetActive (false);
					frameGreen.SetActive (false);
					frameBlue.SetActive (true);
					frameYellow.SetActive (false);					
				}		

				RedPlayerI_Button.interactable = false;
				YellowPlayerI_Button.interactable = false;
				BluePlayerI_Button.interactable = false;
			 
				//=============ANIMATED ROUND BORDER==================================================================
				redPlayerI_Border.SetActive (false);
				yellowPlayerI_Border.SetActive (false);
				bluePlayerI_Border.SetActive (false);
			 				
				//======================================
				break;

			case 4:
				if (playerTurn == "RED") {
					diceRoll.position = redDiceRollPos.position;

					frameRed.SetActive (true);
					frameGreen.SetActive (false);
					frameBlue.SetActive (false);
					frameYellow.SetActive (false);					
				}
				if (playerTurn == "GREEN") {
					diceRoll.position = greenDiceRollPos.position;

					frameRed.SetActive (false);
					frameGreen.SetActive (true);
					frameBlue.SetActive (false);
					frameYellow.SetActive (false);					
				}
				if (playerTurn == "BLUE") {
					diceRoll.position = blueDiceRollPos.position;

					frameRed.SetActive (false);
					frameGreen.SetActive (false);
					frameBlue.SetActive (true);
					frameYellow.SetActive (false);					
				}
				if (playerTurn == "YELLOW") {
					diceRoll.position = yellowDiceRollPos.position;

					frameRed.SetActive (false);
					frameGreen.SetActive (false);
					frameBlue.SetActive (false);
					frameYellow.SetActive (true);					
				}
				RedPlayerI_Button.interactable = false;
				GreenPlayerI_Button.interactable = false;
				BluePlayerI_Button.interactable = false;
				YellowPlayerI_Button.interactable = false;
			 
				//=============ANIMATED ROUND BORDER==================================================================					
				redPlayerI_Border.SetActive (false);			 
				yellowPlayerI_Border.SetActive (false);
				bluePlayerI_Border.SetActive (false);
				greenPlayerI_Border.SetActive (false);
		
				//======================================
				break;
			}

			selectDiceNumAnimation = 0;

	}

	// Click on Roll Button on Dice UI
	public void DiceRoll()
	{
		SoundManagerScript.diceAudioSource.Play ();
		DiceRollButton.interactable = false;

		selectDiceNumAnimation = randomNo.Next (1,7);

		switch (selectDiceNumAnimation) 
		{
			case 1:
				dice1_Roll_Animation.SetActive (true);
				dice2_Roll_Animation.SetActive (false);
				dice3_Roll_Animation.SetActive (false);
				dice4_Roll_Animation.SetActive (false);
				dice5_Roll_Animation.SetActive (false);
				dice6_Roll_Animation.SetActive (false);
				break;

			case 2:
				dice1_Roll_Animation.SetActive (false);
				dice2_Roll_Animation.SetActive (true);
				dice3_Roll_Animation.SetActive (false);
				dice4_Roll_Animation.SetActive (false);
				dice5_Roll_Animation.SetActive (false);
				dice6_Roll_Animation.SetActive (false);
				break;

			case 3:
				dice1_Roll_Animation.SetActive (false);
				dice2_Roll_Animation.SetActive (false);
				dice3_Roll_Animation.SetActive (true);
				dice4_Roll_Animation.SetActive (false);
				dice5_Roll_Animation.SetActive (false);
				dice6_Roll_Animation.SetActive (false);
				break;

			case 4:
				dice1_Roll_Animation.SetActive (false);
				dice2_Roll_Animation.SetActive (false);
				dice3_Roll_Animation.SetActive (false);
				dice4_Roll_Animation.SetActive (true);
				dice5_Roll_Animation.SetActive (false);
				dice6_Roll_Animation.SetActive (false);
				break;

			case 5:
				dice1_Roll_Animation.SetActive (false);
				dice2_Roll_Animation.SetActive (false);
				dice3_Roll_Animation.SetActive (false);
				dice4_Roll_Animation.SetActive (false);
				dice5_Roll_Animation.SetActive (true);
				dice6_Roll_Animation.SetActive (false);
				break;

			case 6:
				dice1_Roll_Animation.SetActive (false);
				dice2_Roll_Animation.SetActive (false);
				dice3_Roll_Animation.SetActive (false);
				dice4_Roll_Animation.SetActive (false);
				dice5_Roll_Animation.SetActive (false);
				dice6_Roll_Animation.SetActive (true);
				break;
		}

		StartCoroutine ("PlayersNotInitialized");
	}

	IEnumerator PlayersNotInitialized()
	{
		yield return new WaitForSeconds (0.8f);
		// Game Start Initial position of each player (Red, Green, Blue, Yellow)
		switch(playerTurn)
		{
		case "RED": 	

			//==================== CONDITION FOR BORDER GLOW ========================
			if ((redMovementBlocks.Count - redPlayerI_Steps) >= selectDiceNumAnimation && redPlayerI_Steps > 0 && (redMovementBlocks.Count > redPlayerI_Steps)) {
				redPlayerI_Border.SetActive (true);
				RedPlayerI_Button.interactable = true;
			} else {
				redPlayerI_Border.SetActive (false);
				RedPlayerI_Button.interactable = false;
			}

		
			//========================= PLAYERS BORDER GLOW WHEN OPENING ===========================================

			if (selectDiceNumAnimation == 6 && redPlayerI_Steps == 0) {
				redPlayerI_Border.SetActive (true);
				RedPlayerI_Button.interactable = true;
			}

			//====================== PLAYERS DON'T HAVE ANY MOVES ,SWITCH TO NEXT TURN===============================
			if (!redPlayerI_Border.activeInHierarchy) 
			{
				RedPlayerI_Button.interactable = false;

				switch (MainMenuScript.howManyPlayers) {
				case 2:
					playerTurn = "GREEN";
					InitializeDice ();
					break;

				case 3:
					playerTurn = "BLUE";
					InitializeDice ();
					break;

				case 4:
					playerTurn = "BLUE";
					InitializeDice ();
					break;
				}
			}
			break;

		case "BLUE":			
			
			//==================== CONDITION FOR BORDER GLOW ========================
			if ((blueMovementBlocks.Count - bluePlayerI_Steps) >= selectDiceNumAnimation && bluePlayerI_Steps > 0 && (blueMovementBlocks.Count > bluePlayerI_Steps)) 
			{
				bluePlayerI_Border.SetActive (true);
				BluePlayerI_Button.interactable = true;
			} 
			else 
			{
				bluePlayerI_Border.SetActive (false);
				BluePlayerI_Button.interactable = false;
			}


			//=======================================================================================================
			if (selectDiceNumAnimation == 6 && bluePlayerI_Steps == 0) 
			{
				bluePlayerI_Border.SetActive (true);
				BluePlayerI_Button.interactable = true;
			}

			//====================== PLAYERS DON'T HAVE ANY MOVES ,SWITCH TO NEXT TURN===============================
			if (!bluePlayerI_Border.activeInHierarchy ) 
			{
				BluePlayerI_Button.interactable = false;
		 

				switch (MainMenuScript.howManyPlayers) {
				case 2:
					//BLUE PLAYER NOT AVAILABLE
					break;

				case 3:
					playerTurn = "YELLOW";
					InitializeDice ();
					break;

				case 4:
					playerTurn = "GREEN";
					InitializeDice ();
					break;
				}
			}
			break;

		case "GREEN":

			//==================== CONDITION FOR BORDER GLOW ========================
			if ((greenMovementBlocks.Count - greenPlayerI_Steps) >= selectDiceNumAnimation && greenPlayerI_Steps > 0 && (greenMovementBlocks.Count > greenPlayerI_Steps)) 
			{
				greenPlayerI_Border.SetActive (true);
				GreenPlayerI_Button.interactable = true;
			} 
			else 
			{
				greenPlayerI_Border.SetActive (false);
				GreenPlayerI_Button.interactable = false;
			}


			//=======================================================================================================

			if (selectDiceNumAnimation == 6 && greenPlayerI_Steps == 0) 
			{
				greenPlayerI_Border.SetActive (true);
				GreenPlayerI_Button.interactable = true;
			}
		 
			//====================== PLAYERS DON'T HAVE ANY MOVES ,SWITCH TO NEXT TURN===============================
			if (!greenPlayerI_Border.activeInHierarchy ) 
			{
				GreenPlayerI_Button.interactable = false;
				 

				switch (MainMenuScript.howManyPlayers) {
				case 2:
					playerTurn = "RED";
					InitializeDice ();
					break;

				case 3:
					//GREEN PLAYER IS NOT AVAILABLE
					break;

				case 4:
					playerTurn = "YELLOW";
					InitializeDice ();
					break;
				}
			}
			break;

		case "YELLOW":

			//==================== CONDITION FOR BORDER GLOW ========================
			if ((yellowMovementBlocks.Count - yellowPlayerI_Steps) >= selectDiceNumAnimation && yellowPlayerI_Steps > 0 && (yellowMovementBlocks.Count > yellowPlayerI_Steps)) 
			{
				yellowPlayerI_Border.SetActive (true);
				YellowPlayerI_Button.interactable = true;
			} 
			else 
			{
				yellowPlayerI_Border.SetActive (false);
				YellowPlayerI_Button.interactable = false;
			}

		
			//=======================================================================================================

			if (selectDiceNumAnimation == 6 && yellowPlayerI_Steps == 0) 
			{
				yellowPlayerI_Border.SetActive (true);
				YellowPlayerI_Button.interactable = true;
			}

			//====================== PLAYERS DON'T HAVE ANY MOVES ,SWITCH TO NEXT TURN===============================
			if (!yellowPlayerI_Border.activeInHierarchy) 
			{
				YellowPlayerI_Button.interactable = false;


				switch (MainMenuScript.howManyPlayers) {
				case 2:
					//yellow PLAYER NOT AVAILABLE
					break;

				case 3:
					playerTurn = "RED";
					InitializeDice ();
					break;

				case 4:
					playerTurn = "RED";
					InitializeDice ();
					break;
				}
			}
			break;
		}
	}

	//=============================== RED PLAYERS MOVEMENT ===========================================================

	public void redPlayerI_UI()
	{
		SoundManagerScript.playerAudioSource.Play ();
		redPlayerI_Border.SetActive (false);
	

		RedPlayerI_Button.interactable = false;
	

		if (playerTurn == "RED" && (redMovementBlocks.Count - redPlayerI_Steps) > selectDiceNumAnimation) // 4 > 4
		{
			if (redPlayerI_Steps > 0) 
			{
				Vector3[] redPlayer_Path = new Vector3[selectDiceNumAnimation];

				for (int i = 0; i < selectDiceNumAnimation; i++) 
				{
					redPlayer_Path [i] = redMovementBlocks [redPlayerI_Steps + i].transform.position;
				}

				redPlayerI_Steps += selectDiceNumAnimation;			



	

				if (selectDiceNumAnimation == 6) 
				{
					playerTurn = "RED";
				} 
				else 
				{
					switch (MainMenuScript.howManyPlayers) 
					{
					case 2:
						playerTurn = "GREEN";
						break;

					case 3:
						playerTurn = "BLUE";
						break;
					
					case 4:
						playerTurn = "BLUE";
						break;
					}
				}

				//currentPlayer = RedPlayerI_Script.redPlayerI_ColName;
				currentPlayerName = "RED PLAYER I";

				//if(redPlayerI_Steps + selectDiceNumAnimation == redMovementBlocks.Count)
				if (redPlayer_Path.Length > 1) 
				{
					//redPlayerI.transform.DOPath (redPlayer_Path, 2.0f, PathType.Linear, PathMode.Full3D, 10, Color.red);
					iTween.MoveTo (redPlayerI, iTween.Hash ("path", redPlayer_Path, "speed", 125,"time",2.0f, "easetype", "elastic", "looptype", "none", "oncomplete", "InitializeDice", "oncompletetarget", this.gameObject));
				} 
				else 
				{
					iTween.MoveTo (redPlayerI, iTween.Hash ("position", redPlayer_Path [0], "speed", 125,"time",2.0f, "easetype", "elastic", "looptype", "none", "oncomplete", "InitializeDice", "oncompletetarget", this.gameObject));
				}
			} 
			else 
			{
				if (selectDiceNumAnimation == 6 && redPlayerI_Steps == 0) 
				{
					Vector3[] redPlayer_Path = new Vector3[selectDiceNumAnimation];
					redPlayer_Path [0] = redMovementBlocks [redPlayerI_Steps].transform.position;
					redPlayerI_Steps += 1;
					playerTurn = "RED";
					//currentPlayer = RedPlayerI_Script.redPlayerI_ColName;
					currentPlayerName = "RED PLAYER I";
					iTween.MoveTo (redPlayerI, iTween.Hash ("position", redPlayer_Path [0], "speed", 125,"time",2.0f, "easetype", "elastic", "looptype", "none", "oncomplete", "InitializeDice", "oncompletetarget", this.gameObject));
				}
			}
		}
		else
		{
			// Condition when Player Coin is reached successfully in House....(Actual Number of required moves to get into the House)
			if (playerTurn == "RED" && (redMovementBlocks.Count - redPlayerI_Steps) == selectDiceNumAnimation) 
			{
				Vector3[] redPlayer_Path = new Vector3[selectDiceNumAnimation];

				for (int i = 0; i < selectDiceNumAnimation; i++) 
				{
					redPlayer_Path [i] = redMovementBlocks [redPlayerI_Steps + i].transform.position;
				}

				redPlayerI_Steps += selectDiceNumAnimation;

				playerTurn = "RED";

				//redPlayerI_Steps = 0;

				if (redPlayer_Path.Length > 1) 
				{
					iTween.MoveTo (redPlayerI, iTween.Hash ("path", redPlayer_Path, "speed", 125,"time",2.0f, "easetype", "elastic", "looptype", "none", "oncomplete", "InitializeDice", "oncompletetarget", this.gameObject));
				} 
				else 
				{
					iTween.MoveTo (redPlayerI, iTween.Hash ("position", redPlayer_Path [0], "speed", 125,"time",2.0f, "easetype", "elastic", "looptype", "none", "oncomplete", "InitializeDice", "oncompletetarget", this.gameObject));
				}
				totalRedInHouse += 1;
				Debug.Log ("Cool !!");
				RedPlayerI_Button.enabled = false;
			}
			else
			{
				Debug.Log ("You need "+  (redMovementBlocks.Count - redPlayerI_Steps).ToString() + " to enter into the house.");

				if(selectDiceNumAnimation != 6)
				{
					switch (MainMenuScript.howManyPlayers) 
					{
						case 2:
							playerTurn = "GREEN";
							break;

						case 3:
							playerTurn = "BLUE";
							break;

						case 4:
							playerTurn = "BLUE";
							break;
					}
					InitializeDice ();
				}
			}
		}
	}


	//==================================== GREEN PLAYERS MOVEMENT =================================================================

	public void greenPlayerI_UI()
	{		
		SoundManagerScript.playerAudioSource.Play ();
		greenPlayerI_Border.SetActive (false);


		GreenPlayerI_Button.interactable = false;

		if (playerTurn == "GREEN" && (greenMovementBlocks.Count - greenPlayerI_Steps) > selectDiceNumAnimation) 
		{ 
			if (greenPlayerI_Steps > 0) 
			{
				Vector3[] greenPlayer_Path = new Vector3[selectDiceNumAnimation];

				for (int i = 0; i < selectDiceNumAnimation; i++) 
				{
					greenPlayer_Path [i] = greenMovementBlocks [greenPlayerI_Steps + i].transform.position;
				}

				greenPlayerI_Steps += selectDiceNumAnimation;

				if (selectDiceNumAnimation == 6) 
				{
					playerTurn = "GREEN";
				} 
				else 
				{
					switch (MainMenuScript.howManyPlayers) 
					{
					case 2:
						playerTurn = "RED";
						break;

					case 3:
						//player is not available
						break;

					case 4:
						playerTurn = "YELLOW";
						break;
					}
				}

				currentPlayerName = "GREEN PLAYER I";

				if (greenPlayer_Path.Length > 1) 
				{
					iTween.MoveTo (greenPlayerI, iTween.Hash ("path", greenPlayer_Path, "speed", 125,"time",2.0f, "easetype", "elastic", "looptype", "none", "oncomplete", "InitializeDice", "oncompletetarget", this.gameObject));
				} 
				else 
				{
					iTween.MoveTo (greenPlayerI, iTween.Hash ("position", greenPlayer_Path [0], "speed", 125,"time",2.0f, "easetype", "elastic", "looptype", "none", "oncomplete", "InitializeDice", "oncompletetarget", this.gameObject));

				}
			} 
			else 
			{
				if (selectDiceNumAnimation == 6 && greenPlayerI_Steps == 0) 
				{
					Vector3[] greenPlayer_Path = new Vector3[selectDiceNumAnimation];
					greenPlayer_Path [0] = greenMovementBlocks [greenPlayerI_Steps].transform.position;
					greenPlayerI_Steps += 1;
					playerTurn = "GREEN";
					currentPlayerName = "GREEN PLAYER I";
					iTween.MoveTo (greenPlayerI, iTween.Hash ("position", greenPlayer_Path [0], "speed", 125,"time",2.0f, "easetype", "elastic", "looptype", "none", "oncomplete", "InitializeDice", "oncompletetarget", this.gameObject));
				}
			}
		} 
		else 
		{
				// Condition when Player Coin is reached successfully in House....(Actual Number of requigreen moves to get into the House)
			if (playerTurn == "GREEN" && (greenMovementBlocks.Count - greenPlayerI_Steps) == selectDiceNumAnimation) 
			{
				Vector3[] greenPlayer_Path = new Vector3[selectDiceNumAnimation];

				for (int i = 0; i < selectDiceNumAnimation; i++) 
				{
					greenPlayer_Path [i] = greenMovementBlocks [greenPlayerI_Steps + i].transform.position;
				}

				greenPlayerI_Steps += selectDiceNumAnimation;

				playerTurn = "GREEN";
			
				//greenPlayerI_Steps = 0;

				if (greenPlayer_Path.Length > 1) 
				{
					iTween.MoveTo (greenPlayerI, iTween.Hash ("path", greenPlayer_Path, "speed", 125,"time",2.0f, "easetype", "elastic", "looptype", "none", "oncomplete", "InitializeDice", "oncompletetarget", this.gameObject));
				} 
				else 
				{
					iTween.MoveTo (greenPlayerI, iTween.Hash ("position", greenPlayer_Path [0], "speed", 125,"time",2.0f, "easetype", "elastic", "looptype", "none", "oncomplete", "InitializeDice", "oncompletetarget", this.gameObject));
				}

				totalGreenInHouse += 1;
				Debug.Log ("Cool !!");
				GreenPlayerI_Button.enabled = false;
			} 
			else 
			{
				Debug.Log ("You need " + (greenMovementBlocks.Count - greenPlayerI_Steps).ToString () + " to enter into the house.");

				if ( selectDiceNumAnimation != 6) 
				{
					switch (MainMenuScript.howManyPlayers) 
					{
						case 2:
							playerTurn = "RED";
							break;

						case 3:
							//Player is not available
							break;

						case 4:
							playerTurn = "YELLOW";
							break;
					}
					InitializeDice ();
				}
			}
		}
	}


	//===================================== BLUE PLAYERS MOVEMENT =========================================================
	public void bluePlayerI_UI()
	{
		SoundManagerScript.playerAudioSource.Play ();
		bluePlayerI_Border.SetActive (false);


		BluePlayerI_Button.interactable = false;
	

		if (playerTurn == "BLUE" && (blueMovementBlocks.Count - bluePlayerI_Steps) > selectDiceNumAnimation) 
		{ 
			if (bluePlayerI_Steps > 0) 
			{
				Vector3[] bluePlayer_Path = new Vector3[selectDiceNumAnimation];

				for (int i = 0; i < selectDiceNumAnimation; i++) 
				{
					bluePlayer_Path [i] = blueMovementBlocks [bluePlayerI_Steps + i].transform.position;
				}

				bluePlayerI_Steps += selectDiceNumAnimation;

				if (selectDiceNumAnimation == 6) 
				{
					playerTurn = "BLUE";
				} 
				else 
				{
					switch (MainMenuScript.howManyPlayers) 
					{
					case 2:
						//Player is not available
						break;

					case 3:
						playerTurn = "YELLOW";
						break;

					case 4:
						playerTurn = "GREEN";
						break;
					}
				}

				currentPlayerName = "BLUE PLAYER I";

				if (bluePlayer_Path.Length > 1) 
				{
					iTween.MoveTo (bluePlayerI, iTween.Hash ("path", bluePlayer_Path, "speed", 125,"time",2.0f, "easetype", "elastic", "looptype", "none", "oncomplete", "InitializeDice", "oncompletetarget", this.gameObject));
				} 
				else 
				{
					iTween.MoveTo (bluePlayerI, iTween.Hash ("position", bluePlayer_Path [0], "speed", 125,"time",2.0f, "easetype", "elastic", "looptype", "none", "oncomplete", "InitializeDice", "oncompletetarget", this.gameObject));

				}
			} 
			else 
			{
				if (selectDiceNumAnimation == 6 && bluePlayerI_Steps == 0) 
				{
					Vector3[] bluePlayer_Path = new Vector3[selectDiceNumAnimation];
					bluePlayer_Path [0] = blueMovementBlocks [bluePlayerI_Steps].transform.position;
					bluePlayerI_Steps += 1;
					playerTurn = "BLUE";
					currentPlayerName = "BLUE PLAYER I";
					iTween.MoveTo (bluePlayerI, iTween.Hash ("position", bluePlayer_Path [0], "speed", 125,"time",2.0f, "easetype", "elastic", "looptype", "none", "oncomplete", "InitializeDice", "oncompletetarget", this.gameObject));
				}
			}
		} 
		else 
		{
			// Condition when Player Coin is reached successfully in House....(Actual Number of requiblue moves to get into the House)
			if (playerTurn == "BLUE" && (blueMovementBlocks.Count - bluePlayerI_Steps) == selectDiceNumAnimation) 
			{
				Vector3[] bluePlayer_Path = new Vector3[selectDiceNumAnimation];

				for (int i = 0; i < selectDiceNumAnimation; i++) 
				{
					bluePlayer_Path [i] = blueMovementBlocks [bluePlayerI_Steps + i].transform.position;
				}

				bluePlayerI_Steps += selectDiceNumAnimation;

				playerTurn = "BLUE";

				//bluePlayerI_Steps = 0;

				if (bluePlayer_Path.Length > 1) 
				{
					iTween.MoveTo (bluePlayerI, iTween.Hash ("path", bluePlayer_Path, "speed", 125,"time",2.0f, "easetype", "elastic", "looptype", "none", "oncomplete", "InitializeDice", "oncompletetarget", this.gameObject));
				} 
				else 
				{
					iTween.MoveTo (bluePlayerI, iTween.Hash ("position", bluePlayer_Path [0], "speed", 125,"time",2.0f, "easetype", "elastic", "looptype", "none", "oncomplete", "InitializeDice", "oncompletetarget", this.gameObject));
				}

				totalBlueInHouse += 1;
				Debug.Log ("Cool !!");
				BluePlayerI_Button.enabled = false;
			} 
			else 
			{
				Debug.Log ("You need " + (blueMovementBlocks.Count - bluePlayerI_Steps).ToString () + " to enter into the house.");

				if ( selectDiceNumAnimation != 6) 
				{
					switch (MainMenuScript.howManyPlayers) 
					{
					case 2:
						// Player is not available...
						break;

					case 3:
						playerTurn = "YELLOW";
						break;

					case 4:
						playerTurn = "GREEN";
						break;
					}
					InitializeDice ();
				}
			}
		}
	}


	//==================================== YELLOW PLAYERS MOVEMENT =============================================================

	public void yellowPlayerI_UI()
	{
		SoundManagerScript.playerAudioSource.Play ();
		yellowPlayerI_Border.SetActive (false);


		YellowPlayerI_Button.interactable = false;
	

		if (playerTurn == "YELLOW" && (yellowMovementBlocks.Count - yellowPlayerI_Steps) > selectDiceNumAnimation) 
		{ 
			if (yellowPlayerI_Steps > 0) 
			{
				Vector3[] yellowPlayer_Path = new Vector3[selectDiceNumAnimation];

				for (int i = 0; i < selectDiceNumAnimation; i++) 
				{
					yellowPlayer_Path [i] = yellowMovementBlocks [yellowPlayerI_Steps + i].transform.position;
				}

				yellowPlayerI_Steps += selectDiceNumAnimation;

				if (selectDiceNumAnimation == 6) 
				{
					playerTurn = "YELLOW";
				} 
				else 
				{
					switch (MainMenuScript.howManyPlayers) 
					{
					case 2:
						//Player is not available
						break;

					case 3:
						playerTurn = "RED";
						break;

					case 4:
						playerTurn = "RED";
						break;
					}
				}

				currentPlayerName = "YELLOW PLAYER I";

				if (yellowPlayer_Path.Length > 1) 
				{
					iTween.MoveTo (yellowPlayerI, iTween.Hash ("path", yellowPlayer_Path, "speed", 125,"time",2.0f, "easetype", "elastic", "looptype", "none", "oncomplete", "InitializeDice", "oncompletetarget", this.gameObject));
				} 
				else 
				{
					iTween.MoveTo (yellowPlayerI, iTween.Hash ("position", yellowPlayer_Path [0], "speed", 125,"time",2.0f, "easetype", "elastic", "looptype", "none", "oncomplete", "InitializeDice", "oncompletetarget", this.gameObject));

				}
			} 
			else 
			{
				if (selectDiceNumAnimation == 6 && yellowPlayerI_Steps == 0) 
				{
					Vector3[] yellowPlayer_Path = new Vector3[selectDiceNumAnimation];
					yellowPlayer_Path [0] = yellowMovementBlocks [yellowPlayerI_Steps].transform.position;
					yellowPlayerI_Steps += 1;
					playerTurn = "YELLOW";
					currentPlayerName = "YELLOW PLAYER I";
					iTween.MoveTo (yellowPlayerI, iTween.Hash ("position", yellowPlayer_Path [0], "speed", 125,"time",2.0f, "easetype", "elastic", "looptype", "none", "oncomplete", "InitializeDice", "oncompletetarget", this.gameObject));

				}
			}
		} 
		else 
		{
			// Condition when Player Coin is reached successfully in House....(Actual Number of requiyellow moves to get into the House)
			if (playerTurn == "YELLOW" && (yellowMovementBlocks.Count - yellowPlayerI_Steps) == selectDiceNumAnimation) 
			{
				Vector3[] yellowPlayer_Path = new Vector3[selectDiceNumAnimation];

				for (int i = 0; i < selectDiceNumAnimation; i++) 
				{
					yellowPlayer_Path [i] = yellowMovementBlocks [yellowPlayerI_Steps + i].transform.position;
				}

				yellowPlayerI_Steps += selectDiceNumAnimation;

				playerTurn = "YELLOW";

				//yellowPlayerI_Steps = 0;

				if (yellowPlayer_Path.Length > 1) 
				{
					iTween.MoveTo (yellowPlayerI, iTween.Hash ("path", yellowPlayer_Path, "speed", 125,"time",2.0f, "easetype", "elastic", "looptype", "none", "oncomplete", "InitializeDice", "oncompletetarget", this.gameObject));
				} 
				else 
				{
					iTween.MoveTo (yellowPlayerI, iTween.Hash ("position", yellowPlayer_Path [0], "speed", 125,"time",2.0f, "easetype", "elastic", "looptype", "none", "oncomplete", "InitializeDice", "oncompletetarget", this.gameObject));
				}

				totalYellowInHouse += 1;
				Debug.Log ("Cool !!");
				YellowPlayerI_Button.enabled = false;
			} 
			else 
			{
				Debug.Log ("You need " + (yellowMovementBlocks.Count - yellowPlayerI_Steps).ToString () + " to enter into the house.");

				if (selectDiceNumAnimation != 6) 
				{
					switch (MainMenuScript.howManyPlayers) 
					{
					case 2:
						// Player is not available...
						break;

					case 3:
						playerTurn = "RED";
						break;

					case 4:
						playerTurn = "RED";
						break;
					}
					InitializeDice ();
				}
			}
		}
	}


	//=============================================================================================================================
	// Use this for initialization
	void Start () 

	{
		QualitySettings.vSyncCount = 1;
		Application.targetFrameRate = 30;

		randomNo = new System.Random ();

		dice1_Roll_Animation.SetActive (false);
		dice2_Roll_Animation.SetActive (false);
		dice3_Roll_Animation.SetActive (false);
		dice4_Roll_Animation.SetActive (false);
		dice5_Roll_Animation.SetActive (false);
		dice6_Roll_Animation.SetActive (false);

		// Players initial positions.....
		redPlayerI_Pos = redPlayerI.transform.position;
	

		greenPlayerI_Pos = greenPlayerI.transform.position;
		bluePlayerI_Pos = bluePlayerI.transform.position;
		yellowPlayerI_Pos = yellowPlayerI.transform.position;
		redPlayerI_Border.SetActive (false);
		yellowPlayerI_Border.SetActive (false);
		bluePlayerI_Border.SetActive (false);
		greenPlayerI_Border.SetActive (false);
	 

		redScreen.SetActive (false);
		greenScreen.SetActive (false);
		yellowScreen.SetActive (false);
		blueScreen.SetActive (false);

		// Initilaizing players here....
		switch (MainMenuScript.howManyPlayers) 
		{
			case 2:
				playerTurn = "RED";

				frameRed.SetActive (true);
				frameGreen.SetActive (false);
				frameBlue.SetActive (false);
				frameYellow.SetActive (false);
					//diceRoll.position = redDiceRollPos.position;
				bluePlayerI.SetActive (false);
		
				yellowPlayerI.SetActive (false);

				break;

			case 3:
				playerTurn = "YELLOW";

				frameRed.SetActive (false);
				frameGreen.SetActive (false);
				frameBlue.SetActive (false);
				frameYellow.SetActive (true);

				diceRoll.position = yellowDiceRollPos.position;
				greenPlayerI.SetActive (false);
				
				break;

			case 4:
				playerTurn = "RED";

				frameRed.SetActive (true);
				frameGreen.SetActive (false);
				frameBlue.SetActive (false);
				frameYellow.SetActive (false);				

				diceRoll.position = redDiceRollPos.position;
				// keep all players active
				break;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}