using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class BannerAdScript : MonoBehaviour
{

    public string gameId = "3483562";
    public string placementId = "bannerplacement";
    public bool testMode = true;

    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
        Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
        //Advertisement.Banner.Load(placementId);

        StartCoroutine(ShowBannerWhenReady());


    }

    void Update()
    {
        //if (Advertisement.Banner.isLoaded)
        //    Advertisement.Banner.Show(placementId);
        //Debug.Log(Advertisement.Banner.isLoaded);
    }

    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady(placementId))
        { 
            Advertisement.Banner.Show(placementId);
            yield return new WaitForSeconds(0.5f);
        }
        

    }
}