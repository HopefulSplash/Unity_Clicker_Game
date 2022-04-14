using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    public LevelMenu levelMenu;
    public Image[] levelStarImages;
    public int animalNumber;
    public Player player;
    public Sprite unCompleteStar;
    public Sprite completeStar;
    public Button[] levelbuttons;
    public MainMenuScript mainMenuScript;
    public bool active = false;
    public int levelNumber = 1;
    public GameObject[] gameObjects;
    public KeepAudio audioManager;
    public Text heartsText;
    public GameObject heartDisplay;
    public Button playButton;
    public void Update()
    {
        if (active == true)
        {
            if (EventSystem.current.currentSelectedGameObject == null)
            {
                EventSystem.current.SetSelectedGameObject(levelbuttons[levelNumber-1].gameObject);
            }
        }
    }
    public void ShowLevelSelect(int animalNumber)
    {
        levelMenu.gameObject.SetActive(true);
        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<Player>();
        player.LoadPlayer();
        heartsText.text = player.playerHearts.ToString();
        if (player.playerHearts > 0)
        {
            SetButtonActive(playButton);
        }
        else
        {
            SetButtonInactive(playButton);
        }
        this.animalNumber = animalNumber;
        SetupLevelStars();
        EventSystem.current.SetSelectedGameObject(levelbuttons[0].gameObject);
        levelNumber = 1;
        foreach (Button element in levelbuttons)
        {
            SetButtonActive(element);
        }
        foreach (Image img in levelStarImages)
        {
            img.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        
        CheckCanPlayLevel();
        active = true;
    }
    public void UpdateLevelMenu()
    {
        levelMenu.gameObject.SetActive(false);
    }
    public void CheckCanPlayLevel()
    {
        if (levelStarImages[0].GetComponent<Image>().sprite.name == "Star")
        {
            if (levelStarImages[3].GetComponent<Image>().sprite.name == "Star")
            {
                if (levelStarImages[6].GetComponent<Image>().sprite.name == "Star")
                { 
                    if (levelStarImages[9].GetComponent<Image>().sprite.name == "Star")
                    {
                        if (levelStarImages[12].GetComponent<Image>().sprite.name == "Star")
                        {
                            if (levelStarImages[15].GetComponent<Image>().sprite.name == "Star")
                            {
                                if (levelStarImages[18].GetComponent<Image>().sprite.name == "Star")
                                {
                                    if (levelStarImages[21].GetComponent<Image>().sprite.name == "Star")
                                    {
                                        if (levelStarImages[24].GetComponent<Image>().sprite.name == "Star")
                                        {
                                            // enable boss level
                                        }
                                        else
                                        {
                                            DisableLevel(1);
                                        }
                                    }
                                    else
                                    {
                                        DisableLevel(2);
                                    }
                                }
                                else
                                {
                                    DisableLevel(3);
                                }
                            }
                            else
                            {
                                DisableLevel(4);
                            }
                        }
                        else
                        {
                            DisableLevel(5);
                        }
                    }
                    else
                    {
                        DisableLevel(6);
                    }
                }
                else
                {
                    DisableLevel(7);
                }
            }
            else
            {
                DisableLevel(8);
            }
        }
        else
        {
            DisableLevel(9);
        }
    }
    public void DisableLevel(int NumberLevels)
    {
       switch (NumberLevels)
        {
            case 1:
                for (int i = 27; i < levelStarImages.Length; i++)
                {   //set all the no stars
                    levelStarImages[i].GetComponent<Image>().color = new Color32(255, 255, 255, 150);
                }
                SetButtonInactive(levelbuttons[9]);
              
                break;
            case 2:
                for (int i = 24; i < levelStarImages.Length; i++)
                {   //set all the no stars
                    levelStarImages[i].GetComponent<Image>().color = new Color32(255, 255, 255, 150);
                }
                SetButtonInactive(levelbuttons[9]);
                SetButtonInactive(levelbuttons[8]);
                break;
            case 3:
                for (int i = 21; i < levelStarImages.Length; i++)
                {   //set all the no stars
                    levelStarImages[i].GetComponent<Image>().color = new Color32(255, 255, 255, 150);
                }
                SetButtonInactive(levelbuttons[9]);
                SetButtonInactive(levelbuttons[8]);
                SetButtonInactive(levelbuttons[7]);

                break;
            case 4:
                for (int i = 18; i < levelStarImages.Length; i++)
                {   //set all the no stars
                    levelStarImages[i].GetComponent<Image>().color = new Color32(255, 255, 255, 150);
                }
                SetButtonInactive(levelbuttons[9]);
                SetButtonInactive(levelbuttons[8]);
                SetButtonInactive(levelbuttons[7]);
                SetButtonInactive(levelbuttons[6]);
   
                break;
            case 5:
                for (int i = 15; i < levelStarImages.Length; i++)
                {   //set all the no stars
                    levelStarImages[i].GetComponent<Image>().color = new Color32(255, 255, 255, 150);
                }
                SetButtonInactive(levelbuttons[9]);
                SetButtonInactive(levelbuttons[8]);
                SetButtonInactive(levelbuttons[7]);
                SetButtonInactive(levelbuttons[6]);
                SetButtonInactive(levelbuttons[5]);

                break;
            case 6:
                for (int i = 12; i < levelStarImages.Length; i++)
                {   //set all the no stars
                    levelStarImages[i].GetComponent<Image>().color = new Color32(255, 255, 255, 150);
                }
                SetButtonInactive(levelbuttons[9]);
                SetButtonInactive(levelbuttons[8]);
                SetButtonInactive(levelbuttons[7]);
                SetButtonInactive(levelbuttons[6]);
                SetButtonInactive(levelbuttons[5]);
                SetButtonInactive(levelbuttons[4]);
       
                break;
            case 7:
                for (int i = 9; i < levelStarImages.Length; i++)
                {   //set all the no stars
                    levelStarImages[i].GetComponent<Image>().color = new Color32(255, 255, 255, 150);
                }
                SetButtonInactive(levelbuttons[9]);
                SetButtonInactive(levelbuttons[8]);
                SetButtonInactive(levelbuttons[7]);
                SetButtonInactive(levelbuttons[6]);
                SetButtonInactive(levelbuttons[5]);
                SetButtonInactive(levelbuttons[4]);
                SetButtonInactive(levelbuttons[3]);

                break;
            case 8:
                for (int i = 6; i < levelStarImages.Length; i++)
                {   //set all the no stars
                    levelStarImages[i].GetComponent<Image>().color = new Color32(255, 255, 255, 150);
                }
                SetButtonInactive(levelbuttons[9]);
                SetButtonInactive(levelbuttons[8]);
                SetButtonInactive(levelbuttons[7]);
                SetButtonInactive(levelbuttons[6]);
                SetButtonInactive(levelbuttons[5]);
                SetButtonInactive(levelbuttons[4]);
                SetButtonInactive(levelbuttons[3]);
                SetButtonInactive(levelbuttons[2]);

                break;
            case 9:
                for (int i = 3; i < levelStarImages.Length; i++)
                {   //set all the no stars
                    levelStarImages[i].GetComponent<Image>().color = new Color32(255, 255, 255, 150);
                }
                SetButtonInactive(levelbuttons[9]);
                SetButtonInactive(levelbuttons[8]);
                SetButtonInactive(levelbuttons[7]);
                SetButtonInactive(levelbuttons[6]);
                SetButtonInactive(levelbuttons[5]);
                SetButtonInactive(levelbuttons[4]);
                SetButtonInactive(levelbuttons[3]);
                SetButtonInactive(levelbuttons[2]);
                SetButtonInactive(levelbuttons[1]);
                break;
            default:
                break;
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
    public void SetupLevelStars()
    {
       
        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<Player>();
        player.LoadPlayer();
     
    
        for (int i = 0; i < levelStarImages.Length; i++)
        {   //set all the no stars
            levelStarImages[i].GetComponent<Image>().sprite = unCompleteStar;
        }

        switch (animalNumber)
        {
            case 0:
                for (int i = 0; i < player.chickLevelStars.Length; i++)
                {
                    switch(i)
                    {
                        case 0:
                            if (player.chickLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.chickLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.chickLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.chickLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.chickLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.chickLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.chickLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.chickLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.chickLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.chickLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }

                break;

            case 1:
                for (int i = 0; i < player.chickenLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.chickenLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickenLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickenLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.chickenLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickenLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickenLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.chickenLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickenLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickenLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.chickenLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickenLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickenLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.chickenLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickenLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickenLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.chickenLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickenLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickenLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.chickenLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickenLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickenLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.chickenLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickenLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickenLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.chickenLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickenLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickenLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.chickenLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickenLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.chickenLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 2:
                for (int i = 0; i < player.henLevelStars.Length; i++)
                {

                    switch (i)
                    {
                        case 0:
                            if (player.henLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.henLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.henLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.henLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.henLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.henLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.henLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.henLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.henLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.henLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.henLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.henLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.henLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.henLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.henLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.henLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.henLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.henLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.henLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.henLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.henLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.henLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.henLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.henLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.henLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.henLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.henLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.henLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.henLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.henLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 3:
                for (int i = 0; i < player.duckLevelStars.Length; i++)
                {

                    switch (i)
                    {
                        case 0:
                            if (player.duckLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.duckLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.duckLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.duckLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.duckLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.duckLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.duckLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.duckLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.duckLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.duckLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.duckLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.duckLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.duckLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.duckLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.duckLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.duckLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.duckLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.duckLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.duckLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.duckLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.duckLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.duckLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.duckLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.duckLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.duckLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.duckLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.duckLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.duckLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.duckLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.duckLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 4:
                for (int i = 0; i < player.gobblerLevelStars.Length; i++)
                {

                    switch (i)
                    {
                        case 0:
                            if (player.gobblerLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gobblerLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gobblerLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.gobblerLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gobblerLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gobblerLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.gobblerLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gobblerLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gobblerLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.gobblerLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gobblerLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gobblerLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.gobblerLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gobblerLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gobblerLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.gobblerLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gobblerLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gobblerLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.gobblerLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gobblerLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gobblerLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.gobblerLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gobblerLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gobblerLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.gobblerLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gobblerLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gobblerLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.gobblerLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gobblerLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gobblerLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 5:
                for (int i = 0; i < player.gooseLevelStars.Length; i++)
                {

                    switch (i)
                    {
                        case 0:
                            if (player.gooseLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gooseLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gooseLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.gooseLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gooseLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gooseLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.gooseLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gooseLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gooseLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.gooseLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gooseLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gooseLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.gooseLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gooseLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gooseLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.gooseLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gooseLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gooseLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.gooseLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gooseLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gooseLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.gooseLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gooseLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gooseLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.gooseLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gooseLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gooseLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.gooseLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gooseLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.gooseLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 6:
                for (int i = 0; i < player.drakeLevelStars.Length; i++)
                {

                    switch (i)
                    {
                        case 0:
                            if (player.drakeLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.drakeLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.drakeLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.drakeLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.drakeLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.drakeLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.drakeLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.drakeLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.drakeLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.drakeLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.drakeLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.drakeLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.drakeLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.drakeLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.drakeLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.drakeLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.drakeLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.drakeLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.drakeLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.drakeLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.drakeLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.drakeLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.drakeLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.drakeLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.drakeLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.drakeLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.drakeLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.drakeLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.drakeLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.drakeLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 7:
                for (int i = 0; i < player.turkeyLevelStars.Length; i++)
                {

                    switch (i)
                    {
                        case 0:
                            if (player.turkeyLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.turkeyLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.turkeyLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.turkeyLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.turkeyLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.turkeyLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.turkeyLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.turkeyLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.turkeyLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.turkeyLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.turkeyLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.turkeyLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.turkeyLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.turkeyLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.turkeyLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.turkeyLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.turkeyLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.turkeyLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.turkeyLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.turkeyLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.turkeyLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.turkeyLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.turkeyLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.turkeyLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.turkeyLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.turkeyLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.turkeyLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.turkeyLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.turkeyLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.turkeyLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 8:
                for (int i = 0; i < player.roosterLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.roosterLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.roosterLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.roosterLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.roosterLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.roosterLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.roosterLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.roosterLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.roosterLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.roosterLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.roosterLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.roosterLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.roosterLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.roosterLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.roosterLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.roosterLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.roosterLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.roosterLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.roosterLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.roosterLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.roosterLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.roosterLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.roosterLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.roosterLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.roosterLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.roosterLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.roosterLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.roosterLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.roosterLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.roosterLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.roosterLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 9:
                for (int i = 0; i < player.wHenLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.wHenLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wHenLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wHenLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.wHenLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wHenLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wHenLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.wHenLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wHenLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wHenLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.wHenLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wHenLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wHenLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.wHenLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wHenLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wHenLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.wHenLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wHenLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wHenLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.wHenLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wHenLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wHenLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.wHenLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wHenLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wHenLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.wHenLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wHenLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wHenLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.wHenLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wHenLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wHenLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 10:
                for (int i = 0; i < player.bRoosterLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.bRoosterLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bRoosterLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bRoosterLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.bRoosterLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bRoosterLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bRoosterLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.bRoosterLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bRoosterLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bRoosterLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.bRoosterLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bRoosterLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bRoosterLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.bRoosterLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bRoosterLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bRoosterLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.bRoosterLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bRoosterLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bRoosterLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.bRoosterLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bRoosterLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bRoosterLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.bRoosterLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bRoosterLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bRoosterLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.bRoosterLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bRoosterLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bRoosterLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.bRoosterLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bRoosterLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bRoosterLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 11:
                for (int i = 0; i < player.fTurkeyLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.fTurkeyLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.fTurkeyLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.fTurkeyLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.fTurkeyLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.fTurkeyLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.fTurkeyLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.fTurkeyLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.fTurkeyLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.fTurkeyLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.fTurkeyLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.fTurkeyLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.fTurkeyLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.fTurkeyLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.fTurkeyLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.fTurkeyLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.fTurkeyLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.fTurkeyLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.fTurkeyLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.fTurkeyLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.fTurkeyLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.fTurkeyLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.fTurkeyLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.fTurkeyLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.fTurkeyLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.fTurkeyLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.fTurkeyLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.fTurkeyLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.fTurkeyLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.fTurkeyLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.fTurkeyLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 12:
                for (int i = 0; i < player.wRoosterLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.wRoosterLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wRoosterLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wRoosterLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.wRoosterLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wRoosterLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wRoosterLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.wRoosterLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wRoosterLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wRoosterLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.wRoosterLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wRoosterLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wRoosterLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.wRoosterLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wRoosterLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wRoosterLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.wRoosterLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wRoosterLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wRoosterLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.wRoosterLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wRoosterLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wRoosterLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.wRoosterLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wRoosterLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wRoosterLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.wRoosterLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wRoosterLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wRoosterLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.wRoosterLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wRoosterLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wRoosterLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 13:
                for (int i = 0; i < player.bunnyLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.bunnyLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bunnyLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bunnyLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.bunnyLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bunnyLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bunnyLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.bunnyLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bunnyLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bunnyLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.bunnyLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bunnyLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bunnyLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.bunnyLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bunnyLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bunnyLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.bunnyLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bunnyLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bunnyLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.bunnyLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bunnyLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bunnyLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.bunnyLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bunnyLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bunnyLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.bunnyLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bunnyLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bunnyLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.bunnyLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bunnyLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bunnyLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 14:
                for (int i = 0; i < player.dBunnyLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.dBunnyLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.dBunnyLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.dBunnyLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.dBunnyLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.dBunnyLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.dBunnyLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.dBunnyLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.dBunnyLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.dBunnyLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.dBunnyLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.dBunnyLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.dBunnyLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.dBunnyLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.dBunnyLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.dBunnyLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.dBunnyLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.dBunnyLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.dBunnyLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.dBunnyLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.dBunnyLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.dBunnyLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.dBunnyLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.dBunnyLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.dBunnyLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.dBunnyLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.dBunnyLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.dBunnyLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.dBunnyLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.dBunnyLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.dBunnyLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 15:
                for (int i = 0; i < player.lBunnyLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.lBunnyLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.lBunnyLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.lBunnyLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.lBunnyLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.lBunnyLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.lBunnyLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.lBunnyLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.lBunnyLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.lBunnyLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.lBunnyLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.lBunnyLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.lBunnyLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.lBunnyLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.lBunnyLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.lBunnyLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.lBunnyLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.lBunnyLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.lBunnyLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.lBunnyLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.lBunnyLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.lBunnyLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.lBunnyLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.lBunnyLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.lBunnyLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.lBunnyLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.lBunnyLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.lBunnyLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.lBunnyLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.lBunnyLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.lBunnyLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 16:
                for (int i = 0; i < player.cowLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.cowLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.cowLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.cowLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.cowLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.cowLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.cowLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.cowLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.cowLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.cowLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.cowLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.cowLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.cowLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.cowLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.cowLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.cowLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.cowLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.cowLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.cowLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.cowLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.cowLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.cowLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.cowLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.cowLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.cowLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.cowLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.cowLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.cowLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.cowLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.cowLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.cowLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 17:
                for (int i = 0; i < player.sheepLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.sheepLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.sheepLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.sheepLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.sheepLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.sheepLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.sheepLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.sheepLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.sheepLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.sheepLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.sheepLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.sheepLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.sheepLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.sheepLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.sheepLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.sheepLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.sheepLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.sheepLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.sheepLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.sheepLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.sheepLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.sheepLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.sheepLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.sheepLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.sheepLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.sheepLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.sheepLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.sheepLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.sheepLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.sheepLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.sheepLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 18:
                for (int i = 0; i < player.donkeyLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.donkeyLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.donkeyLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.donkeyLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.donkeyLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.donkeyLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.donkeyLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.donkeyLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.donkeyLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.donkeyLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.donkeyLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.donkeyLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.donkeyLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.donkeyLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.donkeyLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.donkeyLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.donkeyLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.donkeyLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.donkeyLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.donkeyLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.donkeyLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.donkeyLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.donkeyLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.donkeyLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.donkeyLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.donkeyLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.donkeyLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.donkeyLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.donkeyLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.donkeyLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.donkeyLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 19:
                for (int i = 0; i < player.goatLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.goatLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.goatLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.goatLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.goatLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.goatLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.goatLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.goatLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.goatLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.goatLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.goatLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.goatLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.goatLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.goatLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.goatLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.goatLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.goatLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.goatLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.goatLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.goatLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.goatLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.goatLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.goatLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.goatLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.goatLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.goatLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.goatLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.goatLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.goatLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.goatLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.goatLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 20:
                for (int i = 0; i < player.oxLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.oxLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.oxLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.oxLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.oxLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.oxLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.oxLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.oxLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.oxLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.oxLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.oxLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.oxLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.oxLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.oxLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.oxLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.oxLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.oxLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.oxLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.oxLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.oxLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.oxLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.oxLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.oxLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.oxLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.oxLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.oxLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.oxLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.oxLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.oxLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.oxLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.oxLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 21:
                for (int i = 0; i < player.ramLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.ramLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ramLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ramLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.ramLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ramLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ramLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.ramLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ramLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ramLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.ramLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ramLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ramLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.ramLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ramLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ramLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.ramLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ramLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ramLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.ramLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ramLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ramLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.ramLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ramLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ramLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.ramLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ramLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ramLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.ramLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ramLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ramLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 22:
                for (int i = 0; i < player.bullLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.bullLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bullLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bullLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.bullLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bullLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bullLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.bullLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bullLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bullLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.bullLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bullLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bullLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.bullLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bullLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bullLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.bullLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bullLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bullLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.bullLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bullLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bullLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.bullLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bullLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bullLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.bullLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bullLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bullLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.bullLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bullLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.bullLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 23:
                for (int i = 0; i < player.burroLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.burroLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.burroLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.burroLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.burroLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.burroLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.burroLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.burroLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.burroLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.burroLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.burroLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.burroLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.burroLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.burroLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.burroLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.burroLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.burroLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.burroLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.burroLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.burroLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.burroLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.burroLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.burroLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.burroLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.burroLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.burroLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.burroLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.burroLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.burroLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.burroLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.burroLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 24:
                for (int i = 0; i < player.wGoatLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.wGoatLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wGoatLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wGoatLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.wGoatLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wGoatLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wGoatLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.wGoatLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wGoatLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wGoatLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.wGoatLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wGoatLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wGoatLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.wGoatLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wGoatLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wGoatLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.wGoatLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wGoatLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wGoatLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.wGoatLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wGoatLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wGoatLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.wGoatLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wGoatLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wGoatLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.wGoatLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wGoatLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wGoatLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.wGoatLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wGoatLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.wGoatLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }

                break;

            case 25:
                for (int i = 0; i < player.pugLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.pugLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pugLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pugLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.pugLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pugLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pugLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.pugLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pugLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pugLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.pugLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pugLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pugLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.pugLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pugLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pugLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.pugLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pugLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pugLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.pugLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pugLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pugLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.pugLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pugLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pugLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.pugLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pugLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pugLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.pugLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pugLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pugLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 26:
                for (int i = 0; i < player.ponyLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.ponyLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ponyLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ponyLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.ponyLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ponyLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ponyLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.ponyLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ponyLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ponyLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.ponyLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ponyLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ponyLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.ponyLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ponyLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ponyLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.ponyLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ponyLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ponyLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.ponyLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ponyLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ponyLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.ponyLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ponyLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ponyLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.ponyLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ponyLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ponyLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.ponyLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ponyLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.ponyLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 27:
                for (int i = 0; i < player.horseLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.horseLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.horseLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.horseLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.horseLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.horseLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.horseLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.horseLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.horseLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.horseLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.horseLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.horseLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.horseLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.horseLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.horseLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.horseLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.horseLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.horseLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.horseLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.horseLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.horseLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.horseLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.horseLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.horseLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.horseLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.horseLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.horseLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.horseLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.horseLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.horseLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.horseLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 28:
                for (int i = 0; i < player.piggyLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.piggyLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.piggyLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.piggyLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.piggyLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.piggyLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.piggyLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.piggyLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.piggyLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.piggyLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.piggyLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.piggyLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.piggyLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.piggyLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.piggyLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.piggyLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.piggyLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.piggyLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.piggyLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.piggyLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.piggyLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.piggyLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.piggyLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.piggyLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.piggyLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.piggyLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.piggyLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.piggyLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.piggyLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.piggyLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.piggyLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;

            case 29:
                for (int i = 0; i < player.pigLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.pigLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pigLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pigLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.pigLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pigLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pigLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.pigLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pigLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pigLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.pigLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pigLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pigLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.pigLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pigLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pigLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.pigLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pigLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pigLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.pigLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pigLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pigLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.pigLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pigLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pigLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.pigLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pigLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pigLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.pigLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pigLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.pigLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 30:
                for (int i = 0; i < player.porkyLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.porkyLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.porkyLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.porkyLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.porkyLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.porkyLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.porkyLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.porkyLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.porkyLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.porkyLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.porkyLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.porkyLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.porkyLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.porkyLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.porkyLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.porkyLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.porkyLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.porkyLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.porkyLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.porkyLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.porkyLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.porkyLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.porkyLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.porkyLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.porkyLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.porkyLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.porkyLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.porkyLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.porkyLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.porkyLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.porkyLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 31:
                for (int i = 0; i < player.swineLevelStars.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (player.swineLevelStars[0] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[2].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.swineLevelStars[0] == 2)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[1].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.swineLevelStars[0] == 1)
                            {
                                levelStarImages[0].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 1:
                            if (player.swineLevelStars[1] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[5].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.swineLevelStars[1] == 2)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[4].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.swineLevelStars[1] == 1)
                            {
                                levelStarImages[3].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 2:
                            if (player.swineLevelStars[2] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[8].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.swineLevelStars[2] == 2)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[7].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.swineLevelStars[2] == 1)
                            {
                                levelStarImages[6].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 3:
                            if (player.swineLevelStars[3] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[11].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.swineLevelStars[3] == 2)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[10].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.swineLevelStars[3] == 1)
                            {
                                levelStarImages[9].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 4:
                            if (player.swineLevelStars[4] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[14].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.swineLevelStars[4] == 2)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[13].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.swineLevelStars[4] == 1)
                            {
                                levelStarImages[12].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 5:
                            if (player.swineLevelStars[5] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[17].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.swineLevelStars[5] == 2)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[16].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.swineLevelStars[5] == 1)
                            {
                                levelStarImages[15].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 6:
                            if (player.swineLevelStars[6] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[20].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.swineLevelStars[6] == 2)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[19].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.swineLevelStars[6] == 1)
                            {
                                levelStarImages[18].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 7:
                            if (player.swineLevelStars[7] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[23].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.swineLevelStars[7] == 2)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[22].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.swineLevelStars[7] == 1)
                            {
                                levelStarImages[21].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 8:
                            if (player.swineLevelStars[8] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[26].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.swineLevelStars[8] == 2)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[25].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.swineLevelStars[8] == 1)
                            {
                                levelStarImages[24].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        case 9:
                            if (player.swineLevelStars[9] == 3)
                            {
                                // set 3 stars 
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[29].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.swineLevelStars[9] == 2)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                                levelStarImages[28].GetComponent<Image>().sprite = completeStar;
                            }
                            else if (player.swineLevelStars[9] == 1)
                            {
                                levelStarImages[27].GetComponent<Image>().sprite = completeStar;
                            }
                            else
                            {
                                // do nothing as no stars 
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;
            default:
                break;
        }
      
      
    }
    public void CloseLevelSelectMenu()
    {
        active = false;
        GameObject[] gameObject1 = GameObject.FindGameObjectsWithTag("MainMenuUI");
        OnAndOffButton(gameObject1);
        mainMenuScript.ShaderOff();
        levelMenu.gameObject.SetActive(false);
    }
    public void OnAndOffButton(GameObject[] gameObject)
    {
        for (int i = 0; i <= gameObject.Length - 1; i++)
        {
            Button button = gameObject[i].GetComponent<Button>();
            button.interactable = !button.interactable;
        }
    }
  
    public void levelButtonPress(int level)
    {
        EventSystem.current.SetSelectedGameObject(levelbuttons[level-1].gameObject);
        levelNumber = level;
    }
    public void PlayGame()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("MainMenuUI");
        OnAndOffButton(gameObjects);
        active = false;
        CloseLevelSelectMenu();
        GameController.animalNumber = this.animalNumber;
        GameController.levelNumber = this.levelNumber;
        audioManager.StopBGMusic();
        LeverLoader.levelToLoad = 1;
        LeverLoader.isLoaded = false;
        LeverLoader.instance.LoadNextLevel();

    }
    public LeverLoader levelLoader;
}
