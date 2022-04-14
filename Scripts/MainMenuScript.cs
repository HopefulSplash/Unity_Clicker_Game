using System.Collections;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.EventSystems;

public class MainMenuScript : MonoBehaviour
{
    public static MainMenuScript control;
    public Player player;
    public AudioSource backgroundMusic;
    public KeepAudio keepAudio;
    public Settings settings;
    public Store store;
    public AnimalMenu animal;
    public GameObject MMShader;
    public GameObject moneyButton;
    public Quest quest;
    public LevelMenu level;
    public static bool firstLoad;
    public GameObject trans;
    private void Awake()

    {
        if (firstLoad == true)
        {
            trans.gameObject.SetActive(false);
        }
        else
        {
            StartCoroutine(WaitForFade(0.7f));

        }
     
        control = this;
        GameObject temp = GameObject.FindGameObjectWithTag("MMShade");
        MMShader = temp;
        temp.SetActive(false);
        GameObject mB = GameObject.FindGameObjectWithTag("MoneyButton");
        mB.SetActive(false);
        SaveSystem.checkIfSystemFile();
        player.LoadPlayer();
        player.playerHearts = player.playerHearts + 2;
        backgroundMusic.volume = player.backgroundMusicLevelSettings;
        keepAudio.UpdateSFXSound(player.SFXMusicLevelSettings, "Load");
        keepAudio.UpdateMuteButton(backgroundMusic.volume);
        store.UpdateStoreMenu();
        animal.UpdateAnimalMenu();
        quest.UpdateQuestMenu();
        settings.UpdateSettingsMenu();
        level.UpdateLevelMenu();
        settings.tempMusicVol = player.backgroundMusicLevelSettings;
        settings.tempSFXvol = player.SFXMusicLevelSettings;

 

    }
    IEnumerator WaitForFade(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        keepAudio.PlayBGMusic();
    }
    
    public void ShaderON()
    {
        MMShader.SetActive(true);
    }
    public void ShaderOff()
    {
        MMShader.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
