using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;


public class RestartOnCollision : MonoBehaviour
{
    private MenuButtons MenuB;
    private RewardedAd rewardedAd;
    private BannerView bannerView;
    private InterstitialAd ad;

    private void Start()
    {
        MenuB = GetComponent<MenuButtons>();
        MobileAds.Initialize(initStatus => { });
        this.rewardedAd = new RewardedAd("ca-app-pub-3940256099942544/5224354917");
        this.bannerView = new BannerView("ca-app-pub-5701817096466821/4173852647", AdSize.Banner, AdPosition.Bottom);
        this.ad = new InterstitialAd("ca-app-pub-5701817096466821/8521782458");

        AdRequest request = new AdRequest.Builder().Build();
        AdRequest request2 = new AdRequest.Builder().Build();
        AdRequest request3 = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request);
        this.bannerView.LoadAd(request2);
        this.ad.LoadAd(request3);

        this.bannerView.Show();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {

            MenuB.loseMenu.SetActive(true);
            Time.timeScale = 0f;

            this.rewardedAd.Show();
        }
    }
}
