using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerLoader : MonoBehaviour
{
    public int levelID;
    public float levelTime;
    public float levelTimePoints;
    // rewards are Potion/Gem/Coin
    public int[] winRewards;
    public int[] loseRewards;
    //score needed for each star
    public int threeStarScore;
    public int twoStarScore;
    public int oneStarScore;
    //which mobs to spawm
    public int[] mobsList;
    //mob setup 
    public int[] mobsHPList;
    public int[] mobsPointsList;
    // which model to use
    public int mobSpriteID;
    public int totalPoints;
    public void SetupLevelManager(int animalNumber, int levelNumber)
    {
        //load this animal into spawner
        mobSpriteID = animalNumber;

        switch (animalNumber + 1)
        {
            case 1:
                SetupLevel1(levelNumber);
                break;
            case 2:
                SetupLevel2(levelNumber);
                break;
            case 3:
                SetupLevel3(levelNumber);
                break;
            case 4:
                SetupLevel4(levelNumber);
                break;
            case 5:
                SetupLevel5(levelNumber);
                break;
            case 6:
                SetupLevel6(levelNumber);
                break;
            case 7:
                SetupLevel7(levelNumber);
                break;
            case 8:
                SetupLevel8(levelNumber);
                break;
            case 9:
                SetupLevel9(levelNumber);
                break;
            case 10:
                SetupLevel10(levelNumber);
                break;
            case 11:
                SetupLevel11(levelNumber);
                break;
            case 12:
                SetupLevel12(levelNumber);
                break;
            case 13:
                SetupLevel13(levelNumber);
                break;
            case 14:
                SetupLevel14(levelNumber);
                break;
            case 15:
                SetupLevel15(levelNumber);
                break;
            case 16:
                SetupLevel16(levelNumber);
                break;
            case 17:
                SetupLevel17(levelNumber);
                break;
            case 18:
                SetupLevel18(levelNumber);
                break;
            case 19:
                SetupLevel19(levelNumber);
                break;
            case 20:
                SetupLevel20(levelNumber);
                break;
            case 21:
                SetupLevel21(levelNumber);
                break;
            case 22:
                SetupLevel22(levelNumber);
                break;
            case 23:
                SetupLevel23(levelNumber);
                break;
            case 24:
                SetupLevel24(levelNumber);
                break;
            case 25:
                SetupLevel25(levelNumber);
                break;
            case 26:
                SetupLevel26(levelNumber);
                break;
            case 27:
                SetupLevel27(levelNumber);
                break;
            case 28:
                SetupLevel28(levelNumber);
                break;
            case 29:
                SetupLevel29(levelNumber);
                break;
            case 30:
                SetupLevel30(levelNumber);
                break;
            case 31:
                SetupLevel31(levelNumber);
                break;
            case 32:
                SetupLevel32(levelNumber);
                break;

            default:
                break;
        }
    }
    public void SetupLevel1(int levelNumber)
    {
        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTimePoints = 100f;
                levelTime = 60f;
                winRewards = new int[] { 0, 1, 50 };
                loseRewards = new int[] { 0, 0, 10 };
                SetupMobs(false, 1f, 1f, 1f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTimePoints = 100f;
                levelTime = 60f;
                winRewards = new int[] { 0, 1, 60 };
                loseRewards = new int[] { 0, 0, 15 };
                SetupMobs(false, 1.1f, 1.1f, 1.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTimePoints = 100f;
                levelTime = 60f;
                winRewards = new int[] { 0, 1, 70 };
                loseRewards = new int[] { 0, 0, 20 };
                SetupMobs(false, 1.2f, 1.2f, 1.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTimePoints = 100f;
                levelTime = 60f;
                winRewards = new int[] { 0, 1, 80 };
                loseRewards = new int[] { 0, 0, 25 };
                SetupMobs(false, 1.3f, 1.3f, 1.3f);
                SetupTotalPoints();
                break;
            case 5:

                levelID = levelNumber;
                levelTimePoints = 100f;
                levelTime = 60f;
                winRewards = new int[] { 0, 1, 90 };
                loseRewards = new int[] { 0, 0, 30 };
                SetupMobs(false, 1.4f, 1.4f, 1.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTimePoints = 100f;
                levelTime = 60f;
                winRewards = new int[] { 0, 1, 100 };
                loseRewards = new int[] { 0, 0, 35 };
                SetupMobs(false, 1.5f, 1.5f, 1.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTimePoints = 100f;
                levelTime = 60f;
                winRewards = new int[] { 0, 1, 110 };
                loseRewards = new int[] { 0, 0, 40 };
                SetupMobs(false, 1.6f, 1.6f, 1.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTimePoints = 100f;
                levelTime = 60f;
                winRewards = new int[] { 0, 1, 120 };
                loseRewards = new int[] { 0, 0, 45 };
                SetupMobs(false, 1.7f, 1.7f, 1.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTimePoints = 100f;
                levelTime = 60f;
                winRewards = new int[] { 0, 1, 130 };
                loseRewards = new int[] { 0, 0, 50 };
                SetupMobs(false, 1.8f, 1.8f, 1.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTimePoints = 100f;
                levelTime = 60f;
                winRewards = new int[] { 0, 3, 250 };
                loseRewards = new int[] { 0, 0, 55 };
                SetupMobs(true, 1.9f, 1.9f, 1.9f);
                SetupTotalPoints();
                break;
        }
    }
    public void SetupMobs(bool isBoss, double whichLevel, double multiplierPoints, double multiplierHP)
    {
        if (!isBoss)
        {
            int smallMob = (int)Math.Floor(10 * whichLevel);
            int medMob = (int)Math.Floor(3 * whichLevel);
            int largeMob = (int)Math.Floor(2 * whichLevel);
            int sheildMob = (int)Math.Floor(1 * whichLevel);
            //round down
            int bossMob = 1;

            int sHp = (int)Math.Floor(1 * multiplierHP);
            int mHp = (int)Math.Floor(5 * multiplierHP);
            int lHp = (int)Math.Floor(10 * multiplierHP);
            int shHp = (int)Math.Floor(15 * multiplierHP);
            int bHp = (int)Math.Floor(20 * multiplierHP);

            //different levels are worth different points 
            int sPoint = (int)Math.Ceiling(350 * multiplierPoints);
            int mPoint = (int)Math.Ceiling(450 * multiplierPoints);
            int lPoint = (int)Math.Ceiling(550 * multiplierPoints);
            int shPoint = (int)Math.Ceiling(1000 * multiplierPoints);
            int bPoint = (int)Math.Ceiling(1500 * multiplierPoints);

            mobsList = new int[] { smallMob, medMob, largeMob, sheildMob, bossMob };
            mobsHPList = new int[] { sHp, mHp, lHp, shHp, bHp };
            mobsPointsList = new int[] { sPoint, mPoint, lPoint, shPoint, bPoint };
        }
        else if (isBoss)
        {
            int smallMob = (int)Math.Floor(25 * whichLevel);
            int medMob = (int)Math.Floor(0 * whichLevel);
            int largeMob = (int)Math.Floor(0 * whichLevel);
            int sheildMob = (int)Math.Floor(0 * whichLevel);
            int bossMob = 1;

            int sHp = (int)Math.Floor(1 * multiplierHP);
            int mHp = (int)Math.Floor(10 * multiplierHP);
            int lHp = (int)Math.Floor(20 * multiplierHP);
            int shHp = (int)Math.Floor(30 * multiplierHP);
            int bHp = (int)Math.Floor(40 * multiplierHP);

            int sPoint = (int)Math.Ceiling(500 * multiplierPoints);
            int mPoint = (int)Math.Ceiling(750 * multiplierPoints);
            int lPoint = (int)Math.Ceiling(1000 * multiplierPoints);
            int shPoint = (int)Math.Ceiling(2000 * multiplierPoints);
            int bPoint = (int)Math.Ceiling(3500 * multiplierPoints);

            mobsList = new int[] { smallMob, medMob, largeMob, sheildMob, bossMob };
            mobsHPList = new int[] { sHp, mHp, lHp, shHp, bHp };
            mobsPointsList = new int[] { sPoint, mPoint, lPoint, shPoint, bPoint };
        }
    }
    public void SetupTotalPoints()
    {
        totalPoints = 0;
        //score after mob setup
        for (int i = 0; i < mobsPointsList.Length; i++)
        {
            totalPoints = totalPoints + (mobsPointsList[i] * mobsList[i]);
        }
        totalPoints = (int)Math.Ceiling(totalPoints * 1.20f);

        //setup requriements for stars
        threeStarScore = totalPoints;
        twoStarScore = totalPoints / 2;
        oneStarScore = totalPoints / 4;
    }
    public void SetupLevel2(int levelNumber)
    {
        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 60f;
                levelTimePoints = 105f;
                winRewards = new int[] { 0, 2, 100 };
                loseRewards = new int[] { 0, 0, 20 };
                SetupMobs(false, 2f, 2f, 2f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 60f;
                levelTimePoints = 105f;
                winRewards = new int[] { 0, 2, 120 };
                loseRewards = new int[] { 0, 0, 25 };
                SetupMobs(false, 2.1f, 2.1f, 2.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 60f;
                levelTimePoints = 105f;
                winRewards = new int[] { 0, 2, 140 };
                loseRewards = new int[] { 0, 0, 30 };
                SetupMobs(false, 2.2f, 2.2f, 2.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 60f;
                levelTimePoints = 105f;
                winRewards = new int[] { 0, 2, 160 };
                loseRewards = new int[] { 0, 0, 35 };
                SetupMobs(false, 2.3f, 2.3f, 2.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 60f;
                levelTimePoints = 105f;
                winRewards = new int[] { 0, 2, 180 };
                loseRewards = new int[] { 0, 0, 40 };
                SetupMobs(false, 2.4f, 2.4f, 2.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 60f;
                levelTimePoints = 105f;
                winRewards = new int[] { 0, 2, 200 };
                loseRewards = new int[] { 0, 0, 45 };
                SetupMobs(false, 2.5f, 2.5f, 2.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 60f;
                levelTimePoints = 105f;
                winRewards = new int[] { 0, 2, 220 };
                loseRewards = new int[] { 0, 0, 50 };
                SetupMobs(false, 2.6f, 2.6f, 2.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 60f;
                levelTimePoints = 105f;
                winRewards = new int[] { 0, 2, 240 };
                loseRewards = new int[] { 0, 0, 55 };
                SetupMobs(false, 2.7f, 2.7f, 2.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 60f;
                levelTimePoints = 105f;
                winRewards = new int[] { 0, 2, 260 };
                loseRewards = new int[] { 0, 0, 60 };
                SetupMobs(false, 2.8f, 2.8f, 2.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 60f;
                levelTimePoints = 105f;
                winRewards = new int[] { 0, 2, 370 };
                loseRewards = new int[] { 0, 0, 65 };
                SetupMobs(true, 2.9f, 2.9f, 2.9f);
                SetupTotalPoints();
                break;
        }

    }
    public void SetupLevel3(int levelNumber)
    {
        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 60f;
                levelTimePoints = 110f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 1, 4, 200 };
                loseRewards = new int[] { 0, 0, 40 };
                SetupMobs(false, 3f, 3f, 3f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 60f;
                levelTimePoints = 110f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 1, 4, 220 };
                loseRewards = new int[] { 0, 0, 45 };
                SetupMobs(false, 3.1f, 3.1f, 3.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 60f;
                levelTimePoints = 110f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 1, 4, 240 };
                loseRewards = new int[] { 0, 0, 50 };
                SetupMobs(false, 3.2f, 3.2f, 3.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 60f;
                levelTimePoints = 110f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 1, 4, 260 };
                loseRewards = new int[] { 0, 0, 55 };
                SetupMobs(false, 3.3f, 3.3f, 3.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 60f;
                levelTimePoints = 110f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 1, 4, 280 };
                loseRewards = new int[] { 0, 0, 60 };
                SetupMobs(false, 3.4f, 3.4f, 3.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 60f;
                levelTimePoints = 110f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 1, 4, 300 };
                loseRewards = new int[] { 0, 0, 65 };
                SetupMobs(false, 3.5f, 3.5f, 3.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 60f;
                levelTimePoints = 110f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 1, 4, 320 };
                loseRewards = new int[] { 0, 0, 70 };
                SetupMobs(false, 3.6f, 3.6f, 3.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 60f;
                levelTimePoints = 110f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 1, 4, 340 };
                loseRewards = new int[] { 0, 0, 75 };
                SetupMobs(false, 3.7f, 3.7f, 3.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 60f;
                levelTimePoints = 110f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 1, 4, 360 };
                loseRewards = new int[] { 0, 0, 80 };
                SetupMobs(false, 3.8f, 3.8f, 3.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 60f;
                levelTimePoints = 110f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 1, 4, 720 };
                loseRewards = new int[] { 0, 0, 85 };
                SetupMobs(true, 3.9f, 3.9f, 3.9f);
                SetupTotalPoints();
                break;
        }
    }
    public void SetupLevel4(int levelNumber)
    {
        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 115f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 1, 6, 300 };
                loseRewards = new int[] { 0, 0, 60 };
                SetupMobs(false, 3f, 3f, 3f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 115f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 1, 6, 320 };
                loseRewards = new int[] { 0, 0, 65 };
                SetupMobs(false, 3.1f, 3.1f, 3.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 115f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 1, 6, 340 };
                loseRewards = new int[] { 0, 0, 70 };
                SetupMobs(false, 3.2f, 3.2f, 3.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 115f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 1, 6, 360 };
                loseRewards = new int[] { 0, 0, 75 };
                SetupMobs(false, 3.3f, 3.3f, 3.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 115f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 1, 6, 380 };
                loseRewards = new int[] { 0, 0, 80 };
                SetupMobs(false, 3.4f, 3.4f, 3.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 115f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 1, 6, 400 };
                loseRewards = new int[] { 0, 0, 85 };
                SetupMobs(false, 3.5f, 3.5f, 3.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 115f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 1, 6, 420 };
                loseRewards = new int[] { 0, 0, 90 };
                SetupMobs(false, 3.6f, 3.6f, 3.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 115f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 1, 6, 440 };
                loseRewards = new int[] { 0, 0, 95 };
                SetupMobs(false, 3.7f, 3.7f, 3.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 115f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 1, 6, 460 };
                loseRewards = new int[] { 0, 0, 100 };
                SetupMobs(false, 3.8f, 3.8f, 3.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 115f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 1, 6, 920 };
                loseRewards = new int[] { 0, 0, 105 };
                SetupMobs(true, 3.9f, 3.9f, 3.9f);
                SetupTotalPoints();
                break;
        }
    }
    public void SetupLevel5(int levelNumber)
    {
        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 120f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 2, 8, 400 };
                loseRewards = new int[] { 0, 0, 80 };
                SetupMobs(false, 3f, 3f, 3f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 120f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 2, 8, 420 };
                loseRewards = new int[] { 0, 0, 85 };
                SetupMobs(false, 3.1f, 3.1f, 3.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 120f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 2, 8, 440 };
                loseRewards = new int[] { 0, 0, 90 };
                SetupMobs(false, 3.2f, 3.2f, 3.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 120f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 2, 8, 460 };
                loseRewards = new int[] { 0, 0, 95 };
                SetupMobs(false, 3.3f, 3.3f, 3.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 120f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 2, 8, 480 };
                loseRewards = new int[] { 0, 0, 100 };
                SetupMobs(false, 3.4f, 3.4f, 3.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 120f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 2, 8, 500 };
                loseRewards = new int[] { 0, 0, 105 };
                SetupMobs(false, 3.5f, 3.5f, 3.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 120f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 2, 8, 520 };
                loseRewards = new int[] { 0, 0, 110 };
                SetupMobs(false, 3.6f, 3.6f, 3.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 120f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 2, 8, 540 };
                loseRewards = new int[] { 0, 0, 115 };
                SetupMobs(false, 3.7f, 3.7f, 3.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 120f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 2, 8, 560 };
                loseRewards = new int[] { 0, 0, 120 };
                SetupMobs(false, 3.8f, 3.8f, 3.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 120f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 2, 8, 1120 };
                loseRewards = new int[] { 0, 0, 125 };
                SetupMobs(true, 3.9f, 3.9f, 3.9f);
                SetupTotalPoints();
                break;
        }
    }
    public void SetupLevel6(int levelNumber)
    {
        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 125f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 2, 10, 600 };
                loseRewards = new int[] { 0, 0, 100 };
                SetupMobs(false, 3f, 3f, 3f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 125f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 2, 10, 620 };
                loseRewards = new int[] { 0, 0, 105 };
                SetupMobs(false, 3.1f, 3.1f, 3.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 125f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 2, 10, 640 };
                loseRewards = new int[] { 0, 0, 110 };
                SetupMobs(false, 3.2f, 3.2f, 3.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 125f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 2, 10, 660 };
                loseRewards = new int[] { 0, 0, 115 };
                SetupMobs(false, 3.3f, 3.3f, 3.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 125f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 2, 10, 680 };
                loseRewards = new int[] { 0, 0, 120 };
                SetupMobs(false, 3.4f, 3.4f, 3.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 125f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 2, 10, 700 };
                loseRewards = new int[] { 0, 0, 125 };
                SetupMobs(false, 3.5f, 3.5f, 3.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 125f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 2, 10, 720 };
                loseRewards = new int[] { 0, 0, 130 };
                SetupMobs(false, 3.6f, 3.6f, 3.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 125f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 2, 10, 740 };
                loseRewards = new int[] { 0, 0, 135 };
                SetupMobs(false, 3.7f, 3.7f, 3.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 125f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 2, 10, 760 };
                loseRewards = new int[] { 0, 0, 140 };
                SetupMobs(false, 3.8f, 3.8f, 3.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 65f;
                levelTimePoints = 125f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 2, 10, 1520 };
                loseRewards = new int[] { 0, 0, 145 };
                SetupMobs(true, 3.9f, 3.9f, 3.9f);
                SetupTotalPoints();
                break;
        }
    }
    public void SetupLevel7(int levelNumber)
    {


        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 130f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 3, 12, 800 };
                loseRewards = new int[] { 0, 0, 120 };
                SetupMobs(false, 3f, 3f, 3f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 130f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 3, 12, 820 };
                loseRewards = new int[] { 0, 0, 125 };
                SetupMobs(false, 3.1f, 3.1f, 3.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 130f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 3, 12, 840 };
                loseRewards = new int[] { 0, 0, 130 };
                SetupMobs(false, 3.2f, 3.2f, 3.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 130f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 3, 12, 860 };
                loseRewards = new int[] { 0, 0, 135 };
                SetupMobs(false, 3.3f, 3.3f, 3.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 130f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 3, 12, 880 };
                loseRewards = new int[] { 0, 0, 140 };
                SetupMobs(false, 3.4f, 3.4f, 3.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 130f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 3, 12, 900 };
                loseRewards = new int[] { 0, 0, 145 };
                SetupMobs(false, 3.5f, 3.5f, 3.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 130f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 3, 12, 920 };
                loseRewards = new int[] { 0, 0, 150 };
                SetupMobs(false, 3.6f, 3.6f, 3.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 130f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 3, 12, 940 };
                loseRewards = new int[] { 0, 0, 155 };
                SetupMobs(false, 3.7f, 3.7f, 3.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 130f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 3, 12, 960 };
                loseRewards = new int[] { 0, 0, 160 };
                SetupMobs(false, 3.8f, 3.8f, 3.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 130f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 3, 12, 1920 };
                loseRewards = new int[] { 0, 0, 165 };
                SetupMobs(true, 3.9f, 3.9f, 3.9f);
                SetupTotalPoints();
                break;
        }
    }  
    public void SetupLevel8(int levelNumber)
    {
        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 135f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 3, 14, 1000 };
                loseRewards = new int[] { 0, 0, 140 };
                SetupMobs(false, 3f, 3f, 3f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 135f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 3, 14, 1020 };
                loseRewards = new int[] { 0, 0, 145 };
                SetupMobs(false, 3.1f, 3.1f, 3.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 135f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 3, 14, 1040 };
                loseRewards = new int[] { 0, 0, 150 };
                SetupMobs(false, 3.2f, 3.2f, 3.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 135f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 3, 14, 1060 };
                loseRewards = new int[] { 0, 0, 155 };
                SetupMobs(false, 3.3f, 3.3f, 3.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 135f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 3, 14, 1080 };
                loseRewards = new int[] { 0, 0, 160 };
                SetupMobs(false, 3.4f, 3.4f, 3.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 135f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 3, 14, 1100 };
                loseRewards = new int[] { 0, 0, 165 };
                SetupMobs(false, 3.5f, 3.5f, 3.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 135f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 3, 14, 1120 };
                loseRewards = new int[] { 0, 0, 170 };
                SetupMobs(false, 3.6f, 3.6f, 3.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 135f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 3, 14, 1140 };
                loseRewards = new int[] { 0, 0, 175 };
                SetupMobs(false, 3.7f, 3.7f, 3.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 135f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 3, 14, 1160 };
                loseRewards = new int[] { 0, 0, 180 };
                SetupMobs(false, 3.8f, 3.8f, 3.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 135f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 3, 14, 2100 };
                loseRewards = new int[] { 0, 0, 185 };
                SetupMobs(true, 3.9f, 3.9f, 3.9f);
                SetupTotalPoints();
                break;
        }
    } 
    public void SetupLevel9(int levelNumber)
    {


        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 140f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 4, 16, 1200 };
                loseRewards = new int[] { 0, 0, 160 };
                SetupMobs(false, 3f, 3f, 3f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 140f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 4, 16, 1220 };
                loseRewards = new int[] { 0, 0, 165 };
                SetupMobs(false, 3.1f, 3.1f, 3.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 140f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 4, 16, 1240 };
                loseRewards = new int[] { 0, 0, 170 };
                SetupMobs(false, 3.2f, 3.2f, 3.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 140f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 4, 16, 1260 };
                loseRewards = new int[] { 0, 0, 175 };
                SetupMobs(false, 3.3f, 3.3f, 3.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 140f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 4, 16, 1280 };
                loseRewards = new int[] { 0, 0, 180 };
                SetupMobs(false, 3.4f, 3.4f, 3.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 140f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 4, 16, 1300 };
                loseRewards = new int[] { 0, 0, 185 };
                SetupMobs(false, 3.5f, 3.5f, 3.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 140f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 4, 16, 1320 };
                loseRewards = new int[] { 0, 0, 190 };
                SetupMobs(false, 3.6f, 3.6f, 3.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 140f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 4, 16, 1340 };
                loseRewards = new int[] { 0, 0, 195 };
                SetupMobs(false, 3.7f, 3.7f, 3.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 140f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 4, 16, 1360 };
                loseRewards = new int[] { 0, 0, 200 };
                SetupMobs(false, 3.8f, 3.8f, 3.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 70f;
                levelTimePoints = 140f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 4, 16, 2600 };
                loseRewards = new int[] { 0, 0, 205 };
                SetupMobs(true, 3.9f, 3.9f, 3.9f);
                SetupTotalPoints();
                break;
        }
    } 
    public void SetupLevel10(int levelNumber)
    {

        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 145f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 4, 18, 1400 };
                loseRewards = new int[] { 0, 0, 180 };
                SetupMobs(false, 3f, 3f, 3f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 145f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 4, 18, 1420 };
                loseRewards = new int[] { 0, 0, 185 };
                SetupMobs(false, 3.1f, 3.1f, 3.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 145f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 4, 18, 1440 };
                loseRewards = new int[] { 0, 0, 190 };
                SetupMobs(false, 3.2f, 3.2f, 3.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 145f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 4, 18, 1480 };
                loseRewards = new int[] { 0, 0, 195 };
                SetupMobs(false, 3.3f, 3.3f, 3.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 145f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 4, 18, 1500 };
                loseRewards = new int[] { 0, 0, 200 };
                SetupMobs(false, 3.4f, 3.4f, 3.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 145f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 4, 18, 1520 };
                loseRewards = new int[] { 0, 0, 205 };
                SetupMobs(false, 3.5f, 3.5f, 3.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 145f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 4, 18, 1540 };
                loseRewards = new int[] { 0, 0, 210 };
                SetupMobs(false, 3.6f, 3.6f, 3.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 145f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 4, 18, 1560 };
                loseRewards = new int[] { 0, 0, 215 };
                SetupMobs(false, 3.7f, 3.7f, 3.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 145f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 4, 18, 1580 };
                loseRewards = new int[] { 0, 0, 220 };
                SetupMobs(false, 3.8f, 3.8f, 3.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 145f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 4, 18, 3000 };
                loseRewards = new int[] { 0, 0, 225 };
                SetupMobs(true, 3.9f, 3.9f, 3.9f);
                SetupTotalPoints();
                break;
        }

    }   
    public void SetupLevel11(int levelNumber)
    {


        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 150f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 5, 20, 1600 };
                loseRewards = new int[] { 0, 0, 200 };
                SetupMobs(false, 4f, 4f, 4f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 150f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 5, 20, 1620 };
                loseRewards = new int[] { 0, 0, 205 };
                SetupMobs(false, 4.1f, 4.1f, 4.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 150f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 5, 20, 1640 };
                loseRewards = new int[] { 0, 0, 210 };
                SetupMobs(false, 4.2f, 4.2f, 4.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 150f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 5, 20, 1660 };
                loseRewards = new int[] { 0, 0, 215 };
                SetupMobs(false, 4.3f, 4.3f, 4.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 150f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 5, 20, 1680 };
                loseRewards = new int[] { 0, 0, 220 };
                SetupMobs(false, 4.4f, 4.4f, 4.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 150f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 5, 20, 1700 };
                loseRewards = new int[] { 0, 0, 225 };
                SetupMobs(false, 4.5f, 4.5f, 4.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 150f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 5, 20, 1720 };
                loseRewards = new int[] { 0, 0, 230 };
                SetupMobs(false, 4.6f, 4.6f, 4.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 150f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 5, 20, 1740 };
                loseRewards = new int[] { 0, 0, 235 };
                SetupMobs(false, 4.7f, 4.7f, 4.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 150f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 5, 20, 1760 };
                loseRewards = new int[] { 0, 0, 240 };
                SetupMobs(false, 4.8f, 4.8f, 4.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 150f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 5, 20, 3600 };
                loseRewards = new int[] { 0, 0, 245 };
                SetupMobs(true, 4.9f, 4.9f, 4.9f);
                SetupTotalPoints();
                break;
        }
    } 
    public void SetupLevel12(int levelNumber)
    {

        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 155f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 5, 22, 1800 };
                loseRewards = new int[] { 0, 0, 220 };
                SetupMobs(false, 4f, 4f, 4f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 155f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 5, 22, 1820 };
                loseRewards = new int[] { 0, 0, 225 };
                SetupMobs(false, 4.1f, 4.1f, 4.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 155f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 5, 22, 1840 };
                loseRewards = new int[] { 0, 0, 230 };
                SetupMobs(false, 4.2f, 4.2f, 4.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 155f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 5, 22, 1860 };
                loseRewards = new int[] { 0, 0, 235 };
                SetupMobs(false, 4.3f, 4.3f, 4.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 155f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 5, 22, 1880 };
                loseRewards = new int[] { 0, 0, 240 };
                SetupMobs(false, 4.4f, 4.4f, 4.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 155f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 5, 22, 1900 };
                loseRewards = new int[] { 0, 0, 245 };
                SetupMobs(false, 4.5f, 4.5f, 4.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 155f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 5, 22, 1920 };
                loseRewards = new int[] { 0, 0, 250 };
                SetupMobs(false, 4.6f, 4.6f, 4.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 155f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 5, 22, 1940 };
                loseRewards = new int[] { 0, 0, 255 };
                SetupMobs(false, 4.7f, 4.7f, 4.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 155f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 5, 22, 1960 };
                loseRewards = new int[] { 0, 0, 260 };
                SetupMobs(false, 4.8f, 4.8f, 4.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 75f;
                levelTimePoints = 155f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 5, 22, 3800 };
                loseRewards = new int[] { 0, 0, 265 };
                SetupMobs(true, 4.9f, 4.9f, 4.9f);
                SetupTotalPoints();
                break;
        }
    }
    public void SetupLevel13(int levelNumber)
    {


        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 160f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 6, 24, 2000 };
                loseRewards = new int[] { 0, 0, 240 };
                SetupMobs(false, 4f, 4f, 4f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 160f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 6, 24, 2020 };
                loseRewards = new int[] { 0, 0, 245 };
                SetupMobs(false, 4.1f, 4.1f, 4.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 160f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 6, 24, 2040 };
                loseRewards = new int[] { 0, 0, 250 };
                SetupMobs(false, 4.2f, 4.2f, 4.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 160f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 6, 24, 2060 };
                loseRewards = new int[] { 0, 0, 255 };
                SetupMobs(false, 4.3f, 4.3f, 4.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 160f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 6, 24, 2080 };
                loseRewards = new int[] { 0, 0, 260 };
                SetupMobs(false, 4.4f, 4.4f, 4.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 160f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 6, 24, 2100 };
                loseRewards = new int[] { 0, 0, 265 };
                SetupMobs(false, 4.5f, 4.5f, 4.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 160f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 6, 24, 2120 };
                loseRewards = new int[] { 0, 0, 270 };
                SetupMobs(false, 4.6f, 4.6f, 4.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 160f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 6, 24, 2140 };
                loseRewards = new int[] { 0, 0, 275 };
                SetupMobs(false, 4.7f, 4.7f, 4.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 160f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 6, 24, 2160 };
                loseRewards = new int[] { 0, 0, 280 };
                SetupMobs(false, 4.8f, 4.8f, 4.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 160f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 6, 24, 4100 };
                loseRewards = new int[] { 0, 0, 285 };
                SetupMobs(true, 4.9f, 4.9f, 4.9f);
                SetupTotalPoints();
                break;
        }
    }
    public void SetupLevel14(int levelNumber)
    {


        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 165f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 6, 26, 2200 };
                loseRewards = new int[] { 0, 0, 260 };
                SetupMobs(false, 4f, 4f, 4f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 165f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 6, 26, 2220 };
                loseRewards = new int[] { 0, 0, 265 };
                SetupMobs(false, 4.1f, 4.1f, 4.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 165f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 6, 26, 2240 };
                loseRewards = new int[] { 0, 0, 270 };
                SetupMobs(false, 4.2f, 4.2f, 4.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 165f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 6, 26, 2260 };
                loseRewards = new int[] { 0, 0, 275 };
                SetupMobs(false, 4.3f, 4.3f, 4.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 165f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 6, 26, 2280 };
                loseRewards = new int[] { 0, 0, 280 };
                SetupMobs(false, 4.4f, 4.4f, 4.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 165f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 6, 26, 2300 };
                loseRewards = new int[] { 0, 0, 285 };
                SetupMobs(false, 4.5f, 4.5f, 4.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 165f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 6, 26, 2320 };
                loseRewards = new int[] { 0, 0, 290 };
                SetupMobs(false, 4.6f, 4.6f, 4.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 165f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 6, 26, 2340 };
                loseRewards = new int[] { 0, 0, 295 };
                SetupMobs(false, 4.7f, 4.7f, 4.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 165f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 6, 26, 2360 };
                loseRewards = new int[] { 0, 0, 300 };
                SetupMobs(false, 4.8f, 4.8f, 4.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 165f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 6, 26, 5400 };
                loseRewards = new int[] { 0, 0, 305 };
                SetupMobs(true, 4.9f, 4.9f, 4.9f);
                SetupTotalPoints();
                break;
        }
    } 
    public void SetupLevel15(int levelNumber)
    {

        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 170f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 7, 28, 2400 };
                loseRewards = new int[] { 0, 0, 280 };
                SetupMobs(false, 4f, 4f, 4f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 170f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 7, 28, 2420 };
                loseRewards = new int[] { 0, 0, 285 };
                SetupMobs(false, 4.1f, 4.1f, 4.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 170f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 7, 28, 2440 };
                loseRewards = new int[] { 0, 0, 290 };
                SetupMobs(false, 4.2f, 4.2f, 4.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 170f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 7, 28, 2460 };
                loseRewards = new int[] { 0, 0, 295 };
                SetupMobs(false, 4.3f, 4.3f, 4.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 170f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 7, 28, 2480 };
                loseRewards = new int[] { 0, 0, 300 };
                SetupMobs(false, 4.4f, 4.4f, 4.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 170f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 7, 28, 2500 };
                loseRewards = new int[] { 0, 0, 305 };
                SetupMobs(false, 4.5f, 4.5f, 4.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 170f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 7, 28, 2520 };
                loseRewards = new int[] { 0, 0, 310 };
                SetupMobs(false, 4.6f, 4.6f, 4.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 170f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 7, 28, 2540 };
                loseRewards = new int[] { 0, 0, 315 };
                SetupMobs(false, 4.7f, 4.7f, 4.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 170f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 7, 28, 2560 };
                loseRewards = new int[] { 0, 0, 320 };
                SetupMobs(false, 4.8f, 4.8f, 4.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 80f;
                levelTimePoints = 170f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 7, 28, 5320 };
                loseRewards = new int[] { 0, 0, 325 };
                SetupMobs(true, 4.9f, 4.9f, 4.9f);
                SetupTotalPoints();
                break;
        }

    }  
    public void SetupLevel16(int levelNumber)
    {

        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 175f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 7, 30, 2600 };
                loseRewards = new int[] { 0, 0, 300 };

                SetupMobs(false, 4f, 4f, 4f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 175f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 7, 30, 2620 };
                loseRewards = new int[] { 0, 0, 305 };

                SetupMobs(false, 4.1f, 4.1f, 4.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 175f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 7, 30, 2640 };
                loseRewards = new int[] { 0, 0, 310 };

                SetupMobs(false, 4.2f, 4.2f, 4.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 175f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 7, 30, 2660 };
                loseRewards = new int[] { 0, 0, 315 };

                SetupMobs(false, 4.3f, 4.3f, 4.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 175f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 7, 30, 2680 };
                loseRewards = new int[] { 0, 0, 320 };

                SetupMobs(false, 4.4f, 4.4f, 4.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 175f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 7, 30, 2700 };
                loseRewards = new int[] { 0, 0, 325 };

                SetupMobs(false, 4.5f, 4.5f, 4.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 175f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 7, 30, 2720 };
                loseRewards = new int[] { 0, 0, 330 };

                SetupMobs(false, 4.6f, 4.6f, 4.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 175f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 7, 30, 2740 };
                loseRewards = new int[] { 0, 0, 335 };

                SetupMobs(false, 4.7f, 4.7f, 4.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 175f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 7, 30, 2760 };
                loseRewards = new int[] { 0, 0, 340 };

                SetupMobs(false, 4.8f, 4.8f, 4.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 175f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 7, 30, 5450 };
                loseRewards = new int[] { 0, 0, 345 };

                SetupMobs(true, 4.9f, 4.9f, 4.9f);
                SetupTotalPoints();
                break;
        }
    } 
    public void SetupLevel17(int levelNumber)
    {


        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 180f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 8, 32, 2800 };
                loseRewards = new int[] { 0, 0, 320 };
                SetupMobs(false, 4f, 4f, 4f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 180f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 8, 32, 2820 };
                loseRewards = new int[] { 0, 0, 325 };
                SetupMobs(false, 4.1f, 4.1f, 4.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 180f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 8, 32, 2840 };
                loseRewards = new int[] { 0, 0, 330 };
                SetupMobs(false, 4.2f, 4.2f, 4.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 180f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 8, 32, 2860 };
                loseRewards = new int[] { 0, 0, 335 };
                SetupMobs(false, 4.3f, 4.3f, 4.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 180f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 8, 32, 2880 };
                loseRewards = new int[] { 0, 0, 340 };
                SetupMobs(false, 4.4f, 4.4f, 4.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 180f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 8, 32, 2900 };
                loseRewards = new int[] { 0, 0, 345 };
                SetupMobs(false, 4.5f, 4.5f, 4.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 180f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 8, 32, 2920 };
                loseRewards = new int[] { 0, 0, 350 };
                SetupMobs(false, 4.6f, 4.6f, 4.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 180f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 8, 32, 2940 };
                loseRewards = new int[] { 0, 0, 355 };
                SetupMobs(false, 4.7f, 4.7f, 4.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 180f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 8, 32, 2960 };
                loseRewards = new int[] { 0, 0, 360 };
                SetupMobs(false, 4.8f, 4.8f, 4.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 180f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 8, 32, 5800 };
                loseRewards = new int[] { 0, 0, 365 };
                SetupMobs(true, 4.9f, 4.9f, 4.9f);
                SetupTotalPoints();
                break;
        }
    }
    public void SetupLevel18(int levelNumber)
    {
       

        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 185f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 8, 34, 3000 };
                loseRewards = new int[] { 0, 0, 340 };
                SetupMobs(false, 4f, 4f, 4f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 185f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 8, 34, 3020 };
                loseRewards = new int[] { 0, 0, 345 };
                SetupMobs(false, 4.1f, 4.1f, 4.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 185f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 8, 34, 3040 };
                loseRewards = new int[] { 0, 0, 350 };
                SetupMobs(false, 4.2f, 4.2f, 4.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 185f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 8, 34, 3060 };
                loseRewards = new int[] { 0, 0, 355 };
                SetupMobs(false, 4.3f, 4.3f, 4.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 185f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 8, 34, 3080 };
                loseRewards = new int[] { 0, 0, 360 };
                SetupMobs(false, 4.4f, 4.4f, 4.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 185f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 8, 34, 3100 };
                loseRewards = new int[] { 0, 0, 365 };
                SetupMobs(false, 4.5f, 4.5f, 4.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 185f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 8, 34, 3120 };
                loseRewards = new int[] { 0, 0, 370 };
                SetupMobs(false, 4.6f, 4.6f, 4.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 185f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 8, 34, 3140 };
                loseRewards = new int[] { 0, 0, 375 };
                SetupMobs(false, 4.7f, 4.7f, 4.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 185f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 8, 34, 3160 };
                loseRewards = new int[] { 0, 0, 380 };
                SetupMobs(false, 4.8f, 4.8f, 4.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 85f;
                levelTimePoints = 185f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 8, 34, 6100 };
                loseRewards = new int[] { 0, 0, 385 };
                SetupMobs(true, 4.9f, 4.9f, 4.9f);
                SetupTotalPoints();
                break;
        }
    }  
    public void SetupLevel19(int levelNumber)
    {
       
        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 190f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 9, 36, 3200 };
                loseRewards = new int[] { 0, 0, 360 };

                SetupMobs(false, 4f, 4f, 4f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 190f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 9, 36, 3220 };
                loseRewards = new int[] { 0, 0, 365 };

                SetupMobs(false, 4.1f, 4.1f, 4.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 190f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 9, 36, 3240 };
                loseRewards = new int[] { 0, 0, 370 };

                SetupMobs(false, 4.2f, 4.2f, 4.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 190f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 9, 36, 3260 };
                loseRewards = new int[] { 0, 0, 375 };

                SetupMobs(false, 4.3f, 4.3f, 4.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 190f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 9, 36, 3280 };
                loseRewards = new int[] { 0, 0, 380 };

                SetupMobs(false, 4.4f, 4.4f, 4.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 190f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 9, 36, 3300 };
                loseRewards = new int[] { 0, 0, 385 };

                SetupMobs(false, 4.5f, 4.5f, 4.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 190f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 9, 36, 3320 };
                loseRewards = new int[] { 0, 0, 390 };

                SetupMobs(false, 4.6f, 4.6f, 4.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 190f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 9, 36, 3340 };
                loseRewards = new int[] { 0, 0, 395 };

                SetupMobs(false, 4.7f, 4.7f, 4.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 190f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 9, 36, 3360 };
                loseRewards = new int[] { 0, 0, 400 };

                SetupMobs(false, 4.8f, 4.8f, 4.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 190f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 9, 36, 6700 };
                loseRewards = new int[] { 0, 0, 405 };

                SetupMobs(true, 4.9f, 4.9f, 4.9f);
                SetupTotalPoints();
                break;
        }
    }
    public void SetupLevel20(int levelNumber)
    {
        
        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 195f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 9, 38, 3400 };
                loseRewards = new int[] { 0, 0, 380 };
                SetupMobs(false, 4f, 4f, 4f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 195f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 9, 38, 3420 };
                loseRewards = new int[] { 0, 0, 385 };
                SetupMobs(false, 4.1f, 4.1f, 4.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 195f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 9, 38, 3440 };
                loseRewards = new int[] { 0, 0, 390 };
                SetupMobs(false, 4.2f, 4.2f, 4.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 195f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 9, 38, 3460 };
                loseRewards = new int[] { 0, 0, 395 };
                SetupMobs(false, 4.3f, 4.3f, 4.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 195f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 9, 38, 3480 };
                loseRewards = new int[] { 0, 0, 400 };
                SetupMobs(false, 4.4f, 4.4f, 4.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 195f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 9, 38, 3500 };
                loseRewards = new int[] { 0, 0, 405 };
                SetupMobs(false, 4.5f, 4.5f, 4.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 195f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 9, 38, 3520 };
                loseRewards = new int[] { 0, 0, 410 };
                SetupMobs(false, 4.6f, 4.6f, 4.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 195f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 9, 38, 3540 };
                loseRewards = new int[] { 0, 0, 415 };
                SetupMobs(false, 4.7f, 4.7f, 4.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 195f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 9, 38, 3560 };
                loseRewards = new int[] { 0, 0, 420 };
                SetupMobs(false, 4.8f, 4.8f, 4.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 195f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 9, 38, 6900 };
                loseRewards = new int[] { 0, 0, 425 };
                SetupMobs(true, 4.9f, 4.9f, 4.9f);
                SetupTotalPoints();
                break;
        }

    }
    public void SetupLevel21(int levelNumber)
    {
       
        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 200f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 10, 40, 3600 };
                loseRewards = new int[] { 0, 0, 400 };

                SetupMobs(false, 5f, 5f, 5f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 200f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 10, 40, 3620 };
                loseRewards = new int[] { 0, 0, 405 };

                SetupMobs(false, 5.1f, 5.1f, 5.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 200f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 10, 40, 3640 };
                loseRewards = new int[] { 0, 0, 410 };

                SetupMobs(false, 5.2f, 5.2f, 5.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 200f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 10, 40, 3660 };
                loseRewards = new int[] { 0, 0, 415 };

                SetupMobs(false, 5.3f, 5.3f, 5.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 200f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 10, 40, 3680 };
                loseRewards = new int[] { 0, 0, 420 };

                SetupMobs(false, 5.4f, 5.4f, 5.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 200f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 10, 40, 3700 };
                loseRewards = new int[] { 0, 0, 425 };

                SetupMobs(false, 5.5f, 5.5f, 5.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 200f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 10, 40, 3720 };
                loseRewards = new int[] { 0, 0, 430 };

                SetupMobs(false, 5.6f, 5.6f, 5.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 200f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 10, 40, 3740 };
                loseRewards = new int[] { 0, 0, 435 };

                SetupMobs(false, 5.7f, 5.7f, 5.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 200f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 10, 40, 3760 };
                loseRewards = new int[] { 0, 0, 440 };

                SetupMobs(false, 5.8f, 5.8f, 5.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 90f;
                levelTimePoints = 200f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 10, 40, 7200 };
                loseRewards = new int[] { 0, 0, 445 };

                SetupMobs(true, 5.9f, 5.9f, 5.9f);
                SetupTotalPoints();
                break;
        }
    } 
    public void SetupLevel22(int levelNumber)
    {
      
        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 210f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 44, 3800 };
                loseRewards = new int[] { 0, 0, 420 };

                SetupMobs(false, 5f, 5f, 5f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 210f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 44, 3820 };
                loseRewards = new int[] { 0, 0, 425 };

                SetupMobs(false, 5.1f, 5.1f, 5.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 210f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 44, 3840 };
                loseRewards = new int[] { 0, 0, 430 };

                SetupMobs(false, 5.2f, 5.2f, 5.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 210f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 44, 3860 };
                loseRewards = new int[] { 0, 0, 435 };

                SetupMobs(false, 5.3f, 5.3f, 5.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 210f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 44, 3880 };
                loseRewards = new int[] { 0, 0, 440 };

                SetupMobs(false, 5.4f, 5.4f, 5.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 210f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 44, 3900 };
                loseRewards = new int[] { 0, 0, 445};

                SetupMobs(false, 5.5f, 5.5f, 5.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 210f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 44, 3920 };
                loseRewards = new int[] { 0, 0, 450 };

                SetupMobs(false, 5.6f, 5.6f, 5.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 210f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 44, 3940 };
                loseRewards = new int[] { 0, 0, 455 };

                SetupMobs(false, 5.7f, 5.7f, 5.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 210f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 44, 3960 };
                loseRewards = new int[] { 0, 0, 460 };

                SetupMobs(false, 5.8f, 5.8f, 5.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 210f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 44, 7600 };
                loseRewards = new int[] { 0, 0, 465 };

                SetupMobs(true, 5.9f, 5.9f, 5.9f);
                SetupTotalPoints();
                break;
        }
    }
    public void SetupLevel23(int levelNumber)
    {
        
        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 210f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 44, 4000 };
                loseRewards = new int[] { 0, 0, 440 };
                SetupMobs(false, 5f, 5f, 5f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 210f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 44, 4020 };
                loseRewards = new int[] { 0, 0, 445 };
                SetupMobs(false, 5.1f, 5.1f, 5.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 210f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 44, 4040 };
                loseRewards = new int[] { 0, 0, 450 };
                SetupMobs(false, 5.2f, 5.2f, 5.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 210f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 44, 4060 };
                loseRewards = new int[] { 0, 0, 455 };
                SetupMobs(false, 5.3f, 5.3f, 5.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 210f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 44, 4080 };
                loseRewards = new int[] { 0, 0, 460 };
                SetupMobs(false, 5.4f, 5.4f, 5.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 210f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 44, 4100 };
                loseRewards = new int[] { 0, 0, 465 }; ;
                SetupMobs(false, 5.5f, 5.5f, 5.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 210f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 44, 4120 };
                loseRewards = new int[] { 0, 0, 470 }; ;
                SetupMobs(false, 5.6f, 5.6f, 5.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 210f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 44, 4140 };
                loseRewards = new int[] { 0, 0, 475 };
                SetupMobs(false, 5.7f, 5.7f, 5.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 210f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 44, 4160 };
                loseRewards = new int[] { 0, 0, 480 };
                SetupMobs(false, 5.8f, 5.8f, 5.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 210f;

                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 44, 8000 };
                loseRewards = new int[] { 0, 0, 485 };
                SetupMobs(true, 5.9f, 5.9f, 5.9f);
                SetupTotalPoints();
                break;
        }

    } 
    public void SetupLevel24(int levelNumber)
    {
       
        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 215f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 46, 4200 };
                loseRewards = new int[] { 0, 0, 460 };
                SetupMobs(false, 5f, 5f, 5f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 215f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 46, 4220 };
                loseRewards = new int[] { 0, 0, 465 };
                SetupMobs(false, 5.1f, 5.1f, 5.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 215f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 46, 4240 };
                loseRewards = new int[] { 0, 0, 470 };
                SetupMobs(false, 5.2f, 5.2f, 5.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 215f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 46, 4260 };
                loseRewards = new int[] { 0, 0, 475 };
                SetupMobs(false, 5.3f, 5.3f, 5.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 215f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 46, 4280 };
                loseRewards = new int[] { 0, 0, 480 };
                SetupMobs(false, 5.4f, 5.4f, 5.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 215f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 46, 4300 };
                loseRewards = new int[] { 0, 0, 485 };
                SetupMobs(false, 5.5f, 5.5f, 5.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 215f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 46, 4320 };
                loseRewards = new int[] { 0, 0, 490 };
                SetupMobs(false, 5.6f, 5.6f, 5.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 215f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 46, 4340 };
                loseRewards = new int[] { 0, 0, 495 }; 
                SetupMobs(false, 5.7f, 5.7f, 5.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 215f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 46, 4360 };
                loseRewards = new int[] { 0, 0, 500 };
                SetupMobs(false, 5.8f, 5.8f, 5.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 95f;
                levelTimePoints = 215f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 11, 46, 8400 };
                loseRewards = new int[] { 0, 0, 505 };
                SetupMobs(true, 5.9f, 5.9f, 5.9f);
                SetupTotalPoints();
                break;
        }

    }  
    public void SetupLevel25(int levelNumber)
    {
      
        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 95f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 12, 48, 4400 };
                loseRewards = new int[] { 0, 0, 480 };
                SetupMobs(false, 5f, 5f, 5f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 95f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 12, 48, 4420 };
                loseRewards = new int[] { 0, 0, 485 };
                SetupMobs(false, 5.1f, 5.1f, 5.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 95f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 12, 48, 4440 };
                loseRewards = new int[] { 0, 0, 490 };
                SetupMobs(false, 5.2f, 5.2f, 5.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 95f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 12, 48, 4460 };
                loseRewards = new int[] { 0, 0, 495 };
               SetupMobs(false, 5.3f, 5.3f, 5.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 95f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 12, 48, 4480 };
                loseRewards = new int[] { 0, 0, 500 };
                SetupMobs(false, 5.4f, 5.4f, 5.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 95f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 12, 48, 4500 };
                loseRewards = new int[] { 0, 0, 505 };
                SetupMobs(false, 5.5f, 5.5f, 5.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 95f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 12, 48, 4520 };
                loseRewards = new int[] { 0, 0, 510 };
                SetupMobs(false, 5.6f, 5.6f, 5.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 95f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 12, 48, 4540 };
                loseRewards = new int[] { 0, 0, 515 };
                SetupMobs(false, 5.7f, 5.7f, 5.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 95f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 12, 48, 4560 };
                loseRewards = new int[] { 0, 0, 520 };
                SetupMobs(false, 5.8f, 5.8f, 5.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 95f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 12, 48, 8600 };
                loseRewards = new int[] { 0, 0, 525 };
                SetupMobs(true, 5.9f, 5.9f, 5.9f);
                SetupTotalPoints();
                break;
        }

    } 
    public void SetupLevel26(int levelNumber)
    {
       
        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 220f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 12, 50, 4600 };
                loseRewards = new int[] { 0, 0, 480 };
                SetupMobs(false, 5f, 5f, 5f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 220f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 12, 50, 4620 };
                loseRewards = new int[] { 0, 0, 485 };
                SetupMobs(false, 5.1f, 5.1f, 5.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 220f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 12, 50, 4640 };
                loseRewards = new int[] { 0, 0, 490 };
                SetupMobs(false, 5.2f, 5.2f, 5.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 220f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 12, 50, 4660 };
                loseRewards = new int[] { 0, 0, 495 };
                SetupMobs(false, 5.3f, 5.3f, 5.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 220f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 12, 50, 4680 };
                loseRewards = new int[] { 0, 0, 500 };
                SetupMobs(false, 5.4f, 5.4f, 5.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 220f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 12, 50, 4700 };
                loseRewards = new int[] { 0, 0, 505 };
                SetupMobs(false, 5.5f, 5.5f, 5.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 220f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 12, 50, 4720 };
                loseRewards = new int[] { 0, 0, 510 };
                SetupMobs(false, 5.6f, 5.6f, 5.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 220f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 12, 50, 4740 };
                loseRewards = new int[] { 0, 0, 515 };
                SetupMobs(false, 5.7f, 5.7f, 5.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 220f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 12, 50, 4760 };
                loseRewards = new int[] { 0, 0, 520 };
                SetupMobs(false, 5.8f, 5.8f, 5.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 220f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 12, 50, 8900 };
                loseRewards = new int[] { 0, 0, 525 };
                SetupMobs(true, 5.9f, 5.9f, 5.9f);
                SetupTotalPoints();
                break;
        }


    }  
    public void SetupLevel27(int levelNumber)
    {
       
        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 225f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 13, 52, 4800 };
                loseRewards = new int[] { 0, 0, 500 };
                SetupMobs(false, 5f, 5f, 5f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 225f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 13, 52, 4820 };
                loseRewards = new int[] { 0, 0, 505 };
                SetupMobs(false, 5.1f, 5.1f, 5.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 225f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 13, 52, 4840 };
                loseRewards = new int[] { 0, 0, 510 };
                SetupMobs(false, 5.2f, 5.2f, 5.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 225f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 13, 52, 4860 };
                loseRewards = new int[] { 0, 0, 515 };
                SetupMobs(false, 5.3f, 5.3f, 5.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 225f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 13, 52, 4880 };
                loseRewards = new int[] { 0, 0, 520 };
                SetupMobs(false, 5.4f, 5.4f, 5.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 225f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 13, 52, 4900 };
                loseRewards = new int[] { 0, 0, 525 };
                SetupMobs(false, 5.5f, 5.5f, 5.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 225f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 13, 52, 4920 };
                loseRewards = new int[] { 0, 0, 530 };
                SetupMobs(false, 5.6f, 5.6f, 5.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 225f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 13, 52, 4940 };
                loseRewards = new int[] { 0, 0, 535 };
                SetupMobs(false, 5.7f, 5.7f, 5.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 225f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 13, 52, 4960 };
                loseRewards = new int[] { 0, 0, 540 };
                SetupMobs(false, 5.8f, 5.8f, 5.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 225f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 13, 52, 9600 };
                loseRewards = new int[] { 0, 0, 545 };
                SetupMobs(true, 5.9f, 5.9f, 5.9f);
                SetupTotalPoints();
                break;
        }

    } 
    public void SetupLevel28(int levelNumber)
    {
        switch (levelNumber)
        {
            case 1:

                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 230f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 13, 54, 5000 };
                loseRewards = new int[] { 0, 0, 520 };

                SetupMobs(false, 5f, 5f, 5f);
                SetupTotalPoints();
                break;
            case 2:

                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 230f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 13, 54, 5020 };
                loseRewards = new int[] { 0, 0, 525 };

                SetupMobs(false, 5.1f, 5.1f, 5.1f);
                SetupTotalPoints();
                break;

            case 3:

                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 230f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 13, 54, 5040 };
                loseRewards = new int[] { 0, 0, 530 };

                SetupMobs(false, 5.2f, 5.2f, 5.2f);
                SetupTotalPoints();
                break;
            case 4:

                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 230f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 13, 54, 5060 };
                loseRewards = new int[] { 0, 0, 535 };

                SetupMobs(false, 5.3f, 5.3f, 5.3f);
                SetupTotalPoints();
                break;
            case 5:

                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 230f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 13, 54, 5080 };
                loseRewards = new int[] { 0, 0, 540 };

                SetupMobs(false, 5.4f, 5.4f, 5.4f);
                SetupTotalPoints();
                break;

            case 6:

                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 230f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 13, 54, 5100 };
                loseRewards = new int[] { 0, 0, 545 };
                SetupMobs(false, 5.5f, 5.5f, 5.5f);
                SetupTotalPoints();
                break;
            case 7:

                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 230f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 13, 54, 5120 };
                loseRewards = new int[] { 0, 0, 550 };

                SetupMobs(false, 5.6f, 5.6f, 5.6f);
                SetupTotalPoints();
                break;

            case 8:

                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 230f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 13, 54, 5140 };
                loseRewards = new int[] { 0, 0, 555 };

                SetupMobs(false, 5.7f, 5.7f, 5.7f);
                SetupTotalPoints();
                break;

            case 9:

                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 230f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 13, 54, 5160 };
                loseRewards = new int[] { 0, 0, 560 };
                SetupMobs(false, 5.8f, 5.8f, 5.8f);
                SetupTotalPoints();
                break;

            case 10:

                levelID = levelNumber;
                levelTime = 100f;
                levelTimePoints = 230f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 13, 54,10200 };
                loseRewards = new int[] { 0, 0, 565 };

                SetupMobs(true, 5.9f, 5.9f, 5.9f);
                SetupTotalPoints();
                break;
        }
    } 
    public void SetupLevel29(int levelNumber)
    {
       
        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 105f;
                levelTimePoints = 235f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 14, 56, 5200 };
                loseRewards = new int[] { 0, 0, 540 };

                SetupMobs(false, 5f, 5f, 5f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 105f;
                levelTimePoints = 235f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 14, 56, 5220 };
                loseRewards = new int[] { 0, 0, 545 };

                SetupMobs(false, 5.1f, 5.1f, 5.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 105f;
                levelTimePoints = 235f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 14, 56, 5240 };
                loseRewards = new int[] { 0, 0, 550 };

                SetupMobs(false, 5.2f, 5.2f, 5.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 105f;
                levelTimePoints = 235f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 14, 56, 5260 };
                loseRewards = new int[] { 0, 0, 555 };

                SetupMobs(false, 5.3f, 5.3f, 5.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 105f;
                levelTimePoints = 235f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 14, 56, 5280 };
                loseRewards = new int[] { 0, 0, 560 };

                SetupMobs(false, 5.4f, 5.4f, 5.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 105f;
                levelTimePoints = 235f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 14, 56, 5300 };
                loseRewards = new int[] { 0, 0, 565 };

                SetupMobs(false, 5.5f, 5.5f, 5.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 105f;
                levelTimePoints = 235f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 14, 56, 5320 };
                loseRewards = new int[] { 0, 0, 570 };

                SetupMobs(false, 5.6f, 5.6f, 5.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 105f;
                levelTimePoints = 235f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 14, 56, 5340 };
                loseRewards = new int[] { 0, 0, 575 };

                SetupMobs(false, 5.7f, 5.7f, 5.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 105f;
                levelTimePoints = 235f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 14, 56, 5360 };
                loseRewards = new int[] { 0, 0, 580 };

                SetupMobs(false, 5.8f, 5.8f, 5.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 105f;
                levelTimePoints = 235f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 14, 56,10700 };
                loseRewards = new int[] { 0, 0, 585 };

                SetupMobs(true, 5.9f, 5.9f, 5.9f);
                SetupTotalPoints();
                break;
        }
    }   
    public void SetupLevel30(int levelNumber)
    {
       
        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 110f;
                levelTimePoints = 240f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 14, 58, 5400 };
                loseRewards = new int[] { 0, 0, 560 };
                SetupMobs(false, 5f, 5f, 5f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 110f;
                levelTimePoints = 240f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 14, 58, 5420 };
                loseRewards = new int[] { 0, 0, 565 };
                SetupMobs(false, 5.1f, 5.1f, 5.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 110f;
                levelTimePoints = 240f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 14, 58, 5440 };
                loseRewards = new int[] { 0, 0, 570 };
                SetupMobs(false, 5.2f, 5.2f, 5.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 110f;
                levelTimePoints = 240f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 14, 58, 5460 };
                loseRewards = new int[] { 0, 0, 575 };
                SetupMobs(false, 5.3f, 5.3f, 5.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 110f;
                levelTimePoints = 240f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 14, 58, 5460 };
                loseRewards = new int[] { 0, 0, 580 };
                SetupMobs(false, 5.4f, 5.4f, 5.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 110f;
                levelTimePoints = 240f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 14, 58, 5480 };
                loseRewards = new int[] { 0, 0, 585 };
                SetupMobs(false, 5.5f, 5.5f, 5.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 110f;
                levelTimePoints = 240f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 14, 58, 5500 };
                loseRewards = new int[] { 0, 0, 590 };
                SetupMobs(false, 5.6f, 5.6f, 5.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 110f;
                levelTimePoints = 240f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 14, 58, 5520 };
                loseRewards = new int[] { 0, 0, 595 };
                SetupMobs(false, 5.7f, 5.7f, 5.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 110f;
                levelTimePoints = 240f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 14, 58, 5540 };
                loseRewards = new int[] { 0, 0, 600 };
                SetupMobs(false, 5.8f, 5.8f, 5.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 110f;
                levelTimePoints = 240f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 14, 58, 11200 };
                loseRewards = new int[] { 0, 0, 605 };
                SetupMobs(true, 5.9f, 5.9f, 5.9f);
                SetupTotalPoints();
                break;
        }

    }  
    public void SetupLevel31(int levelNumber)
    {
      
        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 115f;
                levelTimePoints = 245f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 15, 60, 5600 };
                loseRewards = new int[] { 0, 0, 580 };

                SetupMobs(false, 6f, 6f, 6f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 115f;
                levelTimePoints = 245f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 15, 60, 5620 };
                loseRewards = new int[] { 0, 0, 585 };

                SetupMobs(false, 6.1f, 6.1f, 6.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 115f;
                levelTimePoints = 245f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 15, 60, 5640 };
                loseRewards = new int[] { 0, 0, 590 };

                SetupMobs(false, 6.2f, 6.2f, 6.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 115f;
                levelTimePoints = 245f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 15, 60, 5660 };
                loseRewards = new int[] { 0, 0, 595 };

                SetupMobs(false, 6.3f, 6.3f, 6.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 115f;
                levelTimePoints = 245f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 15, 60, 5680 };
                loseRewards = new int[] { 0, 0, 600 };

                SetupMobs(false, 6.4f, 6.4f, 6.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 115f;
                levelTimePoints = 245f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 15, 60, 5700 };
                loseRewards = new int[] { 0, 0, 605 };

                SetupMobs(false, 6.5f, 6.5f, 6.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 115f;
                levelTimePoints = 245f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 15, 60, 5720 };
                loseRewards = new int[] { 0, 0, 610 };

                SetupMobs(false, 6.6f, 6.6f, 6.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 115f;
                levelTimePoints = 245f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 15, 60, 5740 };
                loseRewards = new int[] { 0, 0, 615 };

                SetupMobs(false, 6.7f, 6.7f, 6.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 115f;
                levelTimePoints = 245f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 15, 60, 5760 };
                loseRewards = new int[] { 0, 0, 620 };

                SetupMobs(false, 6.8f, 6.8f, 6.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 115f;
                levelTimePoints = 245f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 15, 60, 11420 };
                loseRewards = new int[] { 0, 0, 625 };

                SetupMobs(true, 6.9f, 6.9f, 6.9f);
                SetupTotalPoints();
                break;
        }

    } 
    public void SetupLevel32(int levelNumber)
    {
        switch (levelNumber)
        {
            case 1:
                levelID = levelNumber;
                levelTime = 120f;
                levelTimePoints = 250f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 15, 62, 5800 };
                loseRewards = new int[] { 0, 0, 600 };
                SetupMobs(false, 6f, 6f, 6f);
                SetupTotalPoints();
                break;
            case 2:
                levelID = levelNumber;
                levelTime = 120f;
                levelTimePoints = 250f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 15, 62, 5820 };
                loseRewards = new int[] { 0, 0, 605 };
                SetupMobs(false, 6.1f, 6.1f, 6.1f);
                SetupTotalPoints();
                break;

            case 3:
                levelID = levelNumber;
                levelTime = 120f;
                levelTimePoints = 250f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 15, 62, 5840 };
                loseRewards = new int[] { 0, 0, 610 };
                SetupMobs(false, 6.2f, 6.2f, 6.2f);
                SetupTotalPoints();
                break;
            case 4:
                levelID = levelNumber;
                levelTime = 120f;
                levelTimePoints = 250f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 15, 62, 5860 };
                loseRewards = new int[] { 0, 0, 615 };
                SetupMobs(false,6.3f, 6.3f, 6.3f);
                SetupTotalPoints();
                break;
            case 5:
                levelID = levelNumber;
                levelTime = 120f;
                levelTimePoints = 250f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 15, 62, 5880 };
                loseRewards = new int[] { 0, 0, 620 };
                SetupMobs(false, 6.4f, 6.4f, 6.4f);
                SetupTotalPoints();
                break;

            case 6:
                levelID = levelNumber;
                levelTime = 120f;
                levelTimePoints = 250f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 15, 62, 5900 };
                loseRewards = new int[] { 0, 0, 625 };
                SetupMobs(false, 6.5f, 6.5f, 6.5f);
                SetupTotalPoints();
                break;
            case 7:
                levelID = levelNumber;
                levelTime = 120f;
                levelTimePoints = 250f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 15, 62, 5920 };
                loseRewards = new int[] { 0, 0, 630 };
                SetupMobs(false, 6.6f, 6.6f, 6.6f);
                SetupTotalPoints();
                break;

            case 8:
                levelID = levelNumber;
                levelTime = 120f;
                levelTimePoints = 250f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 15, 62, 5940 };
                loseRewards = new int[] { 0, 0, 635 };
                SetupMobs(false, 6.7f, 6.7f, 6.7f);
                SetupTotalPoints();
                break;

            case 9:
                levelID = levelNumber;
                levelTime = 120f;
                levelTimePoints = 250f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 15, 62, 5960 };
                loseRewards = new int[] { 0, 0, 640 };
                SetupMobs(false, 6.8f, 6.8f, 6.8f);
                SetupTotalPoints();
                break;

            case 10:
                levelID = levelNumber;
                levelTime = 120f;
                levelTimePoints = 250f;
                // rewards are Potion/Gem/Coin
                winRewards = new int[] { 15, 62, 12600 };
                loseRewards = new int[] { 0, 0, 645 };
                SetupMobs(true, 6.9f, 6.9f, 6.9f);
                SetupTotalPoints();
                break;
        }

    }
}
