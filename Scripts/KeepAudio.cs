using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KeepAudio : MonoBehaviour
{
    public Settings settings;
    public AudioSource backgroundMusic;
    public AudioSource bossBackgroundMusic;
    public AudioSource gameOverSound;
    public AudioSource[] SFX;
    public Player player;
    public Button muteButton;
    public Sprite[] unmutedSprite;
    public Sprite[] muteSprite;
    public GameObject[] Foreground;
    void Awake()
    {      
    }
    public bool muted = false;
    public void PlayBGMusic()
    {
        backgroundMusic.Play();
    }
    public void StopBGMusic()
    {
        backgroundMusic.Stop();
    }
    public void MuteBackgroundMusic(int option)
    {
        if (backgroundMusic.volume != 0)
        {
            muted = true;
            backgroundMusic.volume = 0;
            player.backgroundMusicLevel = 0;
            UpdateSFXSound(0, "Update");
            player.SFXMusicLevel = 0;
            GameObject temp = GameObject.FindGameObjectWithTag("Player");
            player = temp.GetComponent<Player>();
            SaveSystem.SavePlayer(player);
            UpdateMuteButton(backgroundMusic.volume);

        }
        else if (backgroundMusic.volume == 0 && player.backgroundMusicLevelSettings != 0)
        {
            muted = false;
            backgroundMusic.volume = player.backgroundMusicLevelSettings;
            player.backgroundMusicLevel = backgroundMusic.volume;
            UpdateSFXSound(player.SFXMusicLevelSettings, "Load");
            player.SFXMusicLevel = player.SFXMusicLevelSettings;
            GameObject temp = GameObject.FindGameObjectWithTag("Player");
            player = temp.GetComponent<Player>();
            SaveSystem.SavePlayer(player);
            UpdateMuteButton(backgroundMusic.volume);
        }
        else if (backgroundMusic.volume == 0 && player.backgroundMusicLevelSettings == 0)
        {
            if (option == 0)
            {
                settings.SettingMenuPressed();
            }
            else if (option == 1)
            {
                foreach (GameObject element in Foreground)
                {
                    element.SetActive(false);
                }
                backgroundMusic.Pause();
                settings.SettingMenuPressedGame();
            }
        }
    }
    public void UpdateSound(float vol)
    {
        float temp = vol / 100;
        backgroundMusic.volume = temp;
        UpdateMuteButton(backgroundMusic.volume);
    }
    public void UpdateMuteButton(float volume)
    {
        if (volume > 0)
        {
            var ss = muteButton.spriteState;
            muteButton.image.sprite = unmutedSprite[0];
            ss.disabledSprite = unmutedSprite[0];
            ss.highlightedSprite = unmutedSprite[1];
            ss.pressedSprite = unmutedSprite[2];

            muteButton.spriteState = ss;
        } 
        else if (volume == 0) 
        {
            var ss = muteButton.spriteState;
            muteButton.image.sprite = muteSprite[0];
            ss.disabledSprite = muteSprite[0];
            ss.highlightedSprite = muteSprite[1];
            ss.pressedSprite = muteSprite[2];

            muteButton.spriteState = ss;
        }

        EventSystem.current.SetSelectedGameObject(null);

    }
    public void UpdateSFXSound(float vol, string option)
    {
        if (option == "Load")
        {
            float temp = vol;
            for (int i = 0; i < SFX.Length; i++)
            {
                SFX[i].volume = temp;
            }
        }
        else if (option == "Update")
        {
            float temp = vol / 100;
            for (int i = 0; i < SFX.Length; i++)
            {
                SFX[i].volume = temp;
            }
        }
    }
    public void ButtonClickSFX()
    {
        SFX[0].Play();

        StartCoroutine(PlaySound(SFX[0]));
   
    }
    public void SliderMoveSFX()
    {
        SFX[1].Play();

    }
    IEnumerator PlaySound(AudioSource source)
    {
        while (source.isPlaying)
        {
            yield return null;
        }
    }
    public void PlayGoSFX()
    {
        SFX[2].Play();
    }
    public void PlaySwordSFX()
    {
        SFX[3].Play();
    }
    public void PlayPotionSFX()
    {
        SFX[4].Play();
    }

    public void SetBossBackgroubdMusic()
    {
        backgroundMusic = bossBackgroundMusic;
    }
    public void PlayGameBackgroundMusic(float volume)
    {
       backgroundMusic.volume = volume;
       backgroundMusic.Play();
    }
    public void StopGameBackgroundMusic()
    {
        backgroundMusic.Pause();
    }

    public void PlayButtonErrorSFX()
    {
        SFX[5].Play();
    }
    public void PlayGameOverSFX()
    {
        gameOverSound.volume = backgroundMusic.volume;
        gameOverSound.Play();       
    }  
}