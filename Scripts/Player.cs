using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float backgroundMusicLevel;
    public float backgroundMusicLevelSettings;
    public float SFXMusicLevel;
    public float SFXMusicLevelSettings;
    public int playerCoins;
    public int playerGems;
    public int playerAttack;
    public int playerHearts;
    public int playerPotions;
    public bool playerRestore;
    public bool playerRemoveADs;

    //quest 1
    public bool questOneStageCompleted;
    public int questOneCoinReward;
    public int questOneGemReward;
    public int questOneProgress;
    public int questOneGoal;
    //quest 2
    public bool questTwoStageCompleted;
    public int questTwoCoinReward;
    public int questTwoGemReward;
    public int questTwoProgress;
    public int questTwoGoal;
    //quest 3
    public bool questThreeStageCompleted;
    public int questThreeCoinReward;
    public int questThreeGemReward;
    public int questThreeProgress;
    public int questThreeGoal;


    //Animal + Level
    public bool chickLevelUnlocked;
    public int[] chickLevel; //= {1,2,3,4,5,6,7,8,9,10};
    public int[] chickLevelStars; // = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    //Animal + Level
    public bool chickenLevelUnlocked;
    public int[] chickenLevel;
    public int[] chickenLevelStars;
    //Animal + Level
    public bool henLevelUnlocked;
    public int[] henLevel;
    public int[] henLevelStars;
    //Animal + Level
    public bool duckLevelUnlocked;
    public int[] duckLevel;
    public int[] duckLevelStars;
    //Animal + Level
    public bool gobblerLevelUnlocked;
    public int[] gobblerLevel;
    public int[] gobblerLevelStars;
    //Animal + Level
    public bool gooseLevelUnlocked;
    public int[] gooseLevel;
    public int[] gooseLevelStars;
    //Animal + Level
    public bool drakeLevelUnlocked;
    public int[] drakeLevel;
    public int[] drakeLevelStars;
    //Animal + Level
    public bool turkeyLevelUnlocked;
    public int[] turkeyLevel;
    public int[] turkeyLevelStars;
    //Animal + Level
    public bool roosterLevelUnlocked;
    public int[] roosterLevel;
    public int[] roosterLevelStars;
    //Animal + Level
    public bool wHenLevelUnlocked;
    public int[] wHenLevel;
    public int[] wHenLevelStars;
    //Animal + Level
    public bool bRoosterLevelUnlocked;
    public int[] bRoosterLevel;
    public int[] bRoosterLevelStars;
    //Animal + Level
    public bool fTurkeyLevelUnlocked;
    public int[] fTurkeyLevel;
    public int[] fTurkeyLevelStars;
    //Animal + Level
    public bool wRoosterLevelUnlocked;
    public int[] wRoosterLevel;
    public int[] wRoosterLevelStars;
    //Animal + Level
    public bool bunnyLevelUnlocked;
    public int[] bunnyLevel;
    public int[] bunnyLevelStars;
    //Animal + Level
    public bool dBunnyLevelUnlocked;
    public int[] dBunnyLevel;
    public int[] dBunnyLevelStars;
    //Animal + Level
    public bool lBunnyLevelUnlocked;
    public int[] lBunnyLevel;
    public int[] lBunnyLevelStars;
    //Animal + Level
    public bool cowLevelUnlocked;
    public int[] cowLevel;
    public int[] cowLevelStars;
    //Animal + Level
    public bool sheepLevelUnlocked;
    public int[] sheepLevel;
    public int[] sheepLevelStars;
    //Animal + Level
    public bool donkeyLevelUnlocked;
    public int[] donkeyLevel;
    public int[] donkeyLevelStars;
    //Animal + Level
    public bool goatLevelUnlocked;
    public int[] goatLevel;
    public int[] goatLevelStars;
    //Animal + Level
    public bool oxLevelUnlocked;
    public int[] oxLevel;
    public int[] oxLevelStars;
    //Animal + Level
    public bool ramLevelUnlocked;
    public int[] ramLevel;
    public int[] ramLevelStars;
    //Animal + Level
    public bool bullLevelUnlocked;
    public int[] bullLevel;
    public int[] bullLevelStars;
    //Animal + Level
    public bool burroLevelUnlocked;
    public int[] burrpLevel;
    public int[] burroLevelStars;
    //Animal + Level
    public bool wGoatLevelUnlocked;
    public int[] wGoatLevel;
    public int[] wGoatLevelStars;
    //Animal + Level
    public bool pugLevelUnlocked;
    public int[] pugLevel;
    public int[] pugLevelStars;
    //Animal + Level
    public bool ponyLevelUnlocked;
    public int[] ponyLevel;
    public int[] ponyLevelStars;
    //Animal + Level
    public bool horseLevelUnlocked;
    public int[] horseLevel;
    public int[] horseLevelStars;
    //Animal + Level
    public bool piggyLevelUnlocked;
    public int[] piggyLevel;
    public int[] piggyLevelStars;
    //Animal + Level
    public bool pigLevelUnlocked;
    public int[] pigLevel;
    public int[] pigLevelStars;
    //Animal + Level
    public bool porkyLevelUnlocked;
    public int[] porkyLevel;
    public int[] porkyLevelStars;
    //Animal + Level
    public bool swineLevelUnlocked;
    public int[] swineLevel;
    public int[] swineLevelStars;

    public void SavePlayer()
    {

        //set stuff
        
        SaveSystem.SavePlayer(this);
      
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        backgroundMusicLevel = data.backgroundMusicLevelSettings;
        backgroundMusicLevelSettings = data.backgroundMusicLevelSettings;
        SFXMusicLevel = data.SFXMusicLevel;
        SFXMusicLevelSettings = data.SFXMusicLevelSettings;
        playerCoins = data.playerCoins;
        playerGems = data.playerGems;
        playerAttack = data.playerAttack;
        playerHearts = data.playerHearts;
        playerPotions = data.playerPotions;
        playerRestore = data.playerRestore;
        playerRemoveADs = data.playerRemoveADs;
        questOneStageCompleted = data.questOneStageCompleted;
        questOneCoinReward = data.questOneCoinReward;
        questOneGemReward = data.questOneGemReward;
        questOneProgress = data.questOneProgress;
        questOneGoal = data.questOneGoal;
        questTwoStageCompleted = data.questTwoStageCompleted;
        questTwoCoinReward = data.questTwoCoinReward;
        questTwoGemReward = data.questTwoGemReward;
        questTwoProgress = data.questTwoProgress;
        questTwoGoal = data.questTwoGoal;
        questThreeStageCompleted = data.questThreeStageCompleted;
        questThreeCoinReward = data.questThreeCoinReward;
        questThreeGemReward = data.questThreeGemReward;
        questThreeProgress = data.questThreeProgress;
        questThreeGoal= data.questThreeGoal;
        chickLevelUnlocked = data.chickLevelUnlocked;
        chickLevel = data.chickLevel;
        chickLevelStars = data.chickLevelStars;
        chickenLevelUnlocked = data.chickenLevelUnlocked;
        chickenLevel = data.chickenLevel;
        chickenLevelStars = data.chickenLevelStars;
        henLevelUnlocked = data.henLevelUnlocked;
        henLevel = data.henLevel;
        henLevelStars = data.henLevelStars;
        duckLevelUnlocked = data.duckLevelUnlocked;
        duckLevel = data.duckLevel;
        duckLevelStars = data.duckLevelStars;
        gobblerLevelUnlocked = data.gobblerLevelUnlocked;
        gobblerLevel = data.gobblerLevel;
        gobblerLevelStars = data.gobblerLevelStars;
        gooseLevelUnlocked = data.gooseLevelUnlocked;
        gooseLevel = data.gooseLevel;
        gooseLevelStars = data.gooseLevelStars;
        drakeLevelUnlocked = data.drakeLevelUnlocked;
        drakeLevel = data.drakeLevel;
        drakeLevelStars = data.drakeLevelStars;
        turkeyLevelUnlocked = data.turkeyLevelUnlocked;
        turkeyLevel = data.turkeyLevel;
        turkeyLevelStars = data.turkeyLevelStars;
        roosterLevelUnlocked = data.roosterLevelUnlocked;
        roosterLevel = data.roosterLevel;
        roosterLevelStars = data.roosterLevelStars;
        wHenLevelUnlocked = data.wHenLevelUnlocked;
        wHenLevel = data.wHenLevel;
        wHenLevelStars = data.wHenLevelStars;
        bRoosterLevelUnlocked = data.bRoosterLevelUnlocked;
        bRoosterLevel = data.bRoosterLevel;
        bRoosterLevelStars = data.bRoosterLevelStars;
        fTurkeyLevelUnlocked = data.fTurkeyLevelUnlocked;
        fTurkeyLevel = data.fTurkeyLevel;
        fTurkeyLevelStars = data.fTurkeyLevelStars;
        wRoosterLevelUnlocked = data.wRoosterLevelUnlocked;
        wRoosterLevel = data.wRoosterLevel;
        wRoosterLevelStars = data.wRoosterLevelStars;
        bunnyLevelUnlocked = data.bunnyLevelUnlocked;
        bunnyLevel = data.bunnyLevel;
        bunnyLevelStars = data.bunnyLevelStars;
        dBunnyLevelUnlocked = data.dBunnyLevelUnlocked;
        dBunnyLevel = data.dBunnyLevel;
        dBunnyLevelStars = data.dBunnyLevelStars;
        lBunnyLevelUnlocked = data.lBunnyLevelUnlocked;
        lBunnyLevel = data.lBunnyLevel;
        lBunnyLevelStars = data.lBunnyLevelStars;
        cowLevelUnlocked = data.cowLevelUnlocked;
        cowLevel = data.cowLevel;
        cowLevelStars = data.cowLevelStars;
        sheepLevelUnlocked = data.sheepLevelUnlocked;
        sheepLevel = data.sheepLevel;
        sheepLevelStars = data.sheepLevelStars;
        donkeyLevelUnlocked = data.donkeyLevelUnlocked;
        donkeyLevel = data.donkeyLevel;
        donkeyLevelStars = data.donkeyLevelStars;
        goatLevelUnlocked = data.goatLevelUnlocked;
        goatLevel = data.goatLevel;
        goatLevelStars = data.goatLevelStars;
        oxLevelUnlocked = data.oxLevelUnlocked;
        oxLevel = data.oxLevel;
        oxLevelStars = data.oxLevelStars;
        ramLevelUnlocked = data.ramLevelUnlocked;
        ramLevel = data.ramLevel;
        ramLevelStars = data.ramLevelStars;
        bullLevelUnlocked = data.bullLevelUnlocked;
        bullLevel = data.bullLevel;
        bullLevelStars = data.bullLevelStars;
        burroLevelUnlocked = data.burroLevelUnlocked;
        burrpLevel = data.burrpLevel;
        burroLevelStars = data.burroLevelStars;
        wGoatLevelUnlocked = data.wGoatLevelUnlocked;
        wGoatLevel = data.wGoatLevel;
        wGoatLevelStars = data.wGoatLevelStars;
        pugLevelUnlocked = data.pugLevelUnlocked;
        pugLevel = data.pugLevel;
        pugLevelStars = data.pugLevelStars;
        ponyLevelUnlocked = data.ponyLevelUnlocked;
        ponyLevel = data.ponyLevel;
        ponyLevelStars = data.ponyLevelStars;
        horseLevelUnlocked = data.horseLevelUnlocked;
        horseLevel = data.horseLevel;
        horseLevelStars = data.horseLevelStars;
        piggyLevelUnlocked = data.piggyLevelUnlocked;
        piggyLevel = data.piggyLevel;
        piggyLevelStars = data.piggyLevelStars;
        pigLevelUnlocked = data.pigLevelUnlocked;
        pigLevel = data.pigLevel;
        pigLevelStars = data.pigLevelStars;
        porkyLevelUnlocked = data.porkyLevelUnlocked;
        porkyLevel = data.porkyLevel;
        porkyLevelStars = data.porkyLevelStars;
        swineLevelUnlocked = data.swineLevelUnlocked;
        swineLevel = data.swineLevel;
        swineLevelStars = data.swineLevelStars;

    }


}
