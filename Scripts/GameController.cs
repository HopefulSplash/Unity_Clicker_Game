using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static int animalNumber;
    public static int levelNumber;
    public static bool justLooking;
    public GameObject shaderObj;
    public Button potionToggle;
    public Button attackToggle;
    public Sprite attackEnabled;
    public Sprite attackDisabled;
    public Sprite potionNon;
    public Sprite potionEnabled;
    public Sprite potionDisabled;
    public Settings settingsMenu;
    public Player player;
    public PauseMenu pause;
    public AudioSource backgroundMusic;
    public KeepAudio keepAudio;
    float gameCNTDW = 3.2f;
    public List<GameObject> HUDButtons;
    public Image startGameImage;
    public bool attackNow = false;
    public bool potionNow = false;
    public Sprite[] countDownSprites;
    public int playerPotionNumber;
    public Text playerPotionText;
    public EndGameScript EndGameScript;
    public bool winOrLose = false;
    public AnimalSpawner animalSpawner;
    public Sprite starGotImage;
    public Sprite starNotImage;
    public bool paused = true;
    public bool startGameCountDown = false;
    public bool notStart = true;
    public GameObject timerBar;
    float timeBarTick = 0;
    public Image[] gameStars;
    public Sprite completedStar;
    public Sprite unCompletedStar;
    float cntdnw = 0f;
    public int thisGameScore;
    public Text thisGamePoints;
    public GameObject[] Foreground;
    public bool[] mobsSpawned = { false, false, false, false, false };
    public LevelManagerLoader LevelLoaderScript;
    public int smallMobs;
    public int mediumMobs;
    public int largeMobs;
    public int sheildMobs;
    public int bossMobs;
    public int oneStar;
    public int twoStar;
    public int threeStar;
    public int smallHp;
    public int mediumHp;
    public int largeHp;
    public int sheildHp;
    public int bossHp;
    public int smallPoiints;
    public int mediumPoiints;
    public int largePoiints;
    public int sheildPoiints;
    public int bossPoiints;
    public float timeBonus;
    public int killCount = 0;
    public float timeRemaining;
    public int totalMobs;
    public int totalClickCountGame = 0;
    float val;
    public int smallLeft;
    public int mediumLeft;
    public int largeLeft;
    public int sheildLeft;
    public int bossLeft;
    public bool setup;
    public double max = 2.5;
    public double min = 0.5;
    public double mediumSpawnTimer = 3;
    public double largeSpawnTimer = 2.5;
    public double sheildSpawnTimer = 2;
    public double bossSpawnTimer = 1.5;

    public int AninalNumber()
    {
        return animalNumber;
    }
    public int LevelNumver()
    {
        return levelNumber;
    }
    void Start()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<Player>();
        player.LoadPlayer();
        PlayServices.control.player = player;
        playerPotionNumber = player.playerPotions;
        setup = true;
        CheckPotions(playerPotionNumber);
        setup = false;
        playerPotionText.text = playerPotionNumber.ToString();
        player.playerHearts = player.playerHearts - 1;
        player.SavePlayer();
        int multiplier = (int)Math.Ceiling(player.playerAttack * 1.6);
        LevelLoaderScript.SetupLevelManager(animalNumber, levelNumber);
        totalClickCountGame = 0;
        cntdnw = LevelLoaderScript.levelTime;
        smallMobs = LevelLoaderScript.mobsList[0];
        mediumMobs = LevelLoaderScript.mobsList[1];
        largeMobs = LevelLoaderScript.mobsList[2];
        sheildMobs = LevelLoaderScript.mobsList[3];
        bossMobs = LevelLoaderScript.mobsList[4];
        smallLeft = smallMobs;
        mediumLeft = mediumMobs;
        largeLeft = largeMobs;
        sheildLeft = sheildMobs;
        bossLeft = bossMobs;
        oneStar = LevelLoaderScript.oneStarScore;
        twoStar = LevelLoaderScript.twoStarScore;
        threeStar = LevelLoaderScript.threeStarScore;
        smallHp = LevelLoaderScript.mobsHPList[0] * multiplier;
        mediumHp = LevelLoaderScript.mobsHPList[1] * multiplier;
        largeHp = LevelLoaderScript.mobsHPList[2] * multiplier;
        sheildHp = LevelLoaderScript.mobsHPList[3] * multiplier;
        bossHp = LevelLoaderScript.mobsHPList[4] * multiplier;
        smallPoiints = LevelLoaderScript.mobsPointsList[0];
        mediumPoiints = LevelLoaderScript.mobsPointsList[1];
        largePoiints = LevelLoaderScript.mobsPointsList[2];
        sheildPoiints = LevelLoaderScript.mobsPointsList[3];
        bossPoiints = LevelLoaderScript.mobsPointsList[4];
        timeBonus = LevelLoaderScript.levelTimePoints;
        totalMobs = smallMobs + mediumMobs + largeMobs + sheildMobs + bossMobs;
        startGameImage.gameObject.SetActive(false);
        HUDButtons.Add(GameObject.FindGameObjectWithTag("pauseButton"));
        HUDButtons.Add(GameObject.FindGameObjectWithTag("muteButton"));
        HUDButtons.Add(GameObject.FindGameObjectWithTag("attackToggle"));
        HUDButtons.Add(GameObject.FindGameObjectWithTag("potionToggle"));
        OnAndOffButton(HUDButtons.ToArray());
        StartCoroutine(WaitForFade(0.7f));
        if (levelNumber == 10)
        {
            keepAudio.SetBossBackgroubdMusic();
        }
        backgroundMusic.volume = player.backgroundMusicLevelSettings;
        keepAudio.UpdateSFXSound(player.SFXMusicLevelSettings, "Load");
        keepAudio.UpdateMuteButton(backgroundMusic.volume);
        settingsMenu.tempMusicVol = player.backgroundMusicLevelSettings;
        settingsMenu.tempSFXvol = player.SFXMusicLevelSettings;
        shaderObj.SetActive(false);
        settingsMenu.UpdateSettingsMenu();
        settingsMenu.GameSettingsUpdate();
        EndGameScript.DontShowEndScreen();
        pause.UpdatePauseMenu();
        SetupTimerBar();
        SetupStars(0);
        randomMobSpawnTime();
        GameController.justLooking = false;
    }
    public void SetupStars(int numberOfStars)
    {
        switch (numberOfStars)
        {
            case 0:
                foreach (Image i in gameStars)
                {
                    i.GetComponent<Image>().sprite = starNotImage;
                }
                break;
            case 1:
                gameStars[0].GetComponent<Image>().sprite = starGotImage;
                break;
            case 2:
                gameStars[0].GetComponent<Image>().sprite = starGotImage;
                gameStars[1].GetComponent<Image>().sprite = starGotImage;
                break;
            case 3:
                gameStars[0].GetComponent<Image>().sprite = starGotImage;
                gameStars[1].GetComponent<Image>().sprite = starGotImage;
                gameStars[2].GetComponent<Image>().sprite = starGotImage;
                break;
        }
    }
    public void CheckPotions(int potionNo)
    {
        playerPotionText.text = playerPotionNumber.ToString();
        if (potionNo == 0)
        {
            GameObject temp = GameObject.FindGameObjectWithTag("potionToggle");
            potionToggle = temp.GetComponent<Button>();
            potionToggle.GetComponent<Image>().sprite = potionNon;
            if (setup)
            {
                SwordPressed(1);
            }
            else
            {
                SwordPressed(0);
            }
            
        }
        else if (potionNo != 0)
        {
            GameObject temp = GameObject.FindGameObjectWithTag("potionToggle");
            potionToggle = temp.GetComponent<Button>();
            potionToggle.GetComponent<Image>().sprite = potionEnabled;
            potionToggle.GetComponent<Button>().interactable = true;
            PotionPressed(1);
        }
    }
    IEnumerator WaitForFade(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        startGameImage.gameObject.SetActive(true);
        startGameCountDown = true;
        keepAudio.PlayGoSFX();
    }
    public void GameStartCountDown()
    {
        startGameImage.gameObject.SetActive(true);
        gameCNTDW = 3f;
        startGameCountDown = true;
        keepAudio.PlayGoSFX();
    }
    public void OnAndOffButton(GameObject[] gameObject)
    {
        for (int i = 0; i <= gameObject.Length - 1; i++)
        {
            Button button = gameObject[i].GetComponent<Button>();
            button.interactable = !button.interactable;
        }
    }

    
    public void randomMobSpawnTime()
    {
        System.Random r = new System.Random();
        int i = (int)(r.NextDouble() * (10 - 0) + 0);

        System.Random randomM = new System.Random((int)DateTime.Now.Ticks & (0x0000FFFF + i));
        mediumSpawnTimer = (float)(randomM.NextDouble() * (2.3 - mediumSpawnTimer) + mediumSpawnTimer);
        System.Random randomL = new System.Random((int)DateTime.Now.Ticks & (0x0000FFFF + i));
        largeSpawnTimer = (float)(randomL.NextDouble() * (1.9 - largeSpawnTimer) + largeSpawnTimer);
        System.Random randomS = new System.Random((int)DateTime.Now.Ticks & (0x0000FFFF + i));
        sheildSpawnTimer = (float)(randomS.NextDouble() * (1.4 - sheildSpawnTimer) + sheildSpawnTimer);
        System.Random randomB = new System.Random((int)DateTime.Now.Ticks & (0x0000FFFF + i));
        bossSpawnTimer = (float)(randomB.NextDouble() * (1.1 - bossSpawnTimer) + bossSpawnTimer);
    }
    public void randomValues(int i)
    {
        System.Random randomMin = new System.Random((int)DateTime.Now.Ticks & (0x0000FFFF + i));
        min = (float)(randomMin.NextDouble() * (0.5 - 0.1) + 0.1);
        System.Random randomMax = new System.Random((int)DateTime.Now.Ticks & (0x0000FFFF + i));
        max = (float)(randomMax.NextDouble() * (2.5 - min) + min);
        System.Random random = new System.Random((int)DateTime.Now.Ticks & (0x0000FFFF + i));
        val = (float)(random.NextDouble() * (max - min) + min);
    }

    public void SpawnTimer()
    {
        if (mobsSpawned[0] == false)
        {
            if (timeBarTick >= 0f)
            {
                mobsSpawned[0] = true;
                for (int i = 0; i < smallMobs; i++)
                {
                    randomValues(i);
                    StartCoroutine(SpawnTimerWait(1, smallHp, val));
                }

            }

        }
        else if (mobsSpawned[1] == false)
        {
            if (smallLeft == 0 || timeBarTick > cntdnw / mediumSpawnTimer)
            {
                mobsSpawned[1] = true;
                for (int i = 0; i < mediumMobs; i++)
                {
                    randomValues(i);
                    StartCoroutine(SpawnTimerWait(2, mediumHp, val));
                }

            }

        }
        else if (mobsSpawned[2] == false)
        {
            if (mediumLeft == 0 || timeBarTick > cntdnw / largeSpawnTimer)
            {
                mobsSpawned[2] = true;
                for (int i = 0; i < largeMobs; i++)
                {
                    randomValues(i);
                    StartCoroutine(SpawnTimerWait(3, largeHp, val));
                }

            }

        }
        else if (mobsSpawned[3] == false)
        {
            if (largeLeft == 0 || timeBarTick > cntdnw / sheildSpawnTimer)
            {
                mobsSpawned[3] = true;
                for (int i = 0; i < sheildMobs; i++)
                {
                    randomValues(i);
                    StartCoroutine(SpawnTimerWait(4, sheildHp, val));
                }

            }

        }
        else if (mobsSpawned[4] == false)
        {
            if (sheildLeft == 0 || timeBarTick > cntdnw / bossSpawnTimer)
            {
                mobsSpawned[4] = true;
                for (int i = 0; i < bossMobs; i++)
                {
                    randomValues(i);
                    StartCoroutine(SpawnTimerWait(5, bossHp, val));
                }

            }

        }
    }
    IEnumerator SpawnTimerWait(int mobType, int hpType, float val)
    {
        while (paused)
        {
            yield return null;
        }

        yield return new WaitForSeconds(val);

        StartCoroutine(SpawnAnimal(mobType, hpType, val));
    }


    private bool noSpawnerInactive()
    {
        for (int i = 0; i < Foreground.GetLength(0); i++)
        {
            if (Foreground[i].activeInHierarchy != true)
                return false;
        }
        return true;
    }
    IEnumerator SpawnAnimal(int mobType, int hpType, float waitTime)
    {
 
        bool waited = false;
        while (paused)
        {
            waited = true;
            yield return null;
        }

        if (waited)
        { 
            yield return new WaitForSeconds(waitTime);
            while (!noSpawnerInactive())
            {
                yield return null;
            }
            animalSpawner.SPawn(mobType, animalNumber, hpType);
            yield return null;
        }
        else
        {
            while (!noSpawnerInactive())
            {
                yield return null;
            }
            animalSpawner.SPawn(mobType, animalNumber, hpType);
            yield return null;
        }
    }
    void Update()
    {
        if (killCount == totalMobs)
        {
            if (cntdnw >= 0)
            {
                timeRemaining = cntdnw - timeBarTick;
                int timeLoop = (int)Math.Ceiling(timeRemaining);
                timeLoop = timeLoop * -1;
                for (int i = 0; i <= timeLoop; i++)
                {
                    thisGameScore = thisGameScore + (int)LevelLoaderScript.levelTimePoints;
                }
               
                cntdnw = -1;
            }
        }

        if (paused == false)
        {
            if (cntdnw >= 0)
            {
                SpawnTimer();
                cntdnw -= Time.deltaTime;
                timeBarTick += Time.deltaTime;
                CheckStarScore();
            }
            else
            {
                timerEnded();
            }
            double b = System.Math.Round(cntdnw, 2);
            timerBar.GetComponent<Slider>().value = timeBarTick;
        }
        else
        {
            if (startGameCountDown == true)
            {
                if (gameCNTDW >= 0)
                {
                    gameCNTDW -= Time.deltaTime;

                }
                else
                {
                    GameStartTimerEnded();
                }
                 double b = System.Math.Round(gameCNTDW, 1);
                switch (b)
                {
                    case 0:
                        startGameImage.GetComponent<Image>().sprite = countDownSprites[0];
                        
                        break;
                    case 1:
                        startGameImage.GetComponent<Image>().sprite = countDownSprites[1];
                        break;
                    case 2:
                        startGameImage.GetComponent<Image>().sprite = countDownSprites[2];
                        break;
                    case 3:
                        startGameImage.GetComponent<Image>().sprite = countDownSprites[3];
                        break;
                    case 4:
                        startGameImage.GetComponent<Image>().sprite = countDownSprites[4];
                        break;
                    case 5:
                        startGameImage.GetComponent<Image>().sprite = countDownSprites[5];
                        break;
                    default:
                        break;

                }
            }
            else
            {
            }

        }
    }

    public void timerEnded()
    {
        OnAndOffButton(HUDButtons.ToArray());
        paused = true;
        startGameCountDown = false;
        StartCoroutine(WaitForEnd());
    }
    IEnumerator WaitForEnd()
    {
        keepAudio.PlayGameOverSFX();
        yield return new WaitForSeconds(0.4f);
        keepAudio.StopGameBackgroundMusic();
        EndGameScript.rewardLose = LevelLoaderScript.loseRewards;
        EndGameScript.rewardWin = LevelLoaderScript.winRewards;
        EndGameScript.ShowEndScreenMenu(winOrLose);
        GameObject[] gameOverButtons;
        gameOverButtons = GameObject.FindGameObjectsWithTag("GameOverButtonsWin");
        OnAndOffButton(gameOverButtons);
        gameOverButtons = GameObject.FindGameObjectsWithTag("GameOverButtonsLose");
        OnAndOffButton(gameOverButtons);

        while (keepAudio.gameOverSound.isPlaying)
        {
            yield return null;
        }

        gameOverButtons = GameObject.FindGameObjectsWithTag("GameOverButtonsWin");
        OnAndOffButton(gameOverButtons);
        gameOverButtons = GameObject.FindGameObjectsWithTag("GameOverButtonsLose");
        OnAndOffButton(gameOverButtons);
        EndGameScript.CheckButton();
    }
    IEnumerator WaitForStart(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        startGameImage.gameObject.SetActive(false);
        
        OnAndOffButton(HUDButtons.ToArray());
        foreach (GameObject element in Foreground)
        {
            element.SetActive(true);
            animalSpawner.CleanUpAnimals(element);
        }
        keepAudio.PlayGameBackgroundMusic(player.backgroundMusicLevelSettings);
        paused = false;
    }
    public void GameStartTimerEnded()
    {
        startGameCountDown = false;
        StartCoroutine(WaitForStart(1f));   
    }
    public void SwordPressed(int option)
    {
        if (attackNow == false)
        {
            if (option == 0)
            {
                GameObject temp = GameObject.FindGameObjectWithTag("attackToggle");
                GameObject temp1 = GameObject.FindGameObjectWithTag("potionToggle");
                attackToggle = temp.GetComponent<Button>();
                potionToggle = temp1.GetComponent<Button>();
                attackToggle.GetComponent<Image>().sprite = attackEnabled;
                if (playerPotionNumber != 0)
                {
                    potionToggle.GetComponent<Image>().sprite = potionDisabled;
                }
                attackNow = true;
                potionNow = false;
                keepAudio.PlaySwordSFX();
            }
            else if (option == 1)
            {
                GameObject temp = GameObject.FindGameObjectWithTag("attackToggle");
                GameObject temp1 = GameObject.FindGameObjectWithTag("potionToggle");
                attackToggle = temp.GetComponent<Button>();
                potionToggle = temp1.GetComponent<Button>();
                attackToggle.GetComponent<Image>().sprite = attackEnabled;
                if (playerPotionNumber != 0)
                {
                    potionToggle.GetComponent<Image>().sprite = potionDisabled;
                }
                attackNow = true;
                potionNow = false;
            }
        }
      
    }
    public void PotionPressed(int option)
    {
        if (playerPotionNumber != 0)
        {
            if (potionNow == false)
            {
                if (option == 0)
                {
                    keepAudio.PlayPotionSFX();
                    GameObject temp = GameObject.FindGameObjectWithTag("attackToggle");
                    GameObject temp1 = GameObject.FindGameObjectWithTag("potionToggle");
                    attackToggle = temp.GetComponent<Button>();
                    potionToggle = temp1.GetComponent<Button>();
                    attackToggle.GetComponent<Image>().sprite = attackDisabled;
                    potionToggle.GetComponent<Image>().sprite = potionEnabled;
                    attackNow = false;
                    potionNow = true;
                }
                else if (option == 1)
                {
                    GameObject temp = GameObject.FindGameObjectWithTag("attackToggle");
                    GameObject temp1 = GameObject.FindGameObjectWithTag("potionToggle");
                    attackToggle = temp.GetComponent<Button>();
                    potionToggle = temp1.GetComponent<Button>();
                    attackToggle.GetComponent<Image>().sprite = attackDisabled;
                    potionToggle.GetComponent<Image>().sprite = potionEnabled;
                    attackNow = false;
                    potionNow = true;
                }
            }
        }
        else
        {
            keepAudio.PlayButtonErrorSFX();
        }
    }

    public void SetupTimerBar()
    {
        timerBar = GameObject.FindGameObjectWithTag("TimeBar");
        timerBar.GetComponent<Slider>().maxValue = cntdnw;
        timerBar.GetComponent<Slider>().value = 0;
    }

    public void CheckStarScore()
    {
        if (thisGameScore > threeStar)
        {
            gameStars[0].sprite = completedStar;
            gameStars[1].sprite = completedStar;
            gameStars[2].sprite = completedStar;
            winOrLose = true;
        }
        else if (thisGameScore < threeStar && thisGameScore > twoStar)
        {
            gameStars[0].sprite = completedStar;
            gameStars[1].sprite = completedStar;
            winOrLose = true;
        }
        else if (thisGameScore < threeStar && thisGameScore < twoStar && thisGameScore > oneStar)
        {
            gameStars[0].sprite = completedStar;
            winOrLose = true;
        }
        else
        {
            gameStars[0].sprite = unCompletedStar;
            gameStars[1].sprite = unCompletedStar;
            gameStars[2].sprite = unCompletedStar;
            winOrLose = false;
        }
    }
}
