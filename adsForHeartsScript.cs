using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adsForHeartsScript : MonoBehaviour
{
    public myGoogleAdMob adsForHearts;
    public HeartSystem heartSystem;
    public int hearts;

    private void Awake()
    {
        adsForHearts = GameObject.FindObjectOfType<myGoogleAdMob>();
        heartSystem = GameObject.FindObjectOfType<HeartSystem>();
        hearts = 0;
    }

    public void AdsForHearts()
    {
        adsForHearts.DisplayRewardedAd();
        hearts += 10;
        Debug.Log(hearts.ToString());
    }

    public int HeartsR() 
    {
        return hearts;
        Debug.Log(hearts.ToString() + "successfully called");
    }
}
