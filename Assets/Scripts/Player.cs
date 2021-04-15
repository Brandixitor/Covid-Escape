using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject videoplayer1, videoplayer2, videoplayer3, videoplayer4, videoplayer5, videoplayer6, videoplayer8, videoplayer9,
        videoplayer10,videoplayer11,videoplayer12,videoplayer13,videoplayer15,videoplayer16,videoplayer17,videoplayer18
        , videoplayer20, videoplayer21, videoplayer22, videoplayer24, videoplayer25;
     public static string player_ColName;
    public GameObject panelTV;
    public GameObject home, p21, p11;
        void OnTriggerStay2D(Collider2D col)
    {



        if (col.gameObject.tag == "blocks")
        {

            player_ColName = col.gameObject.name;
            if (col.gameObject.name.Contains("P1"))
            {
             
                
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);

                 videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);

                 videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);

                 videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);

                videoplayer24.SetActive(false);
                videoplayer25.SetActive(false);
                panelTV.SetActive(true);
                videoplayer1.SetActive(true);
                Destroy(videoplayer1, 69);
                Destroy(panelTV, 69);

                Debug.Log("trigger");
            }
            if (col.gameObject.name.Contains("P2"))
            {

                videoplayer1.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);
                 videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);
                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);
                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);
                videoplayer24.SetActive(false);
                videoplayer25.SetActive(false);

                Debug.Log("trigger");
                panelTV.SetActive(true);
                videoplayer2.SetActive(true);
                Destroy(panelTV, 163);
                Destroy(videoplayer2, 163);

              
            }
            if (col.gameObject.name.Contains("P3"))
            {
                Debug.Log("trigger");
               
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);
                 videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);
                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);
                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);
                videoplayer24.SetActive(false);
                videoplayer25.SetActive(false);


                panelTV.SetActive(true);
                videoplayer3.SetActive(true);
                Destroy(videoplayer3, 41);
                Destroy(panelTV, 41);
            }
            if (col.gameObject.name.Contains("P4"))
            {
                Debug.Log("trigger");
           
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);
                videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);
                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);
                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);
                videoplayer24.SetActive(false);
                videoplayer25.SetActive(false);

                panelTV.SetActive(true);
                videoplayer4.SetActive(true);
                Destroy(panelTV, 59);
                Destroy(videoplayer4, 59);
            }
            if (col.gameObject.name.Contains("P5"))
            {

                Debug.Log("trigger");
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer6.SetActive(false);
                videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);
                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);
                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);
                videoplayer24.SetActive(false);
                videoplayer25.SetActive(false);

                panelTV.SetActive(true);

                videoplayer5.SetActive(true);
                Destroy(videoplayer5, 16);
                Destroy(panelTV, 16);

            }
            if (col.gameObject.name.Contains("P6"))
            {
                Debug.Log("trigger");
             
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);
                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);
                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);
                videoplayer24.SetActive(false);

                panelTV.SetActive(true);
                videoplayer6.SetActive(true);
                 Destroy(videoplayer6, 39);
                Destroy(panelTV, 39);
            }
            
            if (col.gameObject.name.Contains("P8"))
            {
                Debug.Log("trigger");
               
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);
                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);
                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);
                videoplayer24.SetActive(false);


                panelTV.SetActive(true);
                videoplayer8.SetActive(true);
                Destroy(videoplayer8, 114);
                Destroy(panelTV, 114);
            }
            if (col.gameObject.name.Contains("P9"))
            {
                Debug.Log("trigger");
                panelTV.SetActive(true);
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);
                videoplayer8.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);
                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);
                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);
                videoplayer24.SetActive(false);

                videoplayer9.SetActive(true);
                Destroy(videoplayer9, 36);
                Destroy(panelTV, 36);

            }
            if (col.gameObject.name.Contains("P10"))
            {
                Debug.Log("trigger");
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);
                videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);
                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);
                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);
                videoplayer24.SetActive(false);

                videoplayer10.SetActive(true);
                panelTV.SetActive(true);
                Destroy(videoplayer10, 183);
                Destroy(panelTV, 183);

            }

            if (col.gameObject.name.Contains("P11"))
            {
                Debug.Log("trigger");
                panelTV.SetActive(true);
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);
                videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);
                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);
                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);
                videoplayer24.SetActive(false);


                videoplayer11.SetActive(true);
                Destroy(videoplayer11, 143);
                Destroy(panelTV, 143);

            }

            if (col.gameObject.name.Contains("P12"))
            {
                Debug.Log("trigger");
                panelTV.SetActive(true);
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);
                videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer13.SetActive(false);
                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);
                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);
                videoplayer24.SetActive(false);

                videoplayer12.SetActive(true);
                Destroy(videoplayer12, 133); Destroy(panelTV, 133);

            }

            if (col.gameObject.name.Contains("P13"))
            {
                Debug.Log("trigger");

                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);
                videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);
                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);
                videoplayer24.SetActive(false);

                videoplayer13.SetActive(true);
                Destroy(videoplayer13, 160); Destroy(panelTV, 160);

            }

            if (col.gameObject.name.Contains("P15"))
            {
                Debug.Log("trigger");
                panelTV.SetActive(true);
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);
                videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);
                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);
                videoplayer24.SetActive(false);

                videoplayer15.SetActive(true);
                Destroy(videoplayer15, 240); Destroy(panelTV, 240);

            }


            if (col.gameObject.name.Contains("P16"))
            {
                Debug.Log("trigger");
                panelTV.SetActive(true);
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);
                videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer15.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);
                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);
                videoplayer24.SetActive(false);

                videoplayer16.SetActive(true);
                Destroy(videoplayer16, 60); Destroy(panelTV, 60);

            }


            if (col.gameObject.name.Contains("P17"))
            {
                Debug.Log("trigger");
                panelTV.SetActive(true);
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);
                videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer15.SetActive(false);
                videoplayer18.SetActive(false);
                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);
                videoplayer24.SetActive(false);

                videoplayer17.SetActive(true);
                Destroy(videoplayer17, 52); Destroy(panelTV, 52);

            }



            if (col.gameObject.name.Contains("P18"))
            {
                panelTV.SetActive(true);
                Debug.Log("trigger");

                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);
                videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);
                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);
                videoplayer24.SetActive(false);

                videoplayer18.SetActive(true);
                Destroy(videoplayer18, 36); Destroy(panelTV, 36);

            }

            if (col.gameObject.name.Contains("P20"))
            {
                Debug.Log("trigger");
                panelTV.SetActive(true);
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);
                videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);
                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);
                videoplayer24.SetActive(false);

                videoplayer20.SetActive(true);
                Destroy(videoplayer20, 54); Destroy(panelTV, 54);

            }

            if (col.gameObject.name.Contains("P21"))
            {
                Debug.Log("trigger");
                panelTV.SetActive(true);
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);
                videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);
                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);
                videoplayer20.SetActive(false);
                videoplayer22.SetActive(false);
                videoplayer24.SetActive(false);

                videoplayer21.SetActive(true);
                Destroy(videoplayer21, 29); Destroy(panelTV, 29);

            }


            if (col.gameObject.name.Contains("P22"))
            {
                Debug.Log("trigger");
                panelTV.SetActive(true);
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);
                videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);
                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);
                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer24.SetActive(false);

                videoplayer22.SetActive(true);
                Destroy(videoplayer22, 25); Destroy(panelTV, 25);

            }

            if (col.gameObject.name.Contains("P24"))
            {
                Debug.Log("trigger");
                panelTV.SetActive(true);
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);
                videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);
                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);
                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);
                                videoplayer25.SetActive(false);

                videoplayer24.SetActive(true);

                Destroy(videoplayer24, 0); Destroy(panelTV, 0);

            }




            if (col.gameObject.name.Contains("P25"))
            {
                Debug.Log("trigger");
                panelTV.SetActive(true);
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);
                videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);
                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);
                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);
                videoplayer24.SetActive(false);


                videoplayer25.SetActive(true);
                Destroy(videoplayer25,20); Destroy(panelTV, 20);

            }

          /*  if (col.gameObject.name.Contains("P7"))
            {
                SoundManagerScript.safeHouseAudioSource.Play();

                this.transform.position =home.transform.position;
                RedPlayerI_Script.redPlayerI_ColName = "none";
 
                panelTV.SetActive(true);
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);

                videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);

                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);

                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);

                videoplayer24.SetActive(false);
                videoplayer25.SetActive(false);

                Debug.Log("trigger");
            }*/
            if (col.gameObject.name.Contains("P14"))
            {
                SoundManagerScript.safeHouseAudioSource.Play();

                this.transform.position = p11.transform.position;
                RedPlayerI_Script.redPlayerI_ColName = "none";

                panelTV.SetActive(true);
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);

                videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);

                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);

                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);

                videoplayer24.SetActive(false);
                videoplayer25.SetActive(false);

                Debug.Log("trigger");
            }
            if (col.gameObject.name.Contains("P19"))
            {
                SoundManagerScript.safeHouseAudioSource.Play();

                this.transform.position = home.transform.position;
                RedPlayerI_Script.redPlayerI_ColName = "none";

                panelTV.SetActive(true);
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);

                videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);

                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);

                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);

                videoplayer24.SetActive(false);
                videoplayer25.SetActive(false);

                Debug.Log("trigger");
            }
            if (col.gameObject.name.Contains("P22"))
            {
                SoundManagerScript.safeHouseAudioSource.Play();

                this.transform.position = p21.transform.position;
                RedPlayerI_Script.redPlayerI_ColName = "none";

                panelTV.SetActive(true);
                videoplayer1.SetActive(false);
                videoplayer2.SetActive(false);
                videoplayer3.SetActive(false);
                videoplayer4.SetActive(false);
                videoplayer5.SetActive(false);
                videoplayer6.SetActive(false);

                videoplayer8.SetActive(false);
                videoplayer9.SetActive(false);
                videoplayer10.SetActive(false);
                videoplayer11.SetActive(false);
                videoplayer12.SetActive(false);
                videoplayer13.SetActive(false);

                videoplayer15.SetActive(false);
                videoplayer16.SetActive(false);
                videoplayer17.SetActive(false);
                videoplayer18.SetActive(false);

                videoplayer20.SetActive(false);
                videoplayer21.SetActive(false);
                videoplayer22.SetActive(false);

                videoplayer24.SetActive(false);
                videoplayer25.SetActive(false);

                Debug.Log("trigger");
            }

        }










    } 
   
    // Start is called before the first frame update
    void Start()
    {
        panelTV.SetActive(false);
        videoplayer1.SetActive(false);
        videoplayer2.SetActive(false);
        videoplayer3.SetActive(false);
        videoplayer4.SetActive(false);
        videoplayer5.SetActive(false);
        videoplayer6.SetActive(false);
 

        videoplayer8.SetActive(false);
        videoplayer9.SetActive(false);
        videoplayer10.SetActive(false);
        videoplayer11.SetActive(false);
        videoplayer12.SetActive(false);
        videoplayer13.SetActive(false);

        videoplayer15.SetActive(false);
        videoplayer16.SetActive(false);
        videoplayer17.SetActive(false);
        videoplayer18.SetActive(false);

        videoplayer20.SetActive(false);
        videoplayer21.SetActive(false);
        videoplayer22.SetActive(false);

        videoplayer24.SetActive(false);
        videoplayer25.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
