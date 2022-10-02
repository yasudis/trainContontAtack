using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class GoogleABSSite : MonoBehaviour
{
    
private InterstitialAd interstitial;
    

    private void RequestInterstitial()
{
#if UNITY_ANDROID
    string adUnitId = "ca-app-pub-3940256099942544/6300978111";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
        string adUnitId = "unexpected_platform";
#endif

    // Initialize an InterstitialAd.
    this.interstitial = new InterstitialAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }
    public void Start()
    {
        RequestInterstitial();
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();

        }
    }
}
