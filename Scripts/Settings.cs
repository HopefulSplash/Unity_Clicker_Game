using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Player player;
    public GameObject settingsMenu;
    private Button settingsButton;
    public GameObject mainMenu;
    public GameObject musicMute;
    public GameObject sfxMute;
    public GameObject sfx;
    public GameObject music;
    public KeepAudio audioManager;
    private GameObject[] gameObjectArray;
    public MainMenuScript mainMenuScript;
    public GameObject shader;
    public GameObject HUD;
    public GameObject[] Foreground;
    public GameController gameController;

    // Start is called before the first frame update
    private void Awake()
    {
     
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float restMVol = 0;
    public float tempMusicVol;
    public float tempSFXvol;
    public void LoadSettings()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("backgroundMusic");
        audioManager = temp.GetComponent<KeepAudio>();
        
        tempMusicVol = audioManager.backgroundMusic.volume;
        tempSFXvol = audioManager.SFX[0].volume;
        restMVol = tempMusicVol;
        UpdateUI("SFX", tempSFXvol);
        UpdateUI("Music", tempMusicVol);

    }
    //this
    public void UpdateUI(string option, float vol)
    {

        if (option == "Music")
        {
            music = GameObject.FindGameObjectWithTag("MusicVolSlider");
            music.GetComponent<Slider>().value = vol*100;

            if (vol > 0)
            {
                musicMute = GameObject.FindGameObjectWithTag("MusicSlider");
                musicMute.GetComponent<Slider>().value = 1;

            }
            else if (vol <= 0)
            {
                musicMute = GameObject.FindGameObjectWithTag("MusicSlider");
                musicMute.GetComponent<Slider>().value = 0;
            }
        }
        else if (option == "SFX")
        {
            sfx = GameObject.FindGameObjectWithTag("SFXVolSlider");
            sfx.GetComponent<Slider>().value = vol * 100;

            if (vol > 0)
            {

                sfxMute = GameObject.FindGameObjectWithTag("MusicSlider");
                sfxMute.GetComponent<Slider>().value = 1;
            }
            else if (vol <= 0)
            {

                sfxMute = GameObject.FindGameObjectWithTag("MusicSlider");
                sfxMute.GetComponent<Slider>().value = 0;
            }
        }
    }

    public void SettingMenuPressed()
    {
        mainMenuScript.ShaderON();

        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<Player>();
        player.LoadPlayer();


        gameObjectArray = GameObject.FindGameObjectsWithTag("MainMenuUI");
        OnAndOffButton(gameObjectArray);

        settingsMenu.gameObject.SetActive(true);
        LoadSettings();



    }

    public void SettingMenuPressedGame()
    {
        
        Time.timeScale = 0f;
        foreach (GameObject element in Foreground)
        {
            element.SetActive(false);
        }
        HUD.gameObject.SetActive(false);
        shader.gameObject.SetActive(true);

        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<Player>();
        player.LoadPlayer();


        gameObjectArray = GameObject.FindGameObjectsWithTag("MainMenuUI");
        OnAndOffButton(gameObjectArray);

        settingsMenu.gameObject.SetActive(true);
        LoadSettings();



    }
    public void UpdateSettingsMenu()
    {
        settingsMenu.gameObject.SetActive(false);
    }

    public void OnAndOffButton(GameObject[] gameObject)
    {
        for (int i = 0; i <= gameObject.Length - 1; i++)
        {
            Button button = gameObject[i].GetComponent<Button>();
            button.interactable = !button.interactable;
        }
    }
    public void CloseSettingsMenu(string option)
    {
        if (option == "Cross")
        {

            // Storing the GameObject reference to retrieve a component
            gameObjectArray = GameObject.FindGameObjectsWithTag("MainMenuUI");
            CloseButtonPressed();
            OnAndOffButton(gameObjectArray);

            settingsMenu.gameObject.SetActive(false);
        }
        else if (option == "Okay")
        {

            // Storing the GameObject reference to retrieve a component
            gameObjectArray = GameObject.FindGameObjectsWithTag("MainMenuUI");
            OkayButtonPressed();
            OnAndOffButton(gameObjectArray);

            settingsMenu.gameObject.SetActive(false);
        }
        mainMenuScript.ShaderOff();
    }
    public bool pauseMenuOpen = false;
    public PauseMenu pauseMenu;
    public List<GameObject> HUDButtons;

    public void CloseSettingsMenuGame(string option)
    {
        if (option == "Cross")
        {

            // Storing the GameObject reference to retrieve a component
            gameObjectArray = GameObject.FindGameObjectsWithTag("MainMenuUI");
            CloseButtonPressed();
            OnAndOffButton(gameObjectArray);

            settingsMenu.gameObject.SetActive(false);
        }
        else if (option == "Okay")
        {

            // Storing the GameObject reference to retrieve a component
            gameObjectArray = GameObject.FindGameObjectsWithTag("MainMenuUI");
            OkayButtonPressed();
            OnAndOffButton(gameObjectArray);

            settingsMenu.gameObject.SetActive(false);
        }

        if (!pauseMenuOpen)
        {
          

            OnAndOffButton(HUDButtons.ToArray());
            Time.timeScale = 1f;
            shader.gameObject.SetActive(false);
            HUD.gameObject.SetActive(true);
            gameController.paused = true;
            gameController.GameStartCountDown();
        }
        else if (pauseMenuOpen)
        { 
            pauseMenu.gameObject.SetActive(true);
            pauseMenuOpen = false;
            HUD.gameObject.SetActive(true);
        }
        
    }

    public void MuteToggleFlipped(string option)
    {
        musicMute = GameObject.FindGameObjectWithTag("MusicSlider");
        float music_Temp = musicMute.GetComponent<Slider>().value;

        sfxMute = GameObject.FindGameObjectWithTag("SFXSlider");
        float music_Sfx = sfxMute.GetComponent<Slider>().value;
        //Unmuted
        if (option == "Music")
        {
            if (music_Temp == 0)
            {
                music = GameObject.FindGameObjectWithTag("MusicVolSlider");
                music.GetComponent<Slider>().value = 0;
            }
            //Muted
            else if (music_Temp == 1)
            {
                music = GameObject.FindGameObjectWithTag("MusicVolSlider");
                    
                if (music.GetComponent<Slider>().value == 0)
                {
                    music.GetComponent<Slider>().value = 10;
                }
                    
                
            }
        }
        else if (option == "SFX")
        {
            if (music_Sfx == 0)
            {
                sfx = GameObject.FindGameObjectWithTag("SFXVolSlider");
                sfx.GetComponent<Slider>().value = 0;
            }
            //Muted
            else if (music_Sfx == 1)
            {
                sfx = GameObject.FindGameObjectWithTag("SFXVolSlider");
                if (sfx.GetComponent<Slider>().value == 0)
                {
                    sfx.GetComponent<Slider>().value = 10;
                }
            }
        }
    }

    public void SetMusicVolume(string option, float vol)
    {
        GameObject temp = GameObject.FindGameObjectWithTag("backgroundMusic");
        audioManager = temp.GetComponent<KeepAudio>();

        if (option == "SFX")
        {
            audioManager.UpdateSFXSound(vol, "Update");
        }
        else if (option == "Music")
        {
            audioManager.UpdateSound(vol);
        }
    }

    public void VolumeToggleMoved(string option)
    {
        music = GameObject.FindGameObjectWithTag("MusicVolSlider");
        float music_Temp = music.GetComponent<Slider>().value;

        sfx = GameObject.FindGameObjectWithTag("SFXVolSlider");
        float music_Sfx = sfx.GetComponent<Slider>().value;
        //Unmuted
        if (option == "Music")
        {
            musicMute = GameObject.FindGameObjectWithTag("MusicSlider");
            if (music_Temp == 0)
            {

                musicMute.GetComponent<Slider>().value = 0;
            }
            else
            {
                musicMute.GetComponent<Slider>().value = 1;
            }
            SetMusicVolume(option, music_Temp);
        }
        //herer
        else if (option == "SFX")
        {
            sfxMute = GameObject.FindGameObjectWithTag("SFXSlider");
            if (music_Sfx == 0)
            {

                sfxMute.GetComponent<Slider>().value = 0;
            }
            else
            {
                sfxMute.GetComponent<Slider>().value = 1;
            }
            SetMusicVolume(option, music_Sfx);
        }
    }
    public void OkayButtonPressed()
    {
        //save here
        music = GameObject.FindGameObjectWithTag("MusicVolSlider");
        player.backgroundMusicLevelSettings = music.GetComponent<Slider>().value/100;

        sfx = GameObject.FindGameObjectWithTag("SFXVolSlider");
        player.SFXMusicLevelSettings = sfx.GetComponent<Slider>().value/100;

        SaveSystem.SavePlayer(player);
    }

    public void CloseButtonPressed()
    {   
        if (audioManager.muted != true)
        {
            audioManager.UpdateSound(player.backgroundMusicLevelSettings * 100);
            audioManager.UpdateSFXSound(player.SFXMusicLevelSettings * 100, "Update");
        }
        else
        {
            music = GameObject.FindGameObjectWithTag("MusicVolSlider");
            music.GetComponent<Slider>().value = 0;

            sfx = GameObject.FindGameObjectWithTag("SFXVolSlider");
            sfx.GetComponent<Slider>().value = 0;

        }

    }
    public void GameSettingsUpdate()
    {
        if (HUDButtons.ToArray().Length == 0)
        {
            HUDButtons.Add(GameObject.FindGameObjectWithTag("pauseButton"));
            HUDButtons.Add(GameObject.FindGameObjectWithTag("muteButton"));
            HUDButtons.Add(GameObject.FindGameObjectWithTag("attackToggle"));
            HUDButtons.Add(GameObject.FindGameObjectWithTag("potionToggle"));
        }

    }
}
