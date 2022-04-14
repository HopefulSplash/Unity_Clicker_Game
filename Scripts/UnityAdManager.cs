using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAdManager : MonoBehaviour, IUnityAdsListener
{
    public static UnityAdManager instance;
    Action onFinishSuccess;
    public string gameId = "4273327";
    public string myPlacementIdR = "Rewarded_Android_AE";
    public string myPlacementIdI = "Interstitial_Android_AE";
    public Store store;
    public string adSource;
    void Start()
    {
        Destroy(instance);
        if (instance == null)
        {
            instance = this;
        }

        if (!Advertisement.isInitialized)
        {
            Advertisement.Initialize(gameId);
            instance = this;
            Advertisement.AddListener(this);
        }
        else
        {
        }

    }
    Action onFinishSuccessGameOver;
    public void PlayGameOverAD(Action onFinish)
    {
        onFinishSuccessGameOver = onFinish;
        if (Advertisement.IsReady(myPlacementIdI))
        {
            Advertisement.Show(myPlacementIdI);
        }
    }
    Action onFinishSuccessPause;
    public void PlayPauseAD(Action onFinish)
    {
        onFinishSuccessPause = onFinish;
        if (Advertisement.IsReady(myPlacementIdI))
        {
            Advertisement.Show(myPlacementIdI);
        }
    }
    public void PlayRewardedAD(Action onFinish)
    {
        onFinishSuccess = onFinish;
        
        if (Advertisement.IsReady(myPlacementIdR))
        {
            Advertisement.Show(myPlacementIdR);
        }
        else
        {
        }
    }

    void IUnityAdsListener.OnUnityAdsReady(string placementId)
    {
       
    }

    void IUnityAdsListener.OnUnityAdsDidError(string message)
    {
       
    }

    void IUnityAdsListener.OnUnityAdsDidStart(string placementId)
    {
        
    }
    
    void IUnityAdsListener.OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
      

        if (showResult == ShowResult.Finished)
        {
            if (placementId == myPlacementIdR)
            {
                instance.onFinishSuccess.Invoke();
                
            }
            else if (placementId == myPlacementIdI)
            {
                instance.onFinishSuccessGameOver.Invoke();
            }
                    
        }
        else if (showResult == ShowResult.Skipped)
        {
            if (placementId == myPlacementIdI)
            {
                instance.onFinishSuccessGameOver.Invoke();
            }
        }
        else if (showResult == ShowResult.Failed)
        {
            if (placementId == myPlacementIdI)
            {
                instance.onFinishSuccessGameOver.Invoke();
            }
        }
    }
}
