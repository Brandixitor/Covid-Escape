using UnityEngine;
using System.Collections;
using admob;

// PLEASE CREATE YOUR ADMOB ACCOUNT. YOU NEED IT....

public class admobdemo : MonoBehaviour 
{			
	void Start () 
	{
        Admob.Instance().bannerEventHandler += onBannerEvent;
        Admob.Instance().interstitialEventHandler += onInterstitialEvent;
        Admob.Instance().rewardedVideoEventHandler += onRewardedVideoEvent;
		
		Admob ad = Admob.Instance();
		ad.initAdmob("app id", "app id"); // See it in your admob account for particular app. Get these ids from Admob account.
	
		int choose = Random.Range (0,3);

		// Randomly selection of what to display.......
		switch (choose) 
		{
				case 0: // Full Screen Ads...
					ad = Admob.Instance();
					if (ad.isInterstitialReady())
					{
						ad.showInterstitial();
					}
					else
					{
						ad.loadInterstitial();
					}
					break;
				
				case 1: // Rewarded Videos
					ad = Admob.Instance();
					if (ad.isRewardedVideoReady())
					{
						ad.showRewardedVideo();
					}
					else
					{
						ad.loadRewardedVideo("ca-app-pub-3940256099942544/xxxxxxxxxxx"); // Provide your Id here...
					}
						break;
				case 2: //  Banner Ads
					Admob.Instance().showBannerRelative(AdSize.Banner, AdPosition.BOTTOM_CENTER, 0);
					break;
		}
	}	
	
    void onInterstitialEvent(string eventName, string msg)
    {
        Debug.Log("handler onAdmobEvent---" + eventName + "   " + msg);
        if (eventName == AdmobEvent.onAdLoaded)
        {
            Admob.Instance().showInterstitial();
        }
    }
    void onBannerEvent(string eventName, string msg)
    {
        Debug.Log("handler onAdmobBannerEvent---" + eventName + "   " + msg);
    }
    void onRewardedVideoEvent(string eventName, string msg)
    {
        Debug.Log("handler onRewardedVideoEvent---" + eventName + "   " + msg);
    }
}
