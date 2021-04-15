using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace AssemblyCSharp
{
	public class EmptyClass
	{
		private int totalBlueInHouse,totalRedInHouse,totalGreenInHouse,totalYellowInHouse;

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
		public EmptyClass ()
		{
			//================== Player vs Opponent=========================================================
			if (currentPlayerName != "none") {
				switch (MainMenuScript.howManyPlayers) {
				case 2:
					if (currentPlayerName.Contains ("RED PLAYER")) {
						if (currentPlayer == GreenPlayerI_Script.greenPlayerI_ColName && (currentPlayer != "Star" && GreenPlayerI_Script.greenPlayerI_ColName != "Star")) {
							SoundManagerScript.dismissalAudioSource.Play ();
							greenPlayerI.transform.position = greenPlayerI_Pos;
							GreenPlayerI_Script.greenPlayerI_ColName = "none";
							greenPlayerI_Steps = 0;
							playerTurn = "RED";
						}

					} 
					if (currentPlayerName.Contains ("GREEN PLAYER")) {
						if (currentPlayer == RedPlayerI_Script.redPlayerI_ColName && (currentPlayer != "Star" && RedPlayerI_Script.redPlayerI_ColName != "Star")) {
							SoundManagerScript.dismissalAudioSource.Play ();
							redPlayerI.transform.position = redPlayerI_Pos;
							RedPlayerI_Script.redPlayerI_ColName = "none";
							redPlayerI_Steps = 0;
							playerTurn = "GREEN";
						}

					}
					break;

				case 3:
					if (currentPlayerName.Contains ("RED PLAYER")) {
						if (currentPlayer == YellowPlayerI_Script.yellowPlayerI_ColName && (currentPlayer != "Star" && YellowPlayerI_Script.yellowPlayerI_ColName != "Star")) {
							SoundManagerScript.dismissalAudioSource.Play ();
							yellowPlayerI.transform.position = yellowPlayerI_Pos;
							YellowPlayerI_Script.yellowPlayerI_ColName = "none";
							yellowPlayerI_Steps = 0;
							playerTurn = "RED";
						}

						if (currentPlayer == BluePlayerI_Script.bluePlayerI_ColName && (currentPlayer != "Star" && BluePlayerI_Script.bluePlayerI_ColName != "Star")) {
							SoundManagerScript.dismissalAudioSource.Play ();
							bluePlayerI.transform.position = bluePlayerI_Pos;
							BluePlayerI_Script.bluePlayerI_ColName = "none";
							bluePlayerI_Steps = 0;
							playerTurn = "RED";
						}

					}

					if (currentPlayerName.Contains ("YELLOW PLAYER")) {
						if (currentPlayer == RedPlayerI_Script.redPlayerI_ColName && (currentPlayer != "Star" && RedPlayerI_Script.redPlayerI_ColName != "Star")) {
							SoundManagerScript.dismissalAudioSource.Play ();
							redPlayerI.transform.position = redPlayerI_Pos;
							RedPlayerI_Script.redPlayerI_ColName = "none";
							redPlayerI_Steps = 0;
							playerTurn = "YELLOW";
						}

						if (currentPlayer == BluePlayerI_Script.bluePlayerI_ColName && (currentPlayer != "Star" && BluePlayerI_Script.bluePlayerI_ColName != "Star")) {
							SoundManagerScript.dismissalAudioSource.Play ();
							bluePlayerI.transform.position = bluePlayerI_Pos;
							BluePlayerI_Script.bluePlayerI_ColName = "none";
							bluePlayerI_Steps = 0;
							playerTurn = "YELLOW";
						}

					}

					if (currentPlayerName.Contains ("BLUE PLAYER")) {
						if (currentPlayer == RedPlayerI_Script.redPlayerI_ColName && (currentPlayer != "Star" && RedPlayerI_Script.redPlayerI_ColName != "Star")) {
							SoundManagerScript.dismissalAudioSource.Play ();
							redPlayerI.transform.position = redPlayerI_Pos;
							RedPlayerI_Script.redPlayerI_ColName = "none";
							redPlayerI_Steps = 0;
							playerTurn = "BLUE";
						}


						if (currentPlayer == YellowPlayerI_Script.yellowPlayerI_ColName && (currentPlayer != "Star" && YellowPlayerI_Script.yellowPlayerI_ColName != "Star")) {
							SoundManagerScript.dismissalAudioSource.Play ();
							yellowPlayerI.transform.position = yellowPlayerI_Pos;
							YellowPlayerI_Script.yellowPlayerI_ColName = "none";
							yellowPlayerI_Steps = 0;
							playerTurn = "BLUE";
						}

					}
					break;

				case 4:
					if (currentPlayerName.Contains ("RED PLAYER")) {
						if (currentPlayer == GreenPlayerI_Script.greenPlayerI_ColName && (currentPlayer != "Star" && GreenPlayerI_Script.greenPlayerI_ColName != "Star")) {
							SoundManagerScript.dismissalAudioSource.Play ();
							greenPlayerI.transform.position = greenPlayerI_Pos;
							GreenPlayerI_Script.greenPlayerI_ColName = "none";
							greenPlayerI_Steps = 0;
							playerTurn = "RED";
						}


						if (currentPlayer == BluePlayerI_Script.bluePlayerI_ColName && (currentPlayer != "Star" && BluePlayerI_Script.bluePlayerI_ColName != "Star")) {
							SoundManagerScript.dismissalAudioSource.Play ();
							bluePlayerI.transform.position = bluePlayerI_Pos;
							BluePlayerI_Script.bluePlayerI_ColName = "none";
							bluePlayerI_Steps = 0;
							playerTurn = "RED";
						}


						if (currentPlayer == YellowPlayerI_Script.yellowPlayerI_ColName && (currentPlayer != "Star" && YellowPlayerI_Script.yellowPlayerI_ColName != "Star")) {
							SoundManagerScript.dismissalAudioSource.Play ();
							yellowPlayerI.transform.position = yellowPlayerI_Pos;
							YellowPlayerI_Script.yellowPlayerI_ColName = "none";
							yellowPlayerI_Steps = 0;
							playerTurn = "RED";
						}

					}

					if (currentPlayerName.Contains ("GREEN PLAYER")) {
						if (currentPlayer == RedPlayerI_Script.redPlayerI_ColName && (currentPlayer != "Star" && RedPlayerI_Script.redPlayerI_ColName != "Star")) {
							SoundManagerScript.dismissalAudioSource.Play ();
							redPlayerI.transform.position = redPlayerI_Pos;
							RedPlayerI_Script.redPlayerI_ColName = "none";
							redPlayerI_Steps = 0;
							playerTurn = "GREEN";
						}

						if (currentPlayer == BluePlayerI_Script.bluePlayerI_ColName && (currentPlayer != "Star" && BluePlayerI_Script.bluePlayerI_ColName != "Star")) {
							SoundManagerScript.dismissalAudioSource.Play ();
							bluePlayerI.transform.position = bluePlayerI_Pos;
							BluePlayerI_Script.bluePlayerI_ColName = "none";
							bluePlayerI_Steps = 0;
							playerTurn = "GREEN";
						}


						if (currentPlayer == YellowPlayerI_Script.yellowPlayerI_ColName && (currentPlayer != "Star" && YellowPlayerI_Script.yellowPlayerI_ColName != "Star")) {
							SoundManagerScript.dismissalAudioSource.Play ();
							yellowPlayerI.transform.position = yellowPlayerI_Pos;
							YellowPlayerI_Script.yellowPlayerI_ColName = "none";
							yellowPlayerI_Steps = 0;
							playerTurn = "GREEN";
						}

					}

					if (currentPlayerName.Contains ("BLUE PLAYER")) {
						if (currentPlayer == RedPlayerI_Script.redPlayerI_ColName && (currentPlayer != "Star" && RedPlayerI_Script.redPlayerI_ColName != "Star")) {
							SoundManagerScript.dismissalAudioSource.Play ();
							redPlayerI.transform.position = redPlayerI_Pos;
							RedPlayerI_Script.redPlayerI_ColName = "none";
							redPlayerI_Steps = 0;
							playerTurn = "BLUE";
						}


						if (currentPlayer == GreenPlayerI_Script.greenPlayerI_ColName && (currentPlayer != "Star" && GreenPlayerI_Script.greenPlayerI_ColName != "Star")) {
							SoundManagerScript.dismissalAudioSource.Play ();
							greenPlayerI.transform.position = greenPlayerI_Pos;
							GreenPlayerI_Script.greenPlayerI_ColName = "none";
							greenPlayerI_Steps = 0;
							playerTurn = "BLUE";
						}

						if (currentPlayer == YellowPlayerI_Script.yellowPlayerI_ColName && (currentPlayer != "Star" && YellowPlayerI_Script.yellowPlayerI_ColName != "Star")) {
							SoundManagerScript.dismissalAudioSource.Play ();
							yellowPlayerI.transform.position = yellowPlayerI_Pos;
							YellowPlayerI_Script.yellowPlayerI_ColName = "none";
							yellowPlayerI_Steps = 0;
							playerTurn = "BLUE";
						}

					}

					if (currentPlayerName.Contains ("YELLOW PLAYER")) {
						if (currentPlayer == RedPlayerI_Script.redPlayerI_ColName && (currentPlayer != "Star" && RedPlayerI_Script.redPlayerI_ColName != "Star")) {
							SoundManagerScript.dismissalAudioSource.Play ();
							redPlayerI.transform.position = redPlayerI_Pos;
							RedPlayerI_Script.redPlayerI_ColName = "none";
							redPlayerI_Steps = 0;
							playerTurn = "YELLOW";
						}


						if (currentPlayer == GreenPlayerI_Script.greenPlayerI_ColName && (currentPlayer != "Star" && GreenPlayerI_Script.greenPlayerI_ColName != "Star")) {
							SoundManagerScript.dismissalAudioSource.Play ();
							greenPlayerI.transform.position = greenPlayerI_Pos;
							GreenPlayerI_Script.greenPlayerI_ColName = "none";
							greenPlayerI_Steps = 0;
							playerTurn = "YELLOW";
						}


						if (currentPlayer == BluePlayerI_Script.bluePlayerI_ColName && (currentPlayer != "Star" && BluePlayerI_Script.bluePlayerI_ColName != "Star")) {
							SoundManagerScript.dismissalAudioSource.Play ();
							bluePlayerI.transform.position = bluePlayerI_Pos;
							BluePlayerI_Script.bluePlayerI_ColName = "none";
							bluePlayerI_Steps = 0;
							playerTurn = "YELLOW";
						}

					}
					break;				
				}
			}

		}
	}
}

