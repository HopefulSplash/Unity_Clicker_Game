using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AnimalMenu : MonoBehaviour
{
    public AnimalMenu animalMenu;
    public Quest quest;
    public MainMenuScript mainMenuScript;
    public Player player;
    private GameObject[] gameObject1;
    public GameObject[] animals;
    public Button leftButton;
    public Button rightButton;
    private int selectedAnimal = 0;
    public Text animalNameText;
    public Button acceptButton;
    public Button unlockButton;
    public Button closeButton;
    public GameObject confirmMenu;
    public GameObject confirmShader;
    public Button confirmAcceptButton;
    public int[] animalPriceList = { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, 210, 220, 250, 260, 270, 280, 290, 300, 310, 320, 330};
    public Text confirmPriceText;
    public Text confirmNameText;
    public Sprite completeStar;
    public Sprite unCompleteStar;
    public Image starImage;
    public Text starText;
    public LevelMenu level;
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UpdateAnimalMenu()
    {
        GameController.justLooking = true;
        animalMenu.gameObject.SetActive(false);
    }
    public void AnimalMenuButtonPressed()
    {
        confirmShader.SetActive(false);
        mainMenuScript.ShaderON();
        gameObject1 = GameObject.FindGameObjectsWithTag("MainMenuUI");
        OnAndOffButton(gameObject1);

        animalMenu.gameObject.SetActive(true);
        confirmMenu.SetActive(false);

 
        LoadAnimalSettings();

    }
    public void DoStarStuff()
    {

        if (starTotal == 30)
        {
            GameObject gS = GameObject.FindGameObjectWithTag("starImage");
            starImage = gS.GetComponent<Image>();
            starImage.GetComponent<Image>().sprite = completeStar;
        }
        else
        {
            GameObject gS = GameObject.FindGameObjectWithTag("starImage");
            starImage = gS.GetComponent<Image>();
            starImage.GetComponent<Image>().sprite = unCompleteStar;
        }
        GameObject tS = GameObject.FindGameObjectWithTag("starText");
        starText = tS.GetComponent<Text>();
        starText.text = starTotal + "/30";
    }
    int starTotal = 0;
    public void  CheckStars(int animalNumber)
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<Player>();
        player.LoadPlayer();
        starTotal = 0;
        selectedAnimal = animalNumber;
        switch (selectedAnimal)
        {
            case 0:
                for (int i = 0; i < player.chickLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.chickLevelStars[i];
                }
                DoStarStuff();
                break;

            case 1:
                for (int i = 0; i < player.chickenLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.chickenLevelStars[i];
                }
                DoStarStuff();
                break;

            case 2:
                for (int i = 0; i < player.henLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.henLevelStars[i];
                }
                DoStarStuff();
                break;

            case 3:
                for (int i = 0; i < player.duckLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.duckLevelStars[i];
                }
                DoStarStuff();
                break;

            case 4:
                for (int i = 0; i < player.gobblerLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.gobblerLevelStars[i];
                }
                DoStarStuff();
                break;

            case 5:
                for (int i = 0; i < player.gooseLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.gooseLevelStars[i];
                }
                DoStarStuff();
                break;

            case 6:
                for (int i = 0; i < player.drakeLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.drakeLevelStars[i];
                }
                DoStarStuff();
                break;

            case 7:
                for (int i = 0; i < player.turkeyLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.turkeyLevelStars[i];
                }
                DoStarStuff();
                break;

            case 8:
                for (int i = 0; i < player.roosterLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.roosterLevelStars[i];
                }
                DoStarStuff();
                break;

            case 9:
                for (int i = 0; i < player.wHenLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.wHenLevelStars[i];
                }
                DoStarStuff();
                break;
            case 10:
                for (int i = 0; i < player.bRoosterLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.bRoosterLevelStars[i];
                }
                DoStarStuff();
                break;

            case 11:
                for (int i = 0; i < player.fTurkeyLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.fTurkeyLevelStars[i];
                }
                DoStarStuff();
                break;

            case 12:
                for (int i = 0; i < player.wRoosterLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.wRoosterLevelStars[i];
                }
                DoStarStuff();
                break;

            case 13:
                for (int i = 0; i < player.bunnyLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.bunnyLevelStars[i];
                }
                DoStarStuff();
                break;

            case 14:
                for (int i = 0; i < player.dBunnyLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.dBunnyLevelStars[i];
                }
                DoStarStuff();
                break;

            case 15:
                for (int i = 0; i < player.lBunnyLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.lBunnyLevelStars[i];
                }
                DoStarStuff();
                break;

            case 16:
                for (int i = 0; i < player.cowLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.cowLevelStars[i];
                }
                DoStarStuff();
                break;

            case 17:
                for (int i = 0; i < player.sheepLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.sheepLevelStars[i];
                }
                DoStarStuff();
                break;

            case 18:
                for (int i = 0; i < player.donkeyLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.donkeyLevelStars[i];
                }
                DoStarStuff();
                break;

            case 19:
                for (int i = 0; i < player.goatLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.goatLevelStars[i];
                }
                DoStarStuff();
                break;
            case 20:
                for (int i = 0; i < player.oxLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.oxLevelStars[i];
                }
                DoStarStuff();
                break;

            case 21:
                for (int i = 0; i < player.ramLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.ramLevelStars[i];
                }
                DoStarStuff();
                break;

            case 22:
                for (int i = 0; i < player.bullLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.bullLevelStars[i];
                }
                DoStarStuff();
                break;

            case 23:
                for (int i = 0; i < player.burroLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.burroLevelStars[i];
                }
                DoStarStuff();
                break;

            case 24:
                for (int i = 0; i < player.wGoatLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.wGoatLevelStars[i];
                }
                DoStarStuff();

                break;

            case 25:
                for (int i = 0; i < player.pugLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.pugLevelStars[i];
                }
                DoStarStuff();
                break;

            case 26:
                for (int i = 0; i < player.ponyLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.ponyLevelStars[i];
                }
                DoStarStuff();
                break;

            case 27:
                for (int i = 0; i < player.horseLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.horseLevelStars[i];
                }
                DoStarStuff();
                break;

            case 28:
                for (int i = 0; i < player.piggyLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.piggyLevelStars[i];
                }
                DoStarStuff();
                break;

            case 29:
                for (int i = 0; i < player.pigLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.pigLevelStars[i];
                }
                DoStarStuff();
                break;
            case 30:
                for (int i = 0; i < player.porkyLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.porkyLevelStars[i];
                }
                DoStarStuff();
                break;
            case 31:
                for (int i = 0; i < player.swineLevelStars.Length; i++)
                {
                    starTotal = starTotal + player.swineLevelStars[i];
                }
                DoStarStuff();
                break;
            default:
                break;
        }


    }
    public void AcceptButtonPressed()
    {
        level.ShowLevelSelect(selectedAnimal);
        animalMenu.gameObject.SetActive(false);
    }
    public void ConfirmMenuPressed()
    {
        confirmShader.SetActive(true);
        GameObject[] tempGOs = { closeButton.gameObject, leftButton.gameObject, rightButton.gameObject, acceptButton.gameObject, unlockButton.gameObject };
        OnAndOffButton(tempGOs);
        confirmMenu.SetActive(true);
        confirmNameText.text = animals[selectedAnimal].name;
        confirmPriceText.text = animalPriceList[selectedAnimal] + " Gems.";

        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<Player>();
        player.LoadPlayer();

        if (player.playerGems < animalPriceList[selectedAnimal])
        {
            SetButtonInactive(confirmAcceptButton);
           
        }
        else
        {           
            SetButtonActive(confirmAcceptButton);
        }
    }
    public void ConfirmAcceptPressed()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<Player>();
        player.LoadPlayer();
        player.playerGems = player.playerGems - animalPriceList[selectedAnimal];

        switch (selectedAnimal)
        {
            case 0:
                player.chickLevelUnlocked = true;
                break;

            case 1:
                player.chickenLevelUnlocked = true;
                break;

            case 2:
                player.henLevelUnlocked = true;
                break;

            case 3:
                player.duckLevelUnlocked = true;
                break;

            case 4:
                player.gobblerLevelUnlocked = true;
                break;

            case 5:
                player.gooseLevelUnlocked = true;
                break;

            case 6:
                player.drakeLevelUnlocked = true;
                break;

            case 7:
                player.turkeyLevelUnlocked = true;
                break;

            case 8:
                player.roosterLevelUnlocked = true;
                break;

            case 9:
                player.wHenLevelUnlocked = true;
                break;
            case 10:
                player.bRoosterLevelUnlocked = true;
                break;

            case 11:
                player.fTurkeyLevelUnlocked = true;
                break;

            case 12:
                player.wRoosterLevelUnlocked = true;
                break;

            case 13:
                player.bunnyLevelUnlocked = true;
                break;

            case 14:
                player.dBunnyLevelUnlocked = true;
                break;

            case 15:
                player.lBunnyLevelUnlocked = true;
                break;

            case 16:
                player.cowLevelUnlocked = true;
                break;

            case 17:
                player.sheepLevelUnlocked = true;
                break;

            case 18:
                player.donkeyLevelUnlocked = true;
                break;

            case 19:
                player.goatLevelUnlocked = true;
                break;
            case 20:
                player.oxLevelUnlocked = true;
                break;

            case 21:
                player.ramLevelUnlocked = true;
                break;

            case 22:
                player.bullLevelUnlocked = true;
                break;

            case 23:
                player.burroLevelUnlocked = true;
                break;

            case 24:
                player.wGoatLevelUnlocked = true;
                break;

            case 25:
                player.pugLevelUnlocked = true;
                break;

            case 26:
                player.ponyLevelUnlocked = true;
                break;

            case 27:
                player.horseLevelUnlocked = true;
                break;

            case 28:
                player.piggyLevelUnlocked = true;
                break;

            case 29:
                player.pigLevelUnlocked = true;
                break;
            case 30:
                player.porkyLevelUnlocked = true;
                break;
            case 31:
                player.swineLevelUnlocked = true;
                break;
            default:
                break;
        }

        PlayServices.control.UnlockAnimalAchivement(1);

        player.SavePlayer();
        ShowOne(selectedAnimal);
        quest.addAnimalQuest(1);
        ConfirmMenuClose();
    }
    public void ConfirmMenuDecline()
    {
        ConfirmMenuClose();
    }
    public void ConfirmMenuClose()
    {
        confirmShader.SetActive(false);
        GameObject[] tempGOs = {closeButton.gameObject, leftButton.gameObject, rightButton.gameObject, acceptButton.gameObject, unlockButton.gameObject};
        OnAndOffButton(tempGOs);
        confirmMenu.SetActive(false);
    }

    public void LoadAnimalSettings()
    {
        HideAll();
        selectedAnimal = 0;
        ShowOne(selectedAnimal);
        if (selectedAnimal != 0)
        {
            leftButton.gameObject.SetActive(true);
        }
        else if (selectedAnimal == 0)
        {
            leftButton.gameObject.SetActive(false);
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

    public void CloseAnimaltMenu(string option)
    {
        gameObject1 = GameObject.FindGameObjectsWithTag("MainMenuUI");
        OnAndOffButton(gameObject1);
        mainMenuScript.ShaderOff();
        animalMenu.gameObject.SetActive(false);
    }
    public void OnAndOffButton(GameObject[] gameObject)
    {
        for (int i = 0; i <= gameObject.Length - 1; i++)
        {
            Button button = gameObject[i].GetComponent<Button>();
            button.interactable = !button.interactable;
        }
    }

    public void HideAll()
    {
        for (int i = 0; i < animals.Length; i++)
        {
            animals[i].SetActive(false);        
        }
    }
    public void ShowOne(int whichOne)
    {
        for (int i = 0; i < animals.Length; i++)
        {
            if (i == whichOne)
            {
                animalNameText.text = animals[i].name;
                animals[i].SetActive(true);
                CheckIfUnlocked(i);
                CheckStars(i);
            }
        }
    }
    public bool unlocked;
    public void CheckIfUnlocked(int animalNumber)
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<Player>();
        player.LoadPlayer();

        switch (animalNumber)
        {
            case 0:
                this.unlocked = player.chickLevelUnlocked;
                break;

            case 1:
                this.unlocked = player.chickenLevelUnlocked;
                break;

            case 2:
                unlocked = player.henLevelUnlocked;
                break;

            case 3:
                unlocked = player.duckLevelUnlocked;
                break;

            case 4:
                unlocked = player.gobblerLevelUnlocked;
                break;

            case 5:
                unlocked = player.gooseLevelUnlocked;
                break;

            case 6:
                unlocked = player.drakeLevelUnlocked;
                break;

            case 7:
                unlocked = player.turkeyLevelUnlocked;
                break;

            case 8:
                unlocked = player.roosterLevelUnlocked;
                break;

            case 9:
                unlocked = player.wHenLevelUnlocked;
                break;
            case 10:
                unlocked = player.bRoosterLevelUnlocked;
                break;

            case 11:
                unlocked = player.fTurkeyLevelUnlocked;
                break;

            case 12:
                unlocked = player.wRoosterLevelUnlocked;
                break;

            case 13:
                unlocked = player.bunnyLevelUnlocked;
                break;

            case 14:
                unlocked = player.dBunnyLevelUnlocked;
                break;

            case 15:
                unlocked = player.lBunnyLevelUnlocked;
                break;

            case 16:
                unlocked = player.cowLevelUnlocked;
                break;

            case 17:
                unlocked = player.sheepLevelUnlocked;
                break;

            case 18:
                unlocked = player.donkeyLevelUnlocked;
                break;

            case 19:
                unlocked = player.goatLevelUnlocked;
                break;
            case 20:
                unlocked = player.oxLevelUnlocked;
                break;

            case 21:
                unlocked = player.ramLevelUnlocked;
                break;

            case 22:
                unlocked = player.bullLevelUnlocked;
                break;

            case 23:
                unlocked = player.burroLevelUnlocked;
                break;

            case 24:
                unlocked = player.wGoatLevelUnlocked;
                break;

            case 25:
                unlocked = player.pugLevelUnlocked;
                break;

            case 26:
                unlocked = player.ponyLevelUnlocked;
                break;

            case 27:
                unlocked = player.horseLevelUnlocked;
                break;

            case 28:
                unlocked = player.piggyLevelUnlocked;
                break;

            case 29:
                unlocked = player.pigLevelUnlocked;
                break;
            case 30:
                unlocked = player.porkyLevelUnlocked;
                break;
            case 31:
                unlocked = player.swineLevelUnlocked;
                break;
            default:
                break;
        }

        if (unlocked)
        {
            acceptButton.gameObject.gameObject.SetActive(true);
            unlockButton.gameObject.gameObject.SetActive(false);
            Unlocked();
        }
        else if (unlocked == false)
        {
            unlockButton.gameObject.gameObject.SetActive(true);
            acceptButton.gameObject.gameObject.SetActive(false);
            NotUnlocked();
        }
    }
    public void NotUnlocked()
    {
        SpriteRenderer sprite = GetComponentInChildren<SpriteRenderer>();
        sprite.color = new Color32(8, 7, 7, 255);
        SpriteRenderer[] sprite2 = sprite.GetComponentsInChildren<SpriteRenderer>();
        foreach (SpriteRenderer sprtie1 in sprite2)
        {
            sprtie1.color = new Color32(8, 7, 7, 255);
        }
    }
    public void Unlocked()
    {
        SpriteRenderer sprite = GetComponentInChildren<SpriteRenderer>();
        sprite.color = new Color32(255, 255, 255, 255);
        SpriteRenderer[] sprite2 = sprite.GetComponentsInChildren<SpriteRenderer>();
        foreach (SpriteRenderer sprtie1 in sprite2)
        {
            sprtie1.color = new Color32(255, 255, 255, 255);
        }
    }
    public void NextAnimal()
    {
        EventSystem.current.SetSelectedGameObject(null);
        animals[selectedAnimal].SetActive(false);

        selectedAnimal++;

        if (selectedAnimal == animals.Length -1)
        {

            rightButton.gameObject.SetActive(false);
            leftButton.gameObject.SetActive(true);
        }
        else 
        {

            leftButton.gameObject.SetActive(true);
        }

        animals[selectedAnimal].SetActive(true);
        animalNameText.text = animals[selectedAnimal].name;

        CheckIfUnlocked(selectedAnimal);

        CheckStars(selectedAnimal);
    }
    public void PreviousAnimal()
    {
      
        EventSystem.current.SetSelectedGameObject(null);
        animals[selectedAnimal].SetActive(false);
        selectedAnimal--;
        if (selectedAnimal == 0)
        {
            rightButton.gameObject.SetActive(true);
            leftButton.gameObject.SetActive(false);
            selectedAnimal =0;
        }
        else
        {
            rightButton.gameObject.SetActive(true);
            leftButton.gameObject.SetActive(true);
        }
        animals[selectedAnimal].SetActive(true);
        animalNameText.text = animals[selectedAnimal].name;
        CheckIfUnlocked(selectedAnimal);
        CheckStars(selectedAnimal);
    }
}
