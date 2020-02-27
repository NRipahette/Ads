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
        Advertisement.Load(gameId);
        StartCoroutine(ShowBannerWhenReady());


    }

    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady(placementId))
        {

            
            yield return new WaitForSeconds(0.5f);
        }
        Debug.Log(Advertisement.IsReady(placementId));
        Advertisement.Banner.Show(placementId);
    }
}