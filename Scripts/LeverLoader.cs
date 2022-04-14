using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeverLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public static bool doItNow;
    public static int levelToLoad;
    public static LeverLoader instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }
    // Update is called once per frame
    void Update()
    {   
    }

    public void LoadNextLevel()
    {

        StartCoroutine(LoadLevel(levelToLoad));       
    }
    public static bool isLoaded = false;
    IEnumerator LoadLevel(int levelIndex)
    {


        transition.SetTrigger("StartFade");
        yield return new WaitForSeconds(0);

        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        if (!isLoaded)
        {
            SceneManager.LoadScene(levelIndex);
            isLoaded = true;
        }
        StartCoroutine(LoadLevelEnd(levelIndex));
        


    }
     IEnumerator LoadLevelEnd(int levelIndex)
    {


        transition.SetTrigger("EndFade");
        yield return new WaitForSeconds(transitionTime);
        yield return new WaitForSeconds(1f);
    }
}
