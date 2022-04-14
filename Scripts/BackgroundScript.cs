using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundScript : MonoBehaviour
{
    public Sprite[] backgroundImages;
    public Sprite[] foregroundBackgroundImages;
    public Image backgroundImage;
    public Image foregroundBackgroundImage;
    public int backgroundNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        int ranBackground = Random.Range(0, 7);
        backgroundNumber = ranBackground;
        ChangeBackground(backgroundNumber);
        ChangeForegroundBackground(backgroundNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeBackground(int bgNumber)
    {
        backgroundImage.GetComponent<Image>().sprite = backgroundImages[bgNumber];
    }
    public void ChangeForegroundBackground(int bgNumber)
    {
        foregroundBackgroundImage.GetComponent<Image>().sprite = foregroundBackgroundImages[bgNumber];
        foregroundBackgroundImage.GetComponent<SpriteRenderer>().sortingOrder = 99999;
    }
}
