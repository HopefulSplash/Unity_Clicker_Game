using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.EventSystems;

public class PlayServices : MonoBehaviour
{
    public Player player;
    public static bool hasInterent = false;
    public static PlayServices control;
    public static PlayGamesPlatform platform;

    void Start()
    {
        if (control == null)
        {
            control = this;
        }
        DontDestroyOnLoad(this);

        if (Application.internetReachability != NetworkReachability.NotReachable)
        {
            hasInterent = true;
            SignInToGooglePlayServices();
        }
        else
        {
            hasInterent = false;
        }
        
    }

    public void AddScoreToLeaderBoard()
    {
        if (hasInterent)
        {
            GameObject temp = GameObject.FindGameObjectWithTag("Player");
            player = temp.GetComponent<Player>();
            player.LoadPlayer();
            if (Social.localUser.authenticated)
            {
                Social.ReportScore(player.questOneProgress, "CgkIvMnyv-MdEAIQAQ", success => { });
            }
            else
            {
                SignInToGooglePlayServices();
            }
        }

    }
    public void ShowLeaderboard()
    {
        EventSystem.current.SetSelectedGameObject(null);

        if (hasInterent)
        {
            if (Social.localUser.authenticated)
            {
                Social.ShowLeaderboardUI();
            }
            else
            {
                SignInToGooglePlayServices();
            }
        }
    }

    public void ShowAchivements()
    {
        EventSystem.current.SetSelectedGameObject(null);

        if (hasInterent)
        {
            if (Social.localUser.authenticated)
            {
                Social.ShowAchievementsUI();
            }
            else
            {
                SignInToGooglePlayServices();
            }
        }

    }
    //6 achivements
    public void UnlockClickAchivement(int amountAdd)
    {   //if not logged in
        if (hasInterent)
        {
            if (Social.localUser.authenticated)
            {
                PlayGamesPlatform.Instance.IncrementAchievement("CgkIvMnyv-MdEAIQAw", amountAdd, success => { });
            }
        }
        
    }

    public void UnlockWWEAchivement()
    {
        if (hasInterent)
        {

            if (Social.localUser.authenticated)
            {
                Social.ReportProgress("CgkIvMnyv-MdEAIQAA", 100f, success => { });
            }
           
        }
    }

    public void UnlockGoldAchivement(int addAmount)
    {
        if (hasInterent)
        {

            if (Social.localUser.authenticated)
            {
                PlayGamesPlatform.Instance.IncrementAchievement("CgkIvMnyv-MdEAIQBA", addAmount, success => { });
            }

        }
    }

    public void UnlockGemAchivement(int addAmount)
    {
        if (hasInterent)
        {
            if (Social.localUser.authenticated)
            {
                PlayGamesPlatform.Instance.IncrementAchievement("CgkIvMnyv-MdEAIQBQ", addAmount, success => { });
            }
        }
        
    }

    public void UnlockAnimalAchivement(int addAmount)
    {
        if (hasInterent)
        {

            if (Social.localUser.authenticated)
            {
                PlayGamesPlatform.Instance.IncrementAchievement("CgkIvMnyv-MdEAIQBg", addAmount, success => { });
            }
        }
        
    }

    public void UnlockStarAchivement(int addAmount)
    {
        if (hasInterent)
        {
            if (Social.localUser.authenticated)
            {
                PlayGamesPlatform.Instance.IncrementAchievement("CgkIvMnyv-MdEAIQBw", addAmount, success => { });
            }
        }
        
    }

    public void SignInToGooglePlayServices()
    {
        if (hasInterent)
        {
            if (platform == null)
            {
                PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
                PlayGamesPlatform.InitializeInstance(config);
                PlayGamesPlatform.DebugLogEnabled = false;
                platform = PlayGamesPlatform.Activate();
            }

            PlayGamesPlatform.Instance.Authenticate(SignInInteractivity.CanPromptOnce, (result) => { });

            Social.Active.localUser.Authenticate(success =>
            {
                if (success)
                {
                    Debug.Log("Logged in successfully");
                }
                else
                {
                    Debug.Log("Login Failed");
                }
            });
        }
    }
}
