using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EndGameScript : MonoBehaviour
{

    public GameObject endGameScreen;
    public Image endScreenTitle;
    public Sprite defeatTitle;
    public Sprite victoryTitle;
    public KeepAudio audioManager;
    public UnityAdManager adManager;
    public Player player;
    public Text playerScore;
    public Image[] gameStars;
    public Sprite completedStar;
    public Sprite unCompletedStar;
    public Text[] gameRewards;
    public GameObject shader;
    public GameObject HUD;
    public List<GameObject> HUDButtons;
    public bool winOrLose;
    public GameObject victoryButtons;
    public GameObject defeatButtons;
    public GameObject[] gameOverButtons;
    public GameObject confirmShader;
    public GameObject confirmMenu;
    public int confirmOption;
    public GameController gameController;
    public int[] rewardWin;
    public int[] rewardLose;
    public GameObject[] Foreground;
    public Sprite[] noRewards;
    public Image[] rewardsImage;
    public Quest quest;
    public int numberStar;
    public int coinRewardPortion;
    public int gemRewardPortion;
    public int potionRewardPortion;
    public int extraStars = 0;
    public Button rButton;
    public Button r1Button;
    public Button pButton;
       public void SetButtonInactive(Button button)
    {

        var buttonTransform = button.transform;

        Image temp = button.GetComponent<Image>();

        temp.color = new Color32(255, 255, 255, 150);
    }

    public void SetButtonActive(Button button)
    {

        var buttonTransform = button.transform;

        Image temp = button.GetComponent<Image>();

        temp.color = new Color32(255, 255, 255, 255);
    }
    public void CheckButton()
    {
        if (winOrLose == true)
        {
            if (player.playerHearts > 0)
            {
                rButton.interactable = true;
                pButton.interactable = true;
            }
            else
            {
                rButton.interactable = false;
                pButton.interactable = false;
            }
        }
        else if (winOrLose == false)
        {
            if (player.playerHearts > 0)
            {
                r1Button.interactable = true;
            }
            else
            {
                r1Button.interactable = false;
            }
        }
    }
    public void ButtonCheck(Button b1)
    {
        if (player.playerHearts > 0)
        {
            SetButtonActive(b1);

        }
        else
        {
            SetButtonInactive(b1);
        }
    }


    public void EndGamePressed()
    {
     
        Time.timeScale = 0f;
        foreach (GameObject element in Foreground)
        {
            element.SetActive(false);
        }
        shader.gameObject.SetActive(true);
        endGameScreen.gameObject.SetActive(true);
        OnAndOffButton(HUDButtons.ToArray());
        

        HUD.gameObject.SetActive(false);

        if (winOrLose == true)
        {
            GameObject temp = GameObject.FindGameObjectWithTag("EndScreenTitle");
            endScreenTitle = temp.GetComponent<Image>();
            endScreenTitle.GetComponent<Image>().sprite = victoryTitle;

            victoryButtons.gameObject.SetActive(true);
            defeatButtons.gameObject.SetActive(false);
            ButtonCheck(rButton);
            ButtonCheck(pButton);
           
            playerScore.text = "Score: " + gameController.thisGameScore;
            if (gameController.thisGameScore >= gameController.threeStar)
            {
                gameStars[0].sprite = completedStar;
                gameStars[1].sprite = completedStar;
                gameStars[2].sprite = completedStar;
                numberStar = 3;
                RewardForStars(3);
                player.playerHearts = player.playerHearts + 3;
            }
            else if (gameController.thisGameScore < gameController.threeStar && gameController.thisGameScore > gameController.twoStar)
            {
                gameStars[0].sprite = completedStar;
                gameStars[1].sprite = completedStar;
                RewardForStars(2);
                numberStar = 2;
            }
            else if (gameController.thisGameScore < gameController.threeStar && gameController.thisGameScore < gameController.twoStar && gameController.thisGameScore > gameController.oneStar)
            {
                gameStars[0].sprite = completedStar;
                RewardForStars(1);
                numberStar = 1;
            }
            else
            {
                gameStars[0].sprite = unCompletedStar;
                gameStars[1].sprite = unCompletedStar;
                gameStars[2].sprite = unCompletedStar;
                numberStar = 0;
                RewardForStars(0);
                if (player.playerHearts > 0)
                {
                    player.playerHearts = player.playerHearts - 1;
                }
                else 
                {
                }
            }
        }
        else if (winOrLose == false)
        {
            GameObject temp = GameObject.FindGameObjectWithTag("EndScreenTitle");
            endScreenTitle = temp.GetComponent<Image>();
            endScreenTitle.GetComponent<Image>().sprite = defeatTitle;
            victoryButtons.gameObject.SetActive(false);
            defeatButtons.gameObject.SetActive(true);

            ButtonCheck(r1Button);

            gameRewards[0].text = "x" + rewardLose[0].ToString();
            gameRewards[1].text = "x" + rewardLose[1].ToString();
            gameRewards[2].text = "x" + rewardLose[2].ToString();
            if (rewardLose[0] == 0)
            {
                rewardsImage[0].sprite = noRewards[0];
            }
            if (rewardLose[1] == 0)
            {
                rewardsImage[1].sprite = noRewards[1];
            }
            if (rewardLose[2] == 0)
            {
                rewardsImage[2].sprite = noRewards[2];
            }
            playerScore.text = "Score: " + gameController.thisGameScore;
            if (gameController.thisGameScore > gameController.threeStar)
            {
                gameStars[0].sprite = completedStar;
                gameStars[1].sprite = completedStar;
                gameStars[2].sprite = completedStar;
            }
            else if (gameController.thisGameScore < gameController.threeStar && gameController.thisGameScore > gameController.twoStar)
            {
                gameStars[0].sprite = completedStar;
                gameStars[1].sprite = completedStar;
            }
            else if (gameController.thisGameScore < gameController.threeStar && gameController.thisGameScore < gameController.twoStar && gameController.thisGameScore > gameController.oneStar)
            {
                gameStars[0].sprite = completedStar;
            }
            else
            {
                gameStars[0].sprite = unCompletedStar;
                gameStars[1].sprite = unCompletedStar;
                gameStars[2].sprite = unCompletedStar;
                if (player.playerHearts > 0)
                {
                    player.playerHearts = player.playerHearts - 1;
                }
                else
                {
                }
            }
            numberStar = 0;
            coinRewardPortion = rewardLose[2];
            gemRewardPortion = rewardLose[1];
            potionRewardPortion = rewardLose[0];
        }

        player.playerCoins = player.playerCoins + coinRewardPortion;
        player.playerGems = player.playerGems + gemRewardPortion;
        player.playerPotions = player.playerPotions + +potionRewardPortion;
        player.SavePlayer();

        quest.addClickQuest(gameController.totalClickCountGame);
        player.SavePlayer();

        saveLevelProgessAnimal(gameController.AninalNumber());

        //ACHIVEMENT
        if (gameController.totalClickCountGame == 0)
        {
            //didnt hit any animals so unlock achivement
            PlayServices.control.UnlockWWEAchivement();
        }
        //adds all the clicks from the game to the achivment progress
        PlayServices.control.UnlockClickAchivement(gameController.totalClickCountGame);
        //adds all the earned gold to the achivment
        PlayServices.control.UnlockGoldAchivement(coinRewardPortion);
        //adds extra starts to achivements
        PlayServices.control.UnlockStarAchivement(extraStars);
        //add gems to achivements
        PlayServices.control.UnlockGemAchivement(gemRewardPortion);
    }

    public void RewardForStars(int stars)
    {
        if (stars == 3)
        {
            gameRewards[0].text = "x" + rewardWin[0].ToString();
            gameRewards[1].text = "x" + rewardWin[1].ToString();
            gameRewards[2].text = "x" + rewardWin[2].ToString();
            if (rewardWin[0] == 0)
            {
                rewardsImage[0].sprite = noRewards[0];
            }
            if (rewardWin[1] == 0)
            {
                rewardsImage[1].sprite = noRewards[1];
            }
            if (rewardWin[2] == 0)
            {
                rewardsImage[2].sprite = noRewards[2];
            }
            coinRewardPortion = rewardWin[2];
            gemRewardPortion = rewardWin[1];
            potionRewardPortion = rewardWin[0];

        }
        else if (stars == 2)
        {
            int newRewardP = (int)System.Math.Ceiling(rewardWin[0] / 2f);
            int newRewardG = (int)System.Math.Ceiling(rewardWin[1] / 2f);
            int newRewardC = (int)System.Math.Ceiling(rewardWin[2] / 2f);

            gameRewards[0].text = "x" + newRewardP.ToString();
            gameRewards[1].text = "x" + newRewardG.ToString();
            gameRewards[2].text = "x" + newRewardC.ToString();
            if (newRewardP == 0)
            {
                rewardsImage[0].sprite = noRewards[0];
            }
            if (newRewardG == 0)
            {
                rewardsImage[1].sprite = noRewards[1];
            }
            if (newRewardC == 0)
            {
                rewardsImage[2].sprite = noRewards[2];
            }

            coinRewardPortion = newRewardC;
            gemRewardPortion = newRewardG;
            potionRewardPortion = newRewardP;
        }
        else if (stars == 1)
        {
          
            int newRewardP = (int)System.Math.Ceiling(rewardWin[0] / 3f);
            int newRewardG = (int)System.Math.Ceiling(rewardWin[1] / 3f);
            int newRewardC = (int)System.Math.Ceiling(rewardWin[2] / 3f);

            gameRewards[0].text = "x" + newRewardP.ToString();
            gameRewards[1].text = "x" + newRewardG.ToString();
            gameRewards[2].text = "x" + newRewardC.ToString();
            if (newRewardP == 0)
            {
                rewardsImage[0].sprite = noRewards[0];
            }
            if (newRewardG == 0)
            {
                rewardsImage[1].sprite = noRewards[1];
            }
            if (newRewardC == 0)
            {
                rewardsImage[2].sprite = noRewards[2];
            }

            coinRewardPortion = newRewardC;
            gemRewardPortion = newRewardG;
            potionRewardPortion = newRewardP;
        }
        else
        {
            //NO REWARDS
        }
    }

    public void saveLevelProgessAnimal(int animalNumber)
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<Player>();
        player.LoadPlayer();
        int animal2Test = animalNumber + 1;

        switch (animal2Test)
        {     
            case 1:
                if (numberStar > player.chickLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.chickLevelStars[gameController.LevelNumver() - 1]);
                    player.chickLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                    
                }
                break;
            case 2:
                if (numberStar > player.chickenLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.chickenLevelStars[gameController.LevelNumver() - 1]);
                    player.chickenLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 3:
                if (numberStar > player.henLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.henLevelStars[gameController.LevelNumver() - 1]);
                    player.henLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 4:
                if (numberStar > player.duckLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.duckLevelStars[gameController.LevelNumver() - 1]);
                    player.duckLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 5:
                if (numberStar > player.gobblerLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.gobblerLevelStars[gameController.LevelNumver() - 1]);
                    player.gobblerLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 6:
                if (numberStar > player.gooseLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.gooseLevelStars[gameController.LevelNumver() - 1]);
                    player.gooseLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 7:
                if (numberStar > player.drakeLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.drakeLevelStars[gameController.LevelNumver() - 1]);
                    player.drakeLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 8:
                if (numberStar > player.turkeyLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.turkeyLevelStars[gameController.LevelNumver() - 1]);
                    player.turkeyLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 9:
                if (numberStar > player.roosterLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.roosterLevelStars[gameController.LevelNumver() - 1]);
                    player.roosterLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 10:
                if (numberStar > player.wHenLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.wHenLevelStars[gameController.LevelNumver() - 1]);
                    player.wHenLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 11:
                if (numberStar > player.bRoosterLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.bRoosterLevelStars[gameController.LevelNumver() - 1]);
                    player.bRoosterLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 12:
                if (numberStar > player.fTurkeyLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.fTurkeyLevelStars[gameController.LevelNumver() - 1]);
                    player.fTurkeyLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 13:
                if (numberStar > player.wRoosterLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.wRoosterLevelStars[gameController.LevelNumver() - 1]);
                    player.wRoosterLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 14:
                if (numberStar > player.bunnyLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.bunnyLevelStars[gameController.LevelNumver() - 1]);
                    player.bunnyLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 15:
                if (numberStar > player.dBunnyLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.dBunnyLevelStars[gameController.LevelNumver() - 1]);
                    player.dBunnyLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 16:
                if (numberStar > player.lBunnyLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.lBunnyLevelStars[gameController.LevelNumver() - 1]);
                    player.lBunnyLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 17:
                if (numberStar > player.cowLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.cowLevelStars[gameController.LevelNumver() - 1]);
                    player.cowLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 18:
                if (numberStar > player.sheepLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.sheepLevelStars[gameController.LevelNumver() - 1]);
                    player.sheepLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 19:
                if (numberStar > player.donkeyLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.donkeyLevelStars[gameController.LevelNumver() - 1]);
                    player.donkeyLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 20:
                if (numberStar > player.goatLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.goatLevelStars[gameController.LevelNumver() - 1]);
                    player.goatLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 21:
                if (numberStar > player.oxLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.oxLevelStars[gameController.LevelNumver() - 1]);
                    player.oxLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 22:
                if (numberStar > player.ramLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.ramLevelStars[gameController.LevelNumver() - 1]);
                    player.ramLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 23:
                if (numberStar > player.bullLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.bullLevelStars[gameController.LevelNumver() - 1]);
                    player.bullLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 24:
                if (numberStar > player.burroLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.burroLevelStars[gameController.LevelNumver() - 1]);
                    player.burroLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 25:
                if (numberStar > player.wGoatLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.wGoatLevelStars[gameController.LevelNumver() - 1]);
                    player.wGoatLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 26:
                if (numberStar > player.pugLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.pugLevelStars[gameController.LevelNumver() - 1]);
                    player.pugLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 27:
                if (numberStar > player.ponyLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.ponyLevelStars[gameController.LevelNumver() - 1]);
                    player.ponyLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 28:
                if (numberStar > player.horseLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.horseLevelStars[gameController.LevelNumver() - 1]);
                    player.horseLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 29:
                if (numberStar > player.piggyLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.piggyLevelStars[gameController.LevelNumver() - 1]);
                    player.piggyLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 30:
                if (numberStar > player.pigLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.pigLevelStars[gameController.LevelNumver() - 1]);
                    player.pigLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 31:
                if (numberStar > player.porkyLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.porkyLevelStars[gameController.LevelNumver() - 1]);
                    player.porkyLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;
            case 32:
                if (numberStar > player.swineLevelStars[gameController.LevelNumver() - 1])
                {
                    extraStars = numberStar - (player.swineLevelStars[gameController.LevelNumver() - 1]);
                    player.swineLevelStars[gameController.LevelNumver() - 1] = numberStar;
                    player.SavePlayer();
                    if (extraStars > 0)
                    {
                        quest.addStarQuest(extraStars);
                    }
                }
                break;

            default:
                break;
              
        }
    }
    public void OnAndOffButton(GameObject[] gameObject)
    {
        for (int i = 0; i <= gameObject.Length - 1; i++)
        {
            Button button = gameObject[i].GetComponent<Button>();
            button.interactable = !button.interactable;
        }
    }
    public void DontShowEndScreen()
    {

        HUDButtons.Add(GameObject.FindGameObjectWithTag("pauseButton"));
        HUDButtons.Add(GameObject.FindGameObjectWithTag("muteButton"));
        HUDButtons.Add(GameObject.FindGameObjectWithTag("attackToggle"));
        HUDButtons.Add(GameObject.FindGameObjectWithTag("potionToggle"));
        endGameScreen.gameObject.SetActive(false);
        confirmShader.gameObject.SetActive(false);
        confirmMenu.gameObject.SetActive(false);
    }

    public void ShowEndScreenMenu(bool option)
    {
        if (option == true)
        {
            winOrLose = true;
        }
        else if (option == false)
        {
            winOrLose = false;
        }
        EndGamePressed();
    }

    public void HomePressed()
    {
        EventSystem.current.SetSelectedGameObject(null);
        confirmShader.gameObject.SetActive(true);
        confirmOption = 0;
        confirmMenu.SetActive(true);

        Text tem = GameObject.FindGameObjectWithTag("confirmText").GetComponent<Text>();
        tem.text = "Are You Sure You Want To Return To The Home Screen?";

        gameOverButtons = GameObject.FindGameObjectsWithTag("GameOverButtonsWin");
        OnAndOffButton(gameOverButtons);
        gameOverButtons = GameObject.FindGameObjectsWithTag("GameOverButtonsLose");
        OnAndOffButton(gameOverButtons);
    }

    public void RestartPressed()
    {
        EventSystem.current.SetSelectedGameObject(null);
        confirmShader.gameObject.SetActive(true);
        confirmOption = 1;
        confirmMenu.SetActive(true);
        Text tem = GameObject.FindGameObjectWithTag("confirmText").GetComponent<Text>();
        tem.text = "Current Progress Will Be Saved! Are You Sure You Want To Restart The Game?";

        gameOverButtons = GameObject.FindGameObjectsWithTag("GameOverButtonsWin");
        OnAndOffButton(gameOverButtons);
        gameOverButtons = GameObject.FindGameObjectsWithTag("GameOverButtonsLose");
        OnAndOffButton(gameOverButtons);
    }

    public void PlayAdFinished()
    {
        PlayServices.control.AddScoreToLeaderBoard();
        audioManager.StopBGMusic();
        GameController.levelNumber = 1;
        GameController.animalNumber++;
        gameController.paused = true;
        Time.timeScale = 1f;
        LeverLoader.isLoaded = false;
        LeverLoader.instance.StopAllCoroutines();
        LeverLoader.levelToLoad = 1;
        LeverLoader.instance.LoadNextLevel();
    }
    public void PlayAd1Finished()
    {
        PlayServices.control.AddScoreToLeaderBoard();
        audioManager.StopBGMusic();
        GameController.levelNumber++;
        gameController.paused = true;
        Time.timeScale = 1f;
        LeverLoader.isLoaded = false;
        LeverLoader.instance.StopAllCoroutines();
        LeverLoader.levelToLoad = 1;
        LeverLoader.instance.LoadNextLevel();
    }


   
    public void PlayButtonPressed()
    {

        if (GameController.levelNumber == 10)
        {

            if (CheckIfNextUnlocked(GameController.animalNumber + 1))
            {
                endGameScreen.gameObject.SetActive(false);
                confirmMenu.gameObject.SetActive(false);
                gameOverButtons = GameObject.FindGameObjectsWithTag("GameOverButtonsWin");
                OnAndOffButton(gameOverButtons);
                gameOverButtons = GameObject.FindGameObjectsWithTag("GameOverButtonsLose");
                OnAndOffButton(gameOverButtons);
                endGameScreen.gameObject.SetActive(false);
                EventSystem.current.SetSelectedGameObject(null);

                if (player.playerRemoveADs == false)
                {
                    adManager.PlayGameOverAD(PlayAdFinished);
                }
                else
                {
                    PlayAdFinished();
                }

            }
            else
            {
               
                EventSystem.current.SetSelectedGameObject(null);
                confirmShader.gameObject.SetActive(true);
                confirmOption = 0;
                confirmMenu.SetActive(true);

                Text tem = GameObject.FindGameObjectWithTag("confirmText").GetComponent<Text>();
                tem.text = "You Haven't Unlocked The Next Animal Yet. Go To The Main Menu To Unlock";

                gameOverButtons = GameObject.FindGameObjectsWithTag("GameOverButtonsWin");
                OnAndOffButton(gameOverButtons);
                gameOverButtons = GameObject.FindGameObjectsWithTag("GameOverButtonsLose");
                OnAndOffButton(gameOverButtons);

            }

        }
        else
        {
            endGameScreen.gameObject.SetActive(false);
            confirmMenu.gameObject.SetActive(false);
            gameOverButtons = GameObject.FindGameObjectsWithTag("GameOverButtonsWin");
            OnAndOffButton(gameOverButtons);
            gameOverButtons = GameObject.FindGameObjectsWithTag("GameOverButtonsLose");
            OnAndOffButton(gameOverButtons);

            EventSystem.current.SetSelectedGameObject(null);

           
            if (player.playerRemoveADs == false)
            {
                adManager.PlayGameOverAD(PlayAd1Finished);
            }
            else
            {
                PlayAd1Finished();
            }

        }
    }
    public bool CheckIfNextUnlocked(int animalNumber)
    {
        switch (animalNumber + 1)
        {
            case 1:
                if (player.chickLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            case 2:
                if (player.chickenLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 3:
                if (player.henLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 4:
                if (player.duckLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 5:
                if (player.gobblerLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 6:
                if (player.gooseLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 7:
                if (player.drakeLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 8:
                if (player.turkeyLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 9:
                if (player.roosterLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 10:
                if (player.wHenLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 11:
                if (player.bRoosterLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 12:
                if (player.fTurkeyLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 13:
                if (player.wRoosterLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 14:
                if (player.bunnyLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 15:
                if (player.dBunnyLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 16:
                if (player.lBunnyLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 17:
                if (player.cowLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 18:
                if (player.sheepLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 19:
                if (player.donkeyLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 20:
                if (player.goatLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 21:
                if (player.oxLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 22:
                if (player.ramLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 23:
                if (player.bullLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 24:
                if (player.burroLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 25:
                if (player.wGoatLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 26:
                if (player.pugLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 27:
                if (player.ponyLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 28:
                if (player.horseLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 29:
                if (player.piggyLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 30:
                if (player.pigLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 31:
                if (player.porkyLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case 32:
                if (player.swineLevelUnlocked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            default:
                return false;
        }
    }

    public void RestartAdFinished()
    {
        PlayServices.control.AddScoreToLeaderBoard();
        audioManager.StopBGMusic();
        gameController.paused = true;
        Time.timeScale = 1f;
        LeverLoader.isLoaded = false;
        LeverLoader.instance.StopAllCoroutines();
        LeverLoader.levelToLoad = 1;
        LeverLoader.instance.LoadNextLevel();
    }

    public void RestartAd1Finished()
    {
        PlayServices.control.AddScoreToLeaderBoard();
        audioManager.StopBGMusic();
        gameController.paused = true;
        Time.timeScale = 1f;
        LeverLoader.isLoaded = false;
        LeverLoader.instance.StopAllCoroutines();
        LeverLoader.levelToLoad = 0;
        LeverLoader.instance.LoadNextLevel();
    }
    public void ConfirmRestart()
    {
        if (confirmOption == 1)
        {
            confirmMenu.gameObject.SetActive(false);
            gameOverButtons = GameObject.FindGameObjectsWithTag("GameOverButtonsWin");
            OnAndOffButton(gameOverButtons);
            gameOverButtons = GameObject.FindGameObjectsWithTag("GameOverButtonsLose");
            OnAndOffButton(gameOverButtons);
            endGameScreen.gameObject.SetActive(false);
            EventSystem.current.SetSelectedGameObject(null);

            if (player.playerRemoveADs == false)
            {
                adManager.PlayGameOverAD(RestartAdFinished);
            }
            else
            {
                RestartAdFinished();
            }

        }
        else if (confirmOption == 0)
        {
            confirmMenu.gameObject.SetActive(false);
            gameOverButtons = GameObject.FindGameObjectsWithTag("GameOverButtonsWin");
            OnAndOffButton(gameOverButtons);
            gameOverButtons = GameObject.FindGameObjectsWithTag("GameOverButtonsLose");
            OnAndOffButton(gameOverButtons);
            endGameScreen.gameObject.SetActive(false);
            EventSystem.current.SetSelectedGameObject(null);

            if (player.playerRemoveADs == false)
            {
                adManager.PlayGameOverAD(RestartAd1Finished);
            }
            else
            {
                RestartAd1Finished();
            }

        }
    }

    public void CloseGameOverMenu(int option)
    {
        if (option == 0)
        {
            Time.timeScale = 1f;
            endGameScreen.gameObject.SetActive(false);
            shader.gameObject.SetActive(false);
            HUD.gameObject.SetActive(true);
            gameController.paused = true;
            gameController.GameStartCountDown();
        }
        else if (option == 1)
        {
            confirmMenu.gameObject.SetActive(false);
            gameOverButtons = GameObject.FindGameObjectsWithTag("GameOverButtonsWin");
            OnAndOffButton(gameOverButtons);
            gameOverButtons = GameObject.FindGameObjectsWithTag("GameOverButtonsLose");
            OnAndOffButton(gameOverButtons);
            confirmShader.gameObject.SetActive(false);
        }
        EventSystem.current.SetSelectedGameObject(null);

    }
}