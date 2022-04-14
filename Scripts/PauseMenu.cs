using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public PauseMenu pauseMenu;
    public Player player;
    public UnityAdManager adManager;
    public List<GameObject> HUDButtons;
    public GameObject shader;
    public GameObject HUD;
    public Settings settingsMenu;
    public GameObject confirmMenu;
    public GameObject[] pauseButtons;
    public GameObject confirmShader;
    public KeepAudio audioManager;
    public GameController gameController;
    public GameObject[] Foreground;
    public Text playerScore;
    public Image[] gameStars;
    public Sprite completedStar;
    public Sprite unCompletedStar;
    public Button rButton;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdatePauseMenu()
    {
        HUDButtons.Add(GameObject.FindGameObjectWithTag("pauseButton"));
        HUDButtons.Add(GameObject.FindGameObjectWithTag("muteButton"));
        HUDButtons.Add(GameObject.FindGameObjectWithTag("attackToggle"));
        HUDButtons.Add(GameObject.FindGameObjectWithTag("potionToggle"));
        pauseMenu.gameObject.SetActive(false);
        confirmMenu.gameObject.SetActive(false);
        confirmShader.gameObject.SetActive(false);
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

    public void PauseMenuPressed()
    {
        Time.timeScale = 0f;
        foreach (GameObject element in Foreground) 
        {
            element.SetActive(false);
        }

        if (player.playerHearts > 0)
        {
            SetButtonActive(rButton);
        }
        else
        {
            SetButtonInactive(rButton);
        }

        audioManager.StopGameBackgroundMusic();
        shader.gameObject.SetActive(true);
        pauseMenu.gameObject.SetActive(true);
       
        OnAndOffButton(HUDButtons.ToArray());
        HUD.gameObject.SetActive(false);
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
    public void SettingsPressed()
    {
        EventSystem.current.SetSelectedGameObject(null);
        pauseMenu.gameObject.SetActive(false);
        settingsMenu.pauseMenuOpen = true;
        settingsMenu.SettingMenuPressedGame();

    }
        public int confirmOption;
    public void HomePressed()
    {
        EventSystem.current.SetSelectedGameObject(null);
        confirmShader.gameObject.SetActive(true);
        confirmOption = 0;
        confirmMenu.SetActive(true);

        Text tem = GameObject.FindGameObjectWithTag("confirmText").GetComponent<Text>();
        tem.text = "Current Progress Will Be Lost! Are You Sure You Want To Quit The Game?";

        pauseButtons = GameObject.FindGameObjectsWithTag("pauseButtons");
        OnAndOffButton(pauseButtons);
    }
    public void RestartPressed()
    {
        EventSystem.current.SetSelectedGameObject(null);
        confirmShader.gameObject.SetActive(true);
        confirmOption = 1;
        confirmMenu.SetActive(true);
            Text tem = GameObject.FindGameObjectWithTag("confirmText").GetComponent<Text>();
            tem.text = "Current Progress Will Be Lost! Are You Sure You Want To Restart The Game?";

        pauseButtons = GameObject.FindGameObjectsWithTag("pauseButtons");
        OnAndOffButton(pauseButtons);
    }
    public void ConfirmRestart()
    {
        if (confirmOption == 1)
        {
            confirmMenu.gameObject.SetActive(false);
            pauseButtons = GameObject.FindGameObjectsWithTag("pauseButtons");
            OnAndOffButton(pauseButtons);
            pauseMenu.gameObject.SetActive(false);
            EventSystem.current.SetSelectedGameObject(null);
            PlayServices.control.AddScoreToLeaderBoard();
            audioManager.StopBGMusic();
            gameController.paused = true;
            Time.timeScale = 1f;
            LeverLoader.isLoaded = false;
            LeverLoader.instance.StopAllCoroutines();
            LeverLoader.levelToLoad = 1;
            LeverLoader.instance.LoadNextLevel();
        }
        else if (confirmOption == 0)
        {
            confirmMenu.gameObject.SetActive(false);
            pauseButtons = GameObject.FindGameObjectsWithTag("pauseButtons");
            OnAndOffButton(pauseButtons);
            pauseMenu.gameObject.SetActive(false);
            EventSystem.current.SetSelectedGameObject(null);
            PlayServices.control.AddScoreToLeaderBoard();
            audioManager.StopBGMusic();
            gameController.paused = true;
            Time.timeScale = 1f;
            LeverLoader.isLoaded = false;
            LeverLoader.instance.StopAllCoroutines();
            LeverLoader.levelToLoad = 0;
            LeverLoader.instance.LoadNextLevel();

        }
    }
    public void PausePressed()
    {
        EventSystem.current.SetSelectedGameObject(null);
        Time.timeScale = 1f;
        pauseMenu.gameObject.SetActive(false);
        shader.gameObject.SetActive(false);
        HUD.gameObject.SetActive(true);
        gameController.paused = true;
        gameController.GameStartCountDown();      
    }
    public void ClosePauseMenu(int option)
    {
        if (option == 0)
        {
            Time.timeScale = 1f;
            pauseMenu.gameObject.SetActive(false);
            shader.gameObject.SetActive(false);
            HUD.gameObject.SetActive(true);
            gameController.paused = true;
            gameController.GameStartCountDown();
        }
        else if (option == 1)
        {
            confirmMenu.gameObject.SetActive(false);
            pauseButtons = GameObject.FindGameObjectsWithTag("pauseButtons");
            OnAndOffButton(pauseButtons);
            confirmShader.gameObject.SetActive(false);
        }
        EventSystem.current.SetSelectedGameObject(null);

    }
}
