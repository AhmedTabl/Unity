using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdManager : MonoBehaviour
{
    private RewardedAd rewardedAd;

    // Start is called before the first frame update
    void Start()
    {

        MobileAds.Initialize(initStatus => { });
        this.rewardedAd = new RewardedAd("ca-app-pub-3940256099942544/5224354917");

    }
}
