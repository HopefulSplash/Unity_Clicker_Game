using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveSystem 
{
    public static void SavePlayer (Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/playerpreftest1.dvo";
        
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static void checkIfSystemFile()
    {
        string path = Application.persistentDataPath + "/playerpreftest1.dvo";

        if (File.Exists(path))
        {
        }
        else
        {
            Player newPlayer = new Player();
            int[] newPlayerTemplate = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            newPlayer.SFXMusicLevel = 1;
            newPlayer.SFXMusicLevel = 1;
            newPlayer.backgroundMusicLevel = 1;
            newPlayer.backgroundMusicLevelSettings = 1;
            newPlayer.playerCoins = 0;
            newPlayer.playerGems = 5;
            newPlayer.playerAttack = 1;
            newPlayer.playerHearts = 5;
            newPlayer.playerPotions = 1;
            newPlayer.playerRestore = false;
            newPlayer.playerRemoveADs = false;
            newPlayer.questOneStageCompleted = false;
            newPlayer.questOneCoinReward = 50;
            newPlayer.questOneGemReward = 1;
            newPlayer.questOneProgress = 0;
            newPlayer.questOneGoal = 100;
            newPlayer.questTwoStageCompleted = false;
            newPlayer.questTwoCoinReward = 100;
            newPlayer.questTwoGemReward = 2;
            newPlayer.questTwoProgress = 0;
            newPlayer.questTwoGoal = 15;
            newPlayer.questThreeStageCompleted = true;
            newPlayer.questThreeCoinReward = 100;
            newPlayer.questThreeGemReward = 10;
            newPlayer.questThreeProgress = 1;
            newPlayer.questThreeGoal = 1;
            newPlayer.chickLevelUnlocked = true;
            newPlayer.chickLevel = newPlayerTemplate;
            newPlayer.chickLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.chickenLevelUnlocked = false;
            newPlayer.chickenLevel = newPlayerTemplate;
            newPlayer.chickenLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.henLevelUnlocked = false;
            newPlayer.henLevel = newPlayerTemplate; 
            newPlayer.henLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; 
            newPlayer.duckLevelUnlocked = false;
            newPlayer.duckLevel = newPlayerTemplate;
            newPlayer.duckLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.gobblerLevelUnlocked = false;
            newPlayer.gobblerLevel = newPlayerTemplate;
            newPlayer.gobblerLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.gooseLevelUnlocked = false;
            newPlayer.gooseLevel = newPlayerTemplate;
            newPlayer.gooseLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.drakeLevelUnlocked = false;
            newPlayer.drakeLevel = newPlayerTemplate;
            newPlayer.drakeLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.turkeyLevelUnlocked = false;
            newPlayer.turkeyLevel = newPlayerTemplate;
            newPlayer.turkeyLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.roosterLevelUnlocked = false;
            newPlayer.roosterLevel = newPlayerTemplate;
            newPlayer.roosterLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.wHenLevelUnlocked = false;
            newPlayer.wHenLevel = newPlayerTemplate;
            newPlayer.wHenLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.bRoosterLevelUnlocked = false;
            newPlayer.bRoosterLevel = newPlayerTemplate;
            newPlayer.bRoosterLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.fTurkeyLevelUnlocked = false;
            newPlayer.fTurkeyLevel = newPlayerTemplate;
            newPlayer.fTurkeyLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.wRoosterLevelUnlocked = false;
            newPlayer.wRoosterLevel = newPlayerTemplate;
            newPlayer.wRoosterLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.bunnyLevelUnlocked = false;
            newPlayer.bunnyLevel = newPlayerTemplate;
            newPlayer.bunnyLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.dBunnyLevelUnlocked = false;
            newPlayer.dBunnyLevel = newPlayerTemplate;
            newPlayer.dBunnyLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.lBunnyLevelUnlocked = false;
            newPlayer.lBunnyLevel = newPlayerTemplate;
            newPlayer.lBunnyLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.cowLevelUnlocked = false;
            newPlayer.cowLevel = newPlayerTemplate;
            newPlayer.cowLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.sheepLevelUnlocked = false;
            newPlayer.sheepLevel = newPlayerTemplate;
            newPlayer.sheepLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.donkeyLevelUnlocked = false;
            newPlayer.donkeyLevel = newPlayerTemplate;
            newPlayer.donkeyLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.goatLevelUnlocked = false;
            newPlayer.goatLevel = newPlayerTemplate;
            newPlayer.goatLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.oxLevelUnlocked = false;
            newPlayer.oxLevel = newPlayerTemplate;
            newPlayer.oxLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.ramLevelUnlocked = false;
            newPlayer.ramLevel = newPlayerTemplate;
            newPlayer.ramLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.bullLevelUnlocked = false;
            newPlayer.bullLevel = newPlayerTemplate;
            newPlayer.bullLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.burroLevelUnlocked = false;
            newPlayer.burrpLevel = newPlayerTemplate;
            newPlayer.burroLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.wGoatLevelUnlocked = false;
            newPlayer.wGoatLevel = newPlayerTemplate;
            newPlayer.wGoatLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.pugLevelUnlocked = false;
            newPlayer.pugLevel = newPlayerTemplate;
            newPlayer.pugLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.ponyLevelUnlocked = false;
            newPlayer.ponyLevel =  newPlayerTemplate;
            newPlayer.ponyLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; ;
            newPlayer.horseLevelUnlocked = false;
            newPlayer.horseLevel = newPlayerTemplate;
            newPlayer.horseLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.piggyLevelUnlocked = false;
            newPlayer.piggyLevel = newPlayerTemplate;
            newPlayer.piggyLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.pigLevelUnlocked = false;
            newPlayer.pigLevel = newPlayerTemplate;
            newPlayer.pigLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.porkyLevelUnlocked = false;
            newPlayer.porkyLevel = newPlayerTemplate;
            newPlayer.porkyLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            newPlayer.swineLevelUnlocked = false;
            newPlayer.swineLevel = newPlayerTemplate;
            newPlayer.swineLevelStars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            
            SaveSystem.SavePlayer(newPlayer);
        }
    }
    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/playerpreftest1.dvo";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            return null;
        }
    }
}
