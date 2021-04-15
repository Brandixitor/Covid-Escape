using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVScript : MonoBehaviour
{
    public GameObject videoplayer1, videoplayer2, videoplayer3, videoplayer4, videoplayer5, videoplayer6, videoplayer8, videoplayer9,
      videoplayer10, videoplayer11, videoplayer12, videoplayer13, videoplayer15, videoplayer16, videoplayer17, videoplayer18
      , videoplayer20, videoplayer21, videoplayer22, videoplayer24, videoplayer25;
    public GameObject panelTV;

  public  void closeTV()
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
