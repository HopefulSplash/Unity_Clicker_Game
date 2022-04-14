using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    public Quest questMenu;
    public MainMenuScript mainMenuScript;
    public Player player;
    private GameObject[] gameObject1;
    public Button oneButton;
    public Button twoButton;
    public Button threeButton;
    public Slider oneBar;
    public Slider twoBar;
    public Slider threeBar;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateQuestMenu()
    {
        questMenu.gameObject.SetActive(false);
    }
    public void QuestMenuButtonPressed()
    {
        mainMenuScript.ShaderON();
        gameObject1 = GameObject.FindGameObjectsWithTag("MainMenuUI");
        OnAndOffButton(gameObject1);

        questMenu.gameObject.SetActive(true);
        LoadQuestSettings();
    }
    public void LoadQuestSettings()
    {

        GameObject temp = GameObject.FindGameObjectWithTag("QuestB1");
        oneButton = temp.GetComponent<Button>();
        GameObject temp1 = GameObject.FindGameObjectWithTag("QuestB2");
        twoButton = temp1.GetComponent<Button>();
        GameObject temp2 = GameObject.FindGameObjectWithTag("QuestB3");
        threeButton = temp2.GetComponent<Button>();

        CheckQuestComplete();
        CheckQuestProgress();
    }

    public void CheckQuestProgress()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<Player>();
        player.LoadPlayer();

        GameObject temp1 = GameObject.FindGameObjectWithTag("QuestBar1");
        oneBar = temp1.GetComponent<Slider>();
        GameObject tempT1 = GameObject.FindGameObjectWithTag("QuestBarT1");
        tempT1.GetComponent<Text>().text = player.questOneProgress + " / " + player.questOneGoal;
        oneBar.maxValue = player.questOneGoal;
        oneBar.value = player.questOneProgress;

        GameObject temp2 = GameObject.FindGameObjectWithTag("QuestBar2");
        twoBar = temp2.GetComponent<Slider>();
        GameObject tempT2 = GameObject.FindGameObjectWithTag("QuestBarT2");
        tempT2.GetComponent<Text>().text = player.questTwoProgress + " / " + player.questTwoGoal;
        twoBar.maxValue = player.questTwoGoal;
        twoBar.value = player.questTwoProgress;

        GameObject temp3 = GameObject.FindGameObjectWithTag("QuestBar3");
        threeBar = temp3.GetComponent<Slider>();
        GameObject tempT3 = GameObject.FindGameObjectWithTag("QuestBarT3");
        tempT3.GetComponent<Text>().text = player.questThreeProgress + " / " + player.questThreeGoal; 
        threeBar.maxValue = player.questThreeGoal;
        threeBar.value = player.questThreeProgress;

        GameObject temp6 = GameObject.FindGameObjectWithTag("Q1C");
        temp6.GetComponent<Text>().text = player.questOneCoinReward.ToString();
        GameObject temp7 = GameObject.FindGameObjectWithTag("Q1G");
        temp7.GetComponent<Text>().text = player.questOneGemReward.ToString();

        GameObject temp8 = GameObject.FindGameObjectWithTag("Q2C");
        temp8.GetComponent<Text>().text = player.questTwoCoinReward.ToString();
        GameObject temp9 = GameObject.FindGameObjectWithTag("Q2G");
        temp9.GetComponent<Text>().text = player.questTwoGemReward.ToString();

        GameObject temp10 = GameObject.FindGameObjectWithTag("Q3C");
        temp10.GetComponent<Text>().text = player.questThreeCoinReward.ToString();
        GameObject temp11 = GameObject.FindGameObjectWithTag("Q3G");
        temp11.GetComponent<Text>().text = player.questThreeGemReward.ToString();
    }
    public void addClickQuest(int gameclicks)
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<Player>();
        player.LoadPlayer();

        player.questOneProgress = player.questOneProgress + gameclicks;
        if (player.questOneProgress >= player.questOneGoal)
        {
            player.questOneStageCompleted = true;
        }
        else if (player.questOneProgress < player.questOneGoal)
        {
            player.questOneStageCompleted = false;
        }

        player.SavePlayer();
    }
    public void addStarQuest(int gameStars)
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<Player>();
        player.LoadPlayer();

        player.questTwoProgress = player.questTwoProgress + gameStars;

        if (player.questTwoProgress >= player.questTwoGoal)
        {
            player.questTwoStageCompleted = true;
        }
        else if (player.questTwoProgress < player.questTwoGoal)
        {
            player.questTwoStageCompleted = false;
        }

        player.SavePlayer();
    }
    public void addAnimalQuest(int unlockedNewAnimal)
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<Player>();
        player.LoadPlayer();

        player.questThreeProgress = player.questThreeProgress + unlockedNewAnimal;


        if (player.questThreeProgress >= player.questThreeGoal)
        {
            player.questThreeStageCompleted = true;

        }
        else if (player.questThreeProgress < player.questThreeGoal)
        {
            player.questThreeStageCompleted = false;
        }
        player.SavePlayer();
        
    }
    public void AcceptButtonPressed(int questNumber)
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<Player>();
        player.LoadPlayer();

        if (questNumber == 1)
        {
            if (player.questOneStageCompleted == true)
            {
                player.playerCoins = player.playerCoins + player.questOneCoinReward;
                player.playerGems = player.playerGems + player.questOneGemReward;
                player.questOneGoal = (int)Math.Ceiling(player.questOneGoal * 2.0); ;

                player.questOneCoinReward = (int)Math.Ceiling(player.questOneCoinReward * 1.5);
                player.questOneGemReward = (int)Math.Ceiling(player.questOneGemReward * 1.5);

                if (player.questOneCoinReward >= 1000)
                {
                    player.questOneCoinReward = 1000;
                }
                if (player.questOneGemReward >= 1000)
                {
                    player.questOneGemReward = 1000;
                }
                player.SavePlayer();
                addClickQuest(0);
                CheckQuestComplete();
                CheckQuestProgress();

            }
        }
        else if (questNumber == 2)
        {
            if (player.questTwoStageCompleted == true)
            {
                player.playerCoins = player.playerCoins + player.questTwoCoinReward;
                player.playerGems = player.playerGems + player.questTwoGemReward;
                player.questTwoGoal = (int)Math.Ceiling(player.questTwoGoal * 1.1); ;
                player.questTwoCoinReward = (int)Math.Ceiling(player.questTwoCoinReward * 1.1);
                player.questTwoGemReward = (int)Math.Ceiling(player.questTwoGemReward * 1.1);

                if (player.questTwoCoinReward >= 1000)
                {
                    player.questTwoCoinReward = 1000;
                }
                if (player.questTwoGemReward >= 1000)
                {
                    player.questTwoGemReward = 1000;
                }

                player.SavePlayer();
                addStarQuest(0);
                CheckQuestComplete();
                CheckQuestProgress();
            }
        }
        else if (questNumber == 3)
        {
            if (player.questThreeStageCompleted == true)
            {
                player.playerCoins = player.playerCoins + player.questThreeCoinReward;
                player.playerGems = player.playerGems + player.questThreeGemReward;
                player.questThreeGoal = (int)Math.Ceiling(player.questThreeGoal * 1.1); ;
                player.questThreeCoinReward = (int)Math.Ceiling(player.questThreeCoinReward * 1.1);
                player.questThreeGemReward = (int)Math.Ceiling(player.questThreeGemReward * 1.1);

                if (player.questThreeCoinReward >= 1000)
                {
                    player.questThreeCoinReward = 1000;
                }
                if (player.questThreeGemReward >= 1000)
                {
                    player.questThreeGemReward = 1000;
                }

                player.SavePlayer();
                addAnimalQuest(0);
                CheckQuestComplete();
                CheckQuestProgress();
            }
        }

    }
    public void CheckQuestComplete()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<Player>();
        player.LoadPlayer();
   
        if (player.questOneStageCompleted == false)
        {
            SetButtonInactive(oneButton);
        }
        else
        {
            SetButtonActive(oneButton);
        }

        if (player.questTwoStageCompleted == false)
        {
            SetButtonInactive(twoButton);
        }
        else
        {
            SetButtonActive(twoButton);
        }

        if (player.questThreeStageCompleted == false)
        {
            SetButtonInactive(threeButton);
        }
        else
        {
            SetButtonActive(threeButton);
        }

    }

    public void SetButtonInactive(Button button)
    {

        var buttonTransform = button.transform;
        Image img = buttonTransform.GetChild(0).GetComponent<Image>();

        button.interactable = false;

        Image temp = button.GetComponent<Image>();

        temp.color = new Color32(255, 255, 255, 150);
        img.color = new Color32(255, 255, 255, 150);
    }

    public void SetButtonActive(Button button)
    {
        var buttonTransform = button.transform;
        Image img = buttonTransform.GetChild(0).GetComponent<Image>();

        button.interactable = true;

        Image temp = button.GetComponent<Image>();

        temp.color = new Color32(255, 255, 255, 255);
        img.color = new Color32(255, 255, 255, 255);
    }

    public void CloseQuestMenu(string option)
    {
        gameObject1 = GameObject.FindGameObjectsWithTag("MainMenuUI");
        OnAndOffButton(gameObject1);
        mainMenuScript.ShaderOff();
        questMenu.gameObject.SetActive(false);
    }
    public void OnAndOffButton(GameObject[] gameObject)
    {
        for (int i = 0; i <= gameObject.Length - 1; i++)
        {
            Button button = gameObject[i].GetComponent<Button>();
            button.interactable = !button.interactable;
        }
    }
}
