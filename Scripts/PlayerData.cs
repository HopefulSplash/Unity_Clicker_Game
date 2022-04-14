using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerData 
{
    private float backgroundMusicLevel;
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

    public PlayerData (Player player)
    {
        backgroundMusicLevel = player.backgroundMusicLevel;
        backgroundMusicLevelSettings = player.backgroundMusicLevelSettings;
        SFXMusicLevel = player.SFXMusicLevel;
        SFXMusicLevelSettings = player.SFXMusicLevelSettings;
        playerCoins = player.playerCoins;
        playerGems = player.playerGems;
        playerAttack = player.playerAttack;
        playerHearts = player.playerHearts;
        playerPotions = player.playerPotions;
        playerRestore = player.playerRestore;
        playerRemoveADs = player.playerRemoveADs;
        questOneStageCompleted = player.questOneStageCompleted;
        questOneCoinReward = player.questOneCoinReward;
        questOneGemReward = player.questOneGemReward;
        questOneProgress = player.questOneProgress;
        questOneGoal = player.questOneGoal;
        questTwoStageCompleted = player.questTwoStageCompleted;
        questTwoCoinReward = player.questTwoCoinReward;
        questTwoGemReward = player.questTwoGemReward;
        questTwoProgress = player.questTwoProgress;
        questTwoGoal = player.questTwoGoal;
        questThreeStageCompleted = player.questThreeStageCompleted;
        questThreeCoinReward = player.questThreeCoinReward;
        questThreeGemReward = player.questThreeGemReward;
        questThreeProgress = player.questThreeProgress;
        questThreeGoal = player.questThreeGoal;
        chickLevelUnlocked = player.chickLevelUnlocked;
      chickLevel = player.chickLevel; 
      chickLevelStars = player.chickLevelStars; 
      chickenLevelUnlocked = player.chickenLevelUnlocked;
      chickenLevel = player.chickenLevel;
      chickenLevelStars = player.chickenLevelStars; 
      henLevelUnlocked = player.henLevelUnlocked;
      henLevel = player.henLevel; 
      henLevelStars = player.henLevelStars; 
      duckLevelUnlocked = player.duckLevelUnlocked;
      duckLevel = player.duckLevel; 
      duckLevelStars = player.duckLevelStars;
      gobblerLevelUnlocked = player.gobblerLevelUnlocked;
      gobblerLevel = player.gobblerLevel; 
      gobblerLevelStars = player.gobblerLevelStars; 
      gooseLevelUnlocked = player.gooseLevelUnlocked;
      gooseLevel = player.gooseLevel; 
      gooseLevelStars = player.gooseLevelStars; 
      drakeLevelUnlocked = player.drakeLevelUnlocked;
      drakeLevel = player.drakeLevel;
      drakeLevelStars = player.drakeLevelStars; 
      turkeyLevelUnlocked = player.turkeyLevelUnlocked;
      turkeyLevel = player.turkeyLevel; 
      turkeyLevelStars = player.turkeyLevelStars; 
      roosterLevelUnlocked = player.roosterLevelUnlocked;
      roosterLevel = player.roosterLevel; 
      roosterLevelStars = player.roosterLevelStars; 
      wHenLevelUnlocked = player.wHenLevelUnlocked;
      wHenLevel = player.wHenLevel; 
      wHenLevelStars = player.wHenLevelStars; 
      bRoosterLevelUnlocked = player.bRoosterLevelUnlocked;
      bRoosterLevel = player.bRoosterLevel;
      bRoosterLevelStars = player.bRoosterLevelStars; 
      fTurkeyLevelUnlocked = player.fTurkeyLevelUnlocked;
      fTurkeyLevel = player.fTurkeyLevel; 
      fTurkeyLevelStars = player.fTurkeyLevelStars; 
      wRoosterLevelUnlocked = player.wRoosterLevelUnlocked;
      wRoosterLevel = player.wRoosterLevel; 
      wRoosterLevelStars = player.wRoosterLevelStars; 
      bunnyLevelUnlocked = player.bunnyLevelUnlocked;
      bunnyLevel = player.bunnyLevel; 
      bunnyLevelStars = player.bunnyLevelStars; 
      dBunnyLevelUnlocked = player.dBunnyLevelUnlocked;
      dBunnyLevel = player.dBunnyLevel; 
      dBunnyLevelStars = player.dBunnyLevelStars; 
      lBunnyLevelUnlocked = player.lBunnyLevelUnlocked;
      lBunnyLevel = player.lBunnyLevel; 
      lBunnyLevelStars = player.lBunnyLevelStars; 
      cowLevelUnlocked = player.cowLevelUnlocked;
      cowLevel = player.cowLevel; 
      cowLevelStars = player.cowLevelStars; 
      sheepLevelUnlocked = player.sheepLevelUnlocked;
      sheepLevel = player.sheepLevel; 
      sheepLevelStars = player.sheepLevelStars; 
      donkeyLevelUnlocked = player.donkeyLevelUnlocked;
      donkeyLevel = player.donkeyLevel; 
      donkeyLevelStars = player.donkeyLevelStars;
      goatLevelUnlocked = player.goatLevelUnlocked;
      goatLevel = player.goatLevel; 
      goatLevelStars = player.goatLevelStars; 
      oxLevelUnlocked = player.oxLevelUnlocked;
      oxLevel = player.oxLevel; 
      oxLevelStars = player.oxLevelStars; 
      ramLevelUnlocked = player.ramLevelUnlocked;
      ramLevel = player.ramLevel; 
      ramLevelStars = player.ramLevelStars; 
      bullLevelUnlocked = player.bullLevelUnlocked;
      bullLevel = player.bullLevel; 
      bullLevelStars = player.bullLevelStars;
      burroLevelUnlocked = player.burroLevelUnlocked;
      burrpLevel = player.burrpLevel; 
      burroLevelStars = player.burroLevelStars;
      wGoatLevelUnlocked = player.wGoatLevelUnlocked;
      wGoatLevel = player.wGoatLevel; 
      wGoatLevelStars = player.wGoatLevelStars; 
      pugLevelUnlocked = player.pugLevelUnlocked;
      pugLevel = player.pugLevel; 
      pugLevelStars = player.pugLevelStars; 
      ponyLevelUnlocked = player.ponyLevelUnlocked;
      ponyLevel = player.ponyLevel; 
      ponyLevelStars = player.ponyLevelStars;
      horseLevelUnlocked = player.horseLevelUnlocked;
      horseLevel = player.horseLevel;
      horseLevelStars = player.horseLevelStars;
      piggyLevelUnlocked = player.piggyLevelUnlocked;
      piggyLevel = player.piggyLevel;
      piggyLevelStars = player.piggyLevelStars; 
      pigLevelUnlocked = player.pigLevelUnlocked;
      pigLevel = player.pigLevel; 
      pigLevelStars = player.pigLevelStars; 
      porkyLevelUnlocked = player.porkyLevelUnlocked;
      porkyLevel = player.porkyLevel; 
      porkyLevelStars = player.porkyLevelStars;
      swineLevelUnlocked = player.swineLevelUnlocked;
      swineLevel = player.swineLevel; 
      swineLevelStars = player.swineLevelStars; 
}
}
