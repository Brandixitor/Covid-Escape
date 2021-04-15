using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerName : MonoBehaviour
{
    public GameObject panel;
    public GameObject textpalyer1, textplayer2, textplayer3, textplayer4 ,t3,t4;
    public Text red, grren, yellow, blue;

     void Start()
    {
        switch (MainMenuScript.howManyPlayers)
        {
            case 2:
                textpalyer1.SetActive(true);
                textplayer2.SetActive(true);
                textplayer3.SetActive(false);
                textplayer4.SetActive(false);
                t3.SetActive(false);
                t4.SetActive(false);

                break;

            case 3:
                textpalyer1.SetActive(true);
                textplayer2.SetActive(true);
                textplayer3.SetActive(true);
                textplayer4.SetActive(false);
                t4.SetActive(false);
                break;
            case 4:
                textpalyer1.SetActive(true);
                textplayer2.SetActive(true);
                textplayer3.SetActive(true);
                textplayer4.SetActive(true); 
                break;


        }
    }

    public void Game() {
       

    panel.SetActive(false);
        switch (MainMenuScript.howManyPlayers)
        {
            case 2:

                red.text = textpalyer1.GetComponent<InputField>().text;
                grren.text = textplayer2.GetComponent<InputField>().text;
                yellow.text = "";
                blue.text = "";
                break;

            case 3:
                red.text = textpalyer1.GetComponent<InputField>().text;
                grren.text = textplayer2.GetComponent<InputField>().text;
                yellow.text = textplayer3.GetComponent<InputField>().text;
                blue.text = "";
                break;
            case 4:
                red.text = textpalyer1.GetComponent<InputField>().text;
                grren.text = textplayer2.GetComponent<InputField>().text;
                yellow.text = textplayer3.GetComponent<InputField>().text;
                blue.text = textpalyer1.GetComponent<InputField>().text;
               
                break;


        }

    }



    // Update is called once per frame
    void Update()
    {
       
    }
}
