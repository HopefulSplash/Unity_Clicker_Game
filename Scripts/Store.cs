using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    public UnityAdManager adManager;
    public IAPManager iAPManager;
    public Text coinText;
    public Text gemText;
    public Text attackText;
    public Text heartText;
    public Text potionText;
    public MainMenuScript mainMenuScript;
    public Player player;
    public GameObject moneyButton;
    private GameObject[] gameObjectArray;
    private List<GameObject> gameObjectButtons;
    private GameObject[] currencyGameObj;
    private GameObject[] itemGameObj;
    private GameObject[] priceGameObj;
    public GameObject storeMenu;
    public GameObject StoreMenuConfirm;
    public GameObject SMShader;

    public Button leftButton;
    public Button rightButton;

    public int pageNo;

    public Sprite coinCurrency;
    public Sprite[] coinItemList;
    public int[] coinPriceList;

    public Sprite gemCurrency;
    public Sprite[] gemItemList;
    public int[] gemPriceList;

    public Sprite moneyCurrency;
    public Sprite[] moneyItemList;
    public float[] moneyPriceList;

    public Sprite adCurrency;
    public Sprite[] adItemList;
    public string[] adPriceList;

    public Button cButton;
    public Button gButton;
    public Button mButton;
    public Button aButton;
    public Sprite selectButtons;
    public Sprite delectedButtons;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 

    public void SetButtonInactive(Button button)
    {
       
        var buttonTransform = button.transform;
        Image img = buttonTransform.GetChild(0).GetComponent<Image>();

        button.GetComponent<Button>().image.sprite = delectedButtons;
        button.interactable = true;

        Image temp = button.GetComponent<Image>();

        temp.color = new Color32(255, 255, 255, 150);
        img.color = new Color32(255, 255, 255, 150);
    }

    public void SetButtonActive(Button button)
    {
        var buttonTransform = button.transform;
        Image img = buttonTransform.GetChild(0).GetComponent<Image>();

        button.GetComponent<Button>().image.sprite = selectButtons;
        button.interactable = false;

        Image temp = button.GetComponent<Image>();

        temp.color = new Color32(255, 255, 255, 255);
        img.color = new Color32(255, 255, 255, 255);
    }
    public void LoadStoreSettings()
    {
        gameObjectArray = GameObject.FindGameObjectsWithTag("MainMenuUI");
        OnAndOffButton(gameObjectArray);
        StoreMenuConfirm.SetActive(false);
        rightButton.gameObject.SetActive(true);
        leftButton.gameObject.SetActive(false);

        GameObject temp = GameObject.FindGameObjectWithTag("CoinStore");
        cButton = temp.GetComponent<Button>();
        GameObject temp1 = GameObject.FindGameObjectWithTag("GemStore");
        gButton = temp1.GetComponent<Button>();
        GameObject temp2 = GameObject.FindGameObjectWithTag("MoneyStore");
        mButton = temp2.GetComponent<Button>();
        GameObject temp3 = GameObject.FindGameObjectWithTag("AdStore");
        aButton = temp3.GetComponent<Button>();

        SetActiveStore(1);
        PageSetup(coinCurrency);

    }

    public void itemButtonPressed(int itemPressed)
    {
        SMShader.SetActive(true);
        GameObject[] tempArray = GameObject.FindGameObjectsWithTag("BuyButton");
        gameObjectButtons = tempArray.Cast<GameObject>().ToList();

        GameObject temp4 = GameObject.FindGameObjectWithTag("BuyButton3");
        gameObjectButtons.Add(temp4);
        GameObject temp = GameObject.FindGameObjectWithTag("CoinStore");
        gameObjectButtons.Add(temp);
        GameObject temp1 = GameObject.FindGameObjectWithTag("GemStore");
        gameObjectButtons.Add(temp1);
        GameObject temp2 = GameObject.FindGameObjectWithTag("MoneyStore");
        gameObjectButtons.Add(temp2);
        GameObject temp3 = GameObject.FindGameObjectWithTag("AdStore");
        gameObjectButtons.Add(temp3);

        OnAndOffButton(gameObjectButtons.ToArray());
        
        

        StoreMenuConfirm.SetActive(true);
        GetItemDetails(itemPressed);
        CheckCredits();
        CheckRestored(restored);
    }
    public string restored = "No";
    public void CheckRestored(string option)
    {
        if (option == "Restored")
        {
            GameObject tempA = GameObject.FindGameObjectWithTag("AcceptButton");
            Button button = tempA.GetComponent<Button>();
            button.interactable = false;
            Image temp1 = button.GetComponent<Image>();

            temp1.color = new Color32(255, 255, 255, 150);
        }
        else
        {

        }
        restored = "No";
    }
    public bool hasCredits;
    
    public void AcceptButtonPressed()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<Player>();
        player.LoadPlayer();
        purchase = false;

        if (hasCredits)
        {
            if (currencyGameObj[0].GetComponent<Image>().sprite.name == "Coin")
            {
               if (confirmItemObj.GetComponent<Image>().sprite.name == "Sword 1")
                {
                    player.playerCoins= player.playerCoins - coinPriceList[0];
                    player.playerAttack = player.playerAttack + 1;
                }
               else if (confirmItemObj.GetComponent<Image>().sprite.name == "Sword 5")
                {
                    player.playerCoins = player.playerCoins - coinPriceList[1];
                    player.playerAttack = player.playerAttack + 5;
                }
               else if (confirmItemObj.GetComponent<Image>().sprite.name == "Sword 10")
                {
                    player.playerCoins = player.playerCoins - coinPriceList[2];
                    player.playerAttack = player.playerAttack + 10;
                }
               else if (confirmItemObj.GetComponent<Image>().sprite.name == "Potions 1")
                {
                    player.playerCoins = player.playerCoins - coinPriceList[3];
                    player.playerPotions = player.playerPotions + 1;
                }
                else if(confirmItemObj.GetComponent<Image>().sprite.name == "Potions 5")
                {
                    player.playerCoins = player.playerCoins - coinPriceList[4];
                    player.playerPotions = player.playerPotions + 5;
                }
               else if (confirmItemObj.GetComponent<Image>().sprite.name == "Potions 10")
                {
                    player.playerCoins = player.playerCoins - coinPriceList[5];
                    player.playerPotions = player.playerPotions + 10;
                }
               else if (confirmItemObj.GetComponent<Image>().sprite.name == "Heart 1")
                {
                    player.playerCoins = player.playerCoins - coinPriceList[6];
                    player.playerHearts = player.playerHearts + 1;
                }
               else if (confirmItemObj.GetComponent<Image>().sprite.name == "Heart 5")
                {
                    player.playerCoins = player.playerCoins - coinPriceList[7];
                    player.playerHearts = player.playerHearts + 5;
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Heart 10")
                {
                    player.playerCoins = player.playerCoins - coinPriceList[8];
                    player.playerHearts = player.playerHearts + 10;
                }
            }
            else if (currencyGameObj[0].GetComponent<Image>().sprite.name == "Gem")
            {
                if (confirmItemObj.GetComponent<Image>().sprite.name == "Sword 1")
                {
                    player.playerGems = player.playerGems - gemPriceList[0];
                    player.playerAttack = player.playerAttack + 1;
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Sword 5")
                {
                    player.playerGems = player.playerGems - gemPriceList[1];
                    player.playerAttack = player.playerAttack + 5;
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Sword 10")
                {
                    player.playerGems = player.playerGems - gemPriceList[2];
                    player.playerAttack = player.playerAttack + 10;
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Potions 1")
                {
                    player.playerGems = player.playerGems - gemPriceList[3];
                    player.playerPotions = player.playerPotions + 1;
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Potions 5")
                {
                    player.playerGems = player.playerGems - gemPriceList[4];
                    player.playerPotions = player.playerPotions + 5;
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Potions 10")
                {
                    player.playerGems = player.playerGems - gemPriceList[5];
                    player.playerPotions = player.playerPotions + 10;
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Heart 1")
                {
                    player.playerGems = player.playerGems - gemPriceList[6];
                    player.playerHearts = player.playerHearts + 1;
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Heart 5")
                {
                    player.playerGems = player.playerGems - gemPriceList[7];
                    player.playerHearts = player.playerHearts + 5;
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Heart 10")
                {
                    player.playerGems = player.playerGems - gemPriceList[8];
                    player.playerHearts = player.playerHearts + 10;
                }
            }
            else if (currencyGameObj[0].GetComponent<Image>().sprite.name == "Money")
            {
                if (confirmItemObj.GetComponent<Image>().sprite.name == "Coin 1000")
                {
                    purchase = true;

                    ClickBuy("Coin 1000");
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Coin 5000")
                {
                    purchase = true;

                    ClickBuy("Coin 5000");
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Coin 10000")
                {
                    purchase = true;

                    ClickBuy("Coin 10000");
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Gem 1000")
                {
                    purchase = true;

                    ClickBuy("Gem 1000");
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Gem 5000")
                {
                    purchase = true;

                    ClickBuy("Gem 5000");
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Gem 10000")
                {
                    purchase = true;

                    ClickBuy("Gem 10000");
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Heart 1000")
                {
                    purchase = true;

                    ClickBuy("Heart 1000");
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Heart 5000")
                {
                    purchase = true;

                    ClickBuy("Heart 5000");
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Heart 10000")
                {
                    purchase = true;

                    ClickBuy("Heart 10000");
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "NoAds Basic")
                {
                    purchase = true;

                    ClickBuy("NoAds Basic");
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "NoAds Premium")
                {
                    purchase = true;

                    ClickBuy("NoAds Premium");
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "NoAds Excel")
                {
                    purchase = true;

                    ClickBuy("NoAds Excel");
                }
            }
            else if (currencyGameObj[0].GetComponent<Image>().sprite.name == "AD")
            {
                GameObject tempAd = GameObject.FindGameObjectWithTag("AdManager");
                adManager = tempAd.GetComponent<UnityAdManager>();

                if (confirmItemObj.GetComponent<Image>().sprite.name == "Coin Ad")
                {
                    typeReward = "Coin";
                    amountReward = 500;
                    adManager.PlayRewardedAD(addReward);
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Gem Ad")
                {
                    typeReward = "Gem";
                    amountReward = 5;
                    adManager.PlayRewardedAD(addReward);
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Heart Ad")
                {
                    typeReward = "Heart";
                    amountReward = 2;
                    adManager.PlayRewardedAD(addReward);
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Potions Ad")
                {
                    typeReward = "Potion";
                    amountReward = 2;
                    adManager.PlayRewardedAD(addReward);
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Sword 5")
                {
                    typeReward = "Sword";
                    amountReward = 5;
                    adManager.PlayRewardedAD(addReward);
                }
                else if (confirmItemObj.GetComponent<Image>().sprite.name == "Gift")
                {
                    typeReward = "Gift";
                    amountReward = 10;
                    adManager.PlayRewardedAD(addReward);
                }
            }
            if (purchase == false)
            {
                CloseConfirm();

                GameObject temp1 = GameObject.FindGameObjectWithTag("playerCoins");
                coinText = temp1.GetComponent<Text>();
                coinText.text = player.playerCoins.ToString();
                GameObject temp2 = GameObject.FindGameObjectWithTag("playerGems");
                gemText = temp2.GetComponent<Text>();
                gemText.text = player.playerGems.ToString();
                GameObject temp5 = GameObject.FindGameObjectWithTag("playerAttack");
                attackText = temp5.GetComponent<Text>();
                attackText.text = player.playerAttack.ToString();
                GameObject temp3 = GameObject.FindGameObjectWithTag("playerHearts");
                heartText = temp3.GetComponent<Text>();
                heartText.text = player.playerHearts.ToString();
                GameObject temp4 = GameObject.FindGameObjectWithTag("playerPotions");
                potionText = temp4.GetComponent<Text>();
                potionText.text = player.playerPotions.ToString();
                SaveSystem.SavePlayer(player);
            }
        }
       else
        {
            //no nothing as button is not active
        }

    }
    public bool purchase;
    public void ClickBuy(string option)
    {
        iAPManager.BuyProduct(option);
    }
    public void BuyMenuClosed()
    {
        CloseConfirm();

        GameObject temp1 = GameObject.FindGameObjectWithTag("playerCoins");
        coinText = temp1.GetComponent<Text>();
        coinText.text = player.playerCoins.ToString();
        GameObject temp2 = GameObject.FindGameObjectWithTag("playerGems");
        gemText = temp2.GetComponent<Text>();
        gemText.text = player.playerGems.ToString();
        GameObject temp5 = GameObject.FindGameObjectWithTag("playerAttack");
        attackText = temp5.GetComponent<Text>();
        attackText.text = player.playerAttack.ToString();
        GameObject temp3 = GameObject.FindGameObjectWithTag("playerHearts");
        heartText = temp3.GetComponent<Text>();
        heartText.text = player.playerHearts.ToString();
        GameObject temp4 = GameObject.FindGameObjectWithTag("playerPotions");
        potionText = temp4.GetComponent<Text>();
        potionText.text = player.playerPotions.ToString();
    }
    private int amountReward;
    private string typeReward;
    public void addReward()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<Player>();
        player.LoadPlayer();

        if (typeReward == "Coin")
        {
            player.playerCoins = player.playerCoins + amountReward;
        }
      else if (typeReward == "Gem")
        {
            player.playerGems = player.playerGems + amountReward;
        }
      else if (typeReward == "Heart")
        {
            player.playerHearts = player.playerHearts + amountReward;

        }
        else if (typeReward == "Potion")
        {
            player.playerPotions = player.playerPotions + amountReward;

        }
        else if (typeReward == "Sword")
        {
            player.playerAttack = player.playerAttack + amountReward;

        }
        else if (typeReward == "Gift")
        {
            int tempRand = GetRandom();
            switch (tempRand)
            {
                case 1:
                    player.playerCoins = player.playerCoins + 1000;
                
                    break;
                case 2:
                    player.playerGems = player.playerGems + 10;
                    break;
                case 3:
                    player.playerHearts = player.playerHearts + 4;
                    break;
                case 4:
                    player.playerPotions = player.playerPotions + 4;
                    break;
                case 5:
                    player.playerAttack = player.playerAttack + 10;
                    break;
                default:
                    break;
            }
        }

       
        player.SavePlayer();

        GameObject temp1 = GameObject.FindGameObjectWithTag("playerCoins");
        coinText = temp1.GetComponent<Text>();
        coinText.text = player.playerCoins.ToString();
        GameObject temp2 = GameObject.FindGameObjectWithTag("playerGems");
        gemText = temp2.GetComponent<Text>();
        gemText.text = player.playerGems.ToString();
        GameObject temp5 = GameObject.FindGameObjectWithTag("playerAttack");
        attackText = temp5.GetComponent<Text>();
        attackText.text = player.playerAttack.ToString();
        GameObject temp3 = GameObject.FindGameObjectWithTag("playerHearts");
        heartText = temp3.GetComponent<Text>();
        heartText.text = player.playerHearts.ToString();
        GameObject temp4 = GameObject.FindGameObjectWithTag("playerPotions");
        potionText = temp4.GetComponent<Text>();
        potionText.text = player.playerPotions.ToString();
    }
    public int GetRandom()
    {
        int giftReward = Random.Range(1, 5);

        return giftReward;
    }
    public void CheckCredits()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<Player>();
        player.LoadPlayer();

        

        //check if player has enough credits
        if (currencyGameObj[0].GetComponent<Image>().sprite.name == "Coin")
        {
            confirmPriceObj = GameObject.FindGameObjectWithTag("ConfirmPrice");
            int tempInt = int.Parse(confirmPriceObj.GetComponent<Text>().text);

            if (player.playerCoins >= tempInt)
            { 
                GameObject tempA = GameObject.FindGameObjectWithTag("AcceptButton");
                Button button =tempA.GetComponent<Button>();
                button.interactable = true;
                Image temp2 = button.GetComponent<Image>();

                temp2.color = new Color32(255, 255, 255, 255);
                hasCredits = true;
            }
            else
            {
                GameObject tempA = GameObject.FindGameObjectWithTag("AcceptButton");
                Button button = tempA.GetComponent<Button>();
                button.interactable = false;
                Image temp1 = button.GetComponent<Image>();

                temp1.color = new Color32(255, 255, 255, 150);
                hasCredits = false;
            }

        }
        else if (currencyGameObj[0].GetComponent<Image>().sprite.name == "Gem")
        {
            confirmPriceObj = GameObject.FindGameObjectWithTag("ConfirmPrice");
            int tempInt = int.Parse(confirmPriceObj.GetComponent<Text>().text);

            if (player.playerGems >= tempInt)
            {
                GameObject tempA = GameObject.FindGameObjectWithTag("AcceptButton");
                Button button = tempA.GetComponent<Button>();
                button.interactable = true;
                Image temp2 = button.GetComponent<Image>();

                temp2.color = new Color32(255, 255, 255, 255);
                hasCredits = true;
            }
            else
            {
                GameObject tempA = GameObject.FindGameObjectWithTag("AcceptButton");
                Button button = tempA.GetComponent<Button>();
                button.interactable = false;
                Image temp1 = button.GetComponent<Image>();

                temp1.color = new Color32(255, 255, 255, 150);
                hasCredits = false;
            }
        }
        else if (currencyGameObj[0].GetComponent<Image>().sprite.name == "Money")
        {
            GameObject tempA = GameObject.FindGameObjectWithTag("AcceptButton");
            Button button = tempA.GetComponent<Button>();
            button.interactable = true;
            Image temp2 = button.GetComponent<Image>();

            temp2.color = new Color32(255, 255, 255, 255);
            hasCredits = true;
        }
        else if (currencyGameObj[0].GetComponent<Image>().sprite.name == "AD")
        {
            GameObject tempA = GameObject.FindGameObjectWithTag("AcceptButton");
            Button button = tempA.GetComponent<Button>();
            button.interactable = true;
            Image temp2 = button.GetComponent<Image>();

            temp2.color = new Color32(255, 255, 255, 255);
            hasCredits = true;
        }
    }
    public void CloseConfirm()
    {
        GameObject[] tempArray = GameObject.FindGameObjectsWithTag("BuyButton");
        gameObjectButtons = tempArray.Cast<GameObject>().ToList();

        GameObject temp4 = GameObject.FindGameObjectWithTag("BuyButton3");
        gameObjectButtons.Add(temp4);
        GameObject tempMB = GameObject.FindGameObjectWithTag("MoneyButton");
        moneyButton.SetActive(false);
        GameObject temp = GameObject.FindGameObjectWithTag("CoinStore");
        gameObjectButtons.Add(temp);
        GameObject temp1 = GameObject.FindGameObjectWithTag("GemStore");
        gameObjectButtons.Add(temp1);
        GameObject temp2 = GameObject.FindGameObjectWithTag("MoneyStore");
        gameObjectButtons.Add(temp2);
        GameObject temp3 = GameObject.FindGameObjectWithTag("AdStore");
        gameObjectButtons.Add(temp3);

        OnAndOffButton(gameObjectButtons.ToArray());
        StoreMenuConfirm.SetActive(false);
        SMShader.SetActive(false);

    }
    public GameObject confirmItemObj;
    public GameObject confirmPriceObj;
    public GameObject confirmDescObj;
    public GameObject confirmCurrencyObj;
    public void GetItemDetails(int itemNo)
    {
        currencyGameObj = GameObject.FindGameObjectsWithTag("Currency");
        confirmItemObj = GameObject.FindGameObjectWithTag("ConfirmItem");
        confirmPriceObj = GameObject.FindGameObjectWithTag("ConfirmPrice");
        confirmCurrencyObj = GameObject.FindGameObjectWithTag("ConfirmCurrency");
        confirmDescObj = GameObject.FindGameObjectWithTag("ConfirmDesc");
        confirmDescObj.GetComponent<Text>().fontSize = 45;

        if (currencyGameObj[0].GetComponent<Image>().sprite.name == "Coin")
        {
            confirmCurrencyObj.GetComponent<Image>().sprite = coinCurrency;
            if (pageNo == 1)
            {
                if (itemNo == 1)
                {
                    confirmItemObj.GetComponent<Image>().sprite = coinItemList[0];
                    confirmPriceObj.GetComponent<Text>().text = coinPriceList[0].ToString();
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Purchase This Item?";
                }
                else if (itemNo == 2)
                {
                    confirmItemObj.GetComponent<Image>().sprite = coinItemList[1];
                    confirmPriceObj.GetComponent<Text>().text = coinPriceList[1].ToString();
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Purchase This Item?";
                }
                else if (itemNo == 3)
                {
                    confirmItemObj.GetComponent<Image>().sprite = coinItemList[2];
                    confirmPriceObj.GetComponent<Text>().text = coinPriceList[2].ToString();
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Purchase This Item?";
                }
            }
            else if (pageNo == 2)
            {
                if (itemNo == 1)
                {
                    confirmItemObj.GetComponent<Image>().sprite = coinItemList[3];
                    confirmPriceObj.GetComponent<Text>().text = coinPriceList[3].ToString();
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Purchase This Item?";
                }
                else if (itemNo == 2)
                {
                    confirmItemObj.GetComponent<Image>().sprite = coinItemList[4];
                    confirmPriceObj.GetComponent<Text>().text = coinPriceList[4].ToString();
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Purchase This Item?";
                }
                else if (itemNo == 3)
                {
                    confirmItemObj.GetComponent<Image>().sprite = coinItemList[5];
                    confirmPriceObj.GetComponent<Text>().text = coinPriceList[5].ToString();
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Purchase This Item?";
                }
            }
            else if (pageNo == 3)
            {
                if (itemNo == 1)
                {
                    confirmItemObj.GetComponent<Image>().sprite = coinItemList[6];
                    confirmPriceObj.GetComponent<Text>().text = coinPriceList[6].ToString();
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Purchase This Item?";
                }
                else if (itemNo == 2)
                {
                    confirmItemObj.GetComponent<Image>().sprite = coinItemList[7];
                    confirmPriceObj.GetComponent<Text>().text = coinPriceList[7].ToString();
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Purchase This Item?";
                }
                else if (itemNo == 3)
                {
                    confirmItemObj.GetComponent<Image>().sprite = coinItemList[8];
                    confirmPriceObj.GetComponent<Text>().text = coinPriceList[8].ToString();
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Purchase This Item?";
                }
            }
        }
        else if (currencyGameObj[0].GetComponent<Image>().sprite.name == "Gem")
        {
            confirmCurrencyObj.GetComponent<Image>().sprite = gemCurrency;
            if (pageNo == 1)
            {
                if (itemNo == 1)
                {
                    confirmItemObj.GetComponent<Image>().sprite = gemItemList[0];
                    confirmPriceObj.GetComponent<Text>().text = gemPriceList[0].ToString();
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Purchase This Item?";
                }
                else if (itemNo == 2)
                {
                    confirmItemObj.GetComponent<Image>().sprite = gemItemList[1];
                    confirmPriceObj.GetComponent<Text>().text = gemPriceList[1].ToString();
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Purchase This Item?";
                }
                else if (itemNo == 3)
                {
                    confirmItemObj.GetComponent<Image>().sprite = gemItemList[2];
                    confirmPriceObj.GetComponent<Text>().text = gemPriceList[2].ToString();
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Purchase This Item?";
                }
            }
            else if (pageNo == 2)
            {
                if (itemNo == 1)
                {
                    confirmItemObj.GetComponent<Image>().sprite = gemItemList[3];
                    confirmPriceObj.GetComponent<Text>().text = gemPriceList[3].ToString();
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Purchase This Item?";
                }
                else if (itemNo == 2)
                {
                    confirmItemObj.GetComponent<Image>().sprite = gemItemList[4];
                    confirmPriceObj.GetComponent<Text>().text = gemPriceList[4].ToString();
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Purchase This Item?";
                }
                else if (itemNo == 3)
                {
                    confirmItemObj.GetComponent<Image>().sprite = gemItemList[5];
                    confirmPriceObj.GetComponent<Text>().text = gemPriceList[5].ToString();
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Purchase This Item?";
                }
            }
            else if (pageNo == 3)
            {
                if (itemNo == 1)
                {
                    confirmItemObj.GetComponent<Image>().sprite = gemItemList[6];
                    confirmPriceObj.GetComponent<Text>().text = gemPriceList[6].ToString();
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Purchase This Item?";
                }
                else if (itemNo == 2)
                {
                    confirmItemObj.GetComponent<Image>().sprite = gemItemList[7];
                    confirmPriceObj.GetComponent<Text>().text = gemPriceList[7].ToString();
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Purchase This Item?";
                }
                else if (itemNo == 3)
                {
                    confirmItemObj.GetComponent<Image>().sprite = gemItemList[8];
                    confirmPriceObj.GetComponent<Text>().text = gemPriceList[8].ToString();
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Purchase This Item?";
                }
            }
        }
        else if (currencyGameObj[0].GetComponent<Image>().sprite.name == "Money")
        {
            GameObject tempMB = GameObject.FindGameObjectWithTag("MoneyButton");
        moneyButton.SetActive(true);
            confirmCurrencyObj.GetComponent<Image>().sprite = moneyCurrency;
            if (pageNo == 1)
            {
                if (itemNo == 1)
                {
                    confirmItemObj.GetComponent<Image>().sprite = moneyItemList[0];
                    confirmPriceObj.GetComponent<Text>().text = "$" + moneyPriceList[0].ToString();
                    confirmDescObj.GetComponent<Text>().text = "REAL MONEY Purchase. Are You Sure?";
                }
                else if (itemNo == 2)
                {
                    confirmItemObj.GetComponent<Image>().sprite = moneyItemList[1];
                    confirmPriceObj.GetComponent<Text>().text = "$" + moneyPriceList[1].ToString();
                    confirmDescObj.GetComponent<Text>().text = "REAL MONEY Purchase. Are You Sure?";
                }
                else if (itemNo == 3)
                {
                    confirmItemObj.GetComponent<Image>().sprite = moneyItemList[2];
                    confirmPriceObj.GetComponent<Text>().text = "$" + moneyPriceList[2].ToString();
                    confirmDescObj.GetComponent<Text>().text = "REAL MONEY Purchase. Are You Sure?";
                }
            }
            else if (pageNo == 2)
            {
                if (itemNo == 1)
                {
                    confirmItemObj.GetComponent<Image>().sprite = moneyItemList[3];
                    confirmPriceObj.GetComponent<Text>().text = "$" + moneyPriceList[3].ToString();
                    confirmDescObj.GetComponent<Text>().text = "REAL MONEY Purchase. Are You Sure?";
                }
                else if (itemNo == 2)
                {
                    confirmItemObj.GetComponent<Image>().sprite = moneyItemList[4];
                    confirmPriceObj.GetComponent<Text>().text = "$" + moneyPriceList[4].ToString();
                    confirmDescObj.GetComponent<Text>().text = "REAL MONEY Purchase. Are You Sure?";
                }
                else if (itemNo == 3)
                {
                    confirmItemObj.GetComponent<Image>().sprite = moneyItemList[5];
                    confirmPriceObj.GetComponent<Text>().text = "$" + moneyPriceList[5].ToString();
                    confirmDescObj.GetComponent<Text>().text = "REAL MONEY Purchase. Are You Sure?";
                }
            }
            else if (pageNo == 3)
            {
                if (itemNo == 1)
                {
                    confirmItemObj.GetComponent<Image>().sprite = moneyItemList[6];
                    confirmPriceObj.GetComponent<Text>().text = "$" + moneyPriceList[6].ToString();
                    confirmDescObj.GetComponent<Text>().text = "REAL MONEY Purchase. Are You Sure?";
                }
                else if (itemNo == 2)
                {
                    confirmItemObj.GetComponent<Image>().sprite = moneyItemList[7];
                    confirmPriceObj.GetComponent<Text>().text = "$" + moneyPriceList[7].ToString();
                    confirmDescObj.GetComponent<Text>().text = "REAL MONEY Purchase. Are You Sure?";
                }
                else if (itemNo == 3)
                {
                    confirmItemObj.GetComponent<Image>().sprite = moneyItemList[8];
                    confirmPriceObj.GetComponent<Text>().text = "$" + moneyPriceList[8].ToString();
                    confirmDescObj.GetComponent<Text>().text = "REAL MONEY Purchase. Are You Sure?";
                }
            }
            else if (pageNo == 4)
            {
                if (itemNo == 1)
                {
                    confirmItemObj.GetComponent<Image>().sprite = moneyItemList[9];
                    confirmPriceObj.GetComponent<Text>().text = "$" + moneyPriceList[9].ToString();
                    confirmDescObj.GetComponent<Text>().text = "REAL MONEY Purchase. Are You Sure?";
                }
                else if (itemNo == 2)
                {
                    confirmItemObj.GetComponent<Image>().sprite = moneyItemList[10];
                    confirmPriceObj.GetComponent<Text>().text = "$" + moneyPriceList[10].ToString();
                    confirmDescObj.GetComponent<Text>().text = "REAL MONEY Purchase. Are You Sure?";
                }
                else if (itemNo == 3)
                {
                    GameObject temp = GameObject.FindGameObjectWithTag("Player");
                    player = temp.GetComponent<Player>();
                    player.LoadPlayer();
                    moneyButton.SetActive(false);
                    bool tempBool =player.playerRestore;
                    if (tempBool == true)
                    {
                        confirmItemObj.GetComponent<Image>().sprite = moneyItemList[11];
                        confirmPriceObj.GetComponent<Text>().text = "FREE";
                        confirmDescObj.GetComponent<Text>().fontSize = 35;
                        confirmDescObj.GetComponent<Text>().text = "One Time Restore Of Purchases (For Non Google Play Account), DO NOT DELETE APP. Are You Sure?";
                    }
                    else
                    {
                        restored = "Restored";
                        confirmItemObj.GetComponent<Image>().sprite = moneyItemList[11];
                        confirmPriceObj.GetComponent<Text>().text = "NA";
                        confirmDescObj.GetComponent<Text>().fontSize = 45;
                        confirmDescObj.GetComponent<Text>().text = "You Cannot Restore Purchases";
                    }
                }
            }
        }
        else if (currencyGameObj[0].GetComponent<Image>().sprite.name == "AD")
        {
            confirmCurrencyObj.GetComponent<Image>().sprite = adCurrency;
            if (pageNo == 1)
            {
                if (itemNo == 1)
                {
                    confirmItemObj.GetComponent<Image>().sprite = adItemList[0];
                    confirmPriceObj.GetComponent<Text>().text = "Watch";
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Watch The AD?";

                }
                else if (itemNo == 2)
                {
                    confirmItemObj.GetComponent<Image>().sprite = adItemList[1];
                    confirmPriceObj.GetComponent<Text>().text = "Watch";
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Watch The AD?";
                }
                else if (itemNo == 3)
                {
                    confirmItemObj.GetComponent<Image>().sprite = adItemList[2];
                    confirmPriceObj.GetComponent<Text>().text = "Watch";
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Watch The AD?";
                }
            }
            else if (pageNo == 2)
            {
                if (itemNo == 1)
                {
                    confirmItemObj.GetComponent<Image>().sprite = adItemList[3];
                    confirmPriceObj.GetComponent<Text>().text = "Watch"; 
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Watch The AD?";
                }
                else if (itemNo == 2)
                {
                    confirmItemObj.GetComponent<Image>().sprite = adItemList[4];
                    confirmPriceObj.GetComponent<Text>().text = "Watch";
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Watch The AD?";
                }
                else if (itemNo == 3)
                {
                    confirmItemObj.GetComponent<Image>().sprite = adItemList[5];
                    confirmPriceObj.GetComponent<Text>().text = "Watch";
                    confirmDescObj.GetComponent<Text>().text = "Are You Sure You Want To Watch The AD?";
                }
            }
        }
    }
    public void StoreButtonPressed(int shopNo)
    {
        
           SetActiveStore(shopNo);
    }
    public void SetActiveStore(int storeNo)
    {
        activeStore = storeNo;
        if (storeNo == 1)
        {
            SetButtonActive(cButton);
            SetButtonInactive(gButton);
            SetButtonInactive(mButton);
            SetButtonInactive(aButton);
        }
        else if (storeNo == 2)
        {
            SetButtonActive(gButton);
            SetButtonInactive(cButton);
            SetButtonInactive(mButton);
            SetButtonInactive(aButton);
        }
        else if (storeNo == 3)
        {
            SetButtonActive(mButton);
            SetButtonInactive(cButton);
            SetButtonInactive(gButton);
            SetButtonInactive(aButton);
        }
        else if (storeNo == 4)
        {
            SetButtonActive(aButton);
            SetButtonInactive(cButton);
            SetButtonInactive(mButton);
            SetButtonInactive(gButton);
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
    public void StoreMenuPressed()
    {
        SMShader.SetActive(false);
        mainMenuScript.ShaderON();
        pageNo = 1;
        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<Player>();
        player.LoadPlayer();

        storeMenu.gameObject.SetActive(true);

        GameObject temp1 = GameObject.FindGameObjectWithTag("playerCoins");
        coinText = temp1.GetComponent<Text>();
        coinText.text = player.playerCoins.ToString();
        GameObject temp2 = GameObject.FindGameObjectWithTag("playerGems");
        gemText = temp2.GetComponent<Text>();
        gemText.text = player.playerGems.ToString();
        GameObject temp5 = GameObject.FindGameObjectWithTag("playerAttack");
        attackText = temp5.GetComponent<Text>();
        attackText.text = player.playerAttack.ToString();
        GameObject temp3 = GameObject.FindGameObjectWithTag("playerHearts");
        heartText = temp3.GetComponent<Text>();
        heartText.text = player.playerHearts.ToString();
        GameObject temp4 = GameObject.FindGameObjectWithTag("playerPotions");
        potionText = temp4.GetComponent<Text>();
        potionText.text = player.playerPotions.ToString();
        LoadStoreSettings();


    }
    public void UpdateStoreMenu()
    {
        storeMenu.gameObject.SetActive(false);
    }


    public void CloseStoreMenu(string option)
    {

        gameObjectArray = GameObject.FindGameObjectsWithTag("MainMenuUI");
        OnAndOffButton(gameObjectArray);
        mainMenuScript.ShaderOff();
        storeMenu.gameObject.SetActive(false);

 

    }
    public void SetPageNo(int pageNo)
    {
        this.pageNo = pageNo;
        leftButton.gameObject.SetActive(false);
        rightButton.gameObject.SetActive(true);
    }

    public void PageSetup(Sprite currency)
    {
        int startingNo = 0;
        if (pageNo == 1)
        {
            startingNo = 0;
        }
        else if (pageNo == 2)
        {
            startingNo = 3;
        }
        else if (pageNo == 3)
        {
            startingNo = 6;
        }
        else if (pageNo == 4)
        {
            startingNo = 9;
        }

        currencyGameObj = GameObject.FindGameObjectsWithTag("Currency");
        itemGameObj = GameObject.FindGameObjectsWithTag("Item");
        priceGameObj = GameObject.FindGameObjectsWithTag("Price");

        if (currency.name == "Coin")
        {
            for (int i = 0; i < currencyGameObj.Length; i++)
            {
                currencyGameObj[i].GetComponent<Image>().sprite = coinCurrency;
            }
            for (int i = 0; i < itemGameObj.Length; i++)
            {
                    itemGameObj[i].GetComponent<Image>().sprite = coinItemList[startingNo];
                startingNo++;
               
            }
            if (pageNo == 1)
            {
                startingNo = 0;
            }
            else if (pageNo == 2)
            {
                startingNo = 3;
            }
            else if (pageNo == 3)
            {
                startingNo = 6;
            }
            else if (pageNo == 4)
            {
                startingNo = 9;
            }

            for (int i = 0; i < priceGameObj.Length; i++)
            {
                priceGameObj[i].GetComponent<Text>().text = coinPriceList[startingNo].ToString();
                startingNo++;
            }
        }
        else if (currency.name == "Gem")
        {
            for (int i = 0; i < currencyGameObj.Length; i++)
            {
                currencyGameObj[i].GetComponent<Image>().sprite = gemCurrency;
            }
            for (int i = 0; i < itemGameObj.Length; i++)
            {
                itemGameObj[i].GetComponent<Image>().sprite = gemItemList[startingNo];
                startingNo++;
            }
            if (pageNo == 1)
            {
                startingNo = 0;
            }
            else if (pageNo == 2)
            {
                startingNo = 3;
            }
            else if (pageNo == 3)
            {
                startingNo = 6;
            }
            else if (pageNo == 4)
            {
                startingNo = 9;
            }
            for (int i = 0; i < priceGameObj.Length; i++)
            {
                priceGameObj[i].GetComponent<Text>().text = gemPriceList[startingNo].ToString();
                startingNo++;
            }
        }
        else if (currency.name == "Money")
        {
            for (int i = 0; i < currencyGameObj.Length; i++)
            {
                currencyGameObj[i].GetComponent<Image>().sprite = moneyCurrency;
            }
            for (int i = 0; i < itemGameObj.Length; i++)
            {
                itemGameObj[i].GetComponent<Image>().sprite = moneyItemList[startingNo];
                startingNo++;
            }
            if (pageNo == 1)
            {
                startingNo = 0;
            }
            else if (pageNo == 2)
            {
                startingNo = 3;
            }
            else if (pageNo == 3)
            {
                startingNo = 6;
            }
            else if (pageNo == 4)
            {
                startingNo = 9;
            }
            for (int i = 0; i < priceGameObj.Length; i++)
            {
                priceGameObj[i].GetComponent<Text>().text = "$" + moneyPriceList[startingNo].ToString();

                if (startingNo == 11)
                {                   
                    priceGameObj[i].GetComponent<Text>().text = "NA";
                }
                startingNo++;
            }
        }
        else if (currency.name == "AD") 
        {
            for (int i = 0; i < currencyGameObj.Length; i++)
            {
                currencyGameObj[i].GetComponent<Image>().sprite = adCurrency;
            }
            for (int i = 0; i < itemGameObj.Length; i++)
            {
                itemGameObj[i].GetComponent<Image>().sprite = adItemList[startingNo];
                startingNo++;
            }
            if (pageNo == 1)
            {
                startingNo = 0;
            }
            else if (pageNo == 2)
            {
                startingNo = 3;
            }
            else if (pageNo == 3)
            {
                startingNo = 6;
            }
            else if (pageNo == 4)
            {
                startingNo = 9;
            }
            for (int i = 0; i < priceGameObj.Length; i++)
            {
                priceGameObj[i].GetComponent<Text>().fontSize = 25;
                priceGameObj[i].GetComponent<Text>().text = adPriceList[startingNo];
                
                startingNo++;
            }
        }
    }
    int activeStore =1;
    public void RightButtonPressed()
    {
        pageNo = pageNo + 1;
        
        if (activeStore == 1)
        {
            if (pageNo == 2)
            {
                leftButton.gameObject.SetActive(true);
                PageSetup(coinCurrency);

            }
            else if (pageNo == 3)
            {
                PageSetup(coinCurrency);
                rightButton.gameObject.SetActive(false);
            }
        }
        else if (activeStore == 2)
        {
            if (pageNo == 2)
            {
                leftButton.gameObject.SetActive(true);
                PageSetup(gemCurrency);

            }
            else if (pageNo == 3)
            {
                PageSetup(gemCurrency);
                rightButton.gameObject.SetActive(false);
            }
        }
        else if (activeStore == 3)
        {

            if (pageNo == 2)
            {
                leftButton.gameObject.SetActive(true);
                PageSetup(moneyCurrency);

            }
            else if (pageNo == 3)
            {
                PageSetup(moneyCurrency);
            }
            else if (pageNo == 4)
            {
                PageSetup(moneyCurrency);
                rightButton.gameObject.SetActive(false);
            }
        }
        else if (activeStore == 4)
        {
            if (pageNo == 2)
            {
                leftButton.gameObject.SetActive(true);
                PageSetup(adCurrency);
                rightButton.gameObject.SetActive(false);
            }
        }
    }

    public void LeftButtonPressed()
    {
        pageNo = pageNo - 1;

        if (activeStore == 1)
        {
            if (pageNo == 1)
            {
                leftButton.gameObject.SetActive(false);
                PageSetup(coinCurrency);
            }
            else if (pageNo == 2)
            {
                rightButton.gameObject.SetActive(true);
                PageSetup(coinCurrency);
            }
        }
        else if (activeStore == 2)
        {
            if (pageNo == 1)
            {
                leftButton.gameObject.SetActive(false);
                PageSetup(gemCurrency);
            }
            else if (pageNo == 2)
            {
                rightButton.gameObject.SetActive(true);
                PageSetup(gemCurrency);
            }
        }
        else if (activeStore == 3)
        {
            if (pageNo == 1)
            {
                leftButton.gameObject.SetActive(false);
                PageSetup(moneyCurrency);
            }
            else if (pageNo == 2)
            {
                rightButton.gameObject.SetActive(true);
                PageSetup(moneyCurrency);
            }
             else if (pageNo == 3)
             {
                 PageSetup(moneyCurrency);
             }
 
        }
        else if (activeStore == 4)
        {

            if (pageNo == 1)
            {
                leftButton.gameObject.SetActive(false);
                rightButton.gameObject.SetActive(true);
                PageSetup(adCurrency);
            }           
        }
    }
}
