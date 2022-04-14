using UnityEngine;
using UnityEngine.Purchasing;
using System;

using UnityEngine.UI;
public class IAPManager : MonoBehaviour, IStoreListener
{
    private static string coin1000 = "com.davincoswarehouse.animalescape.coin1000";
    private string coin5000 = "com.davincoswarehouse.animalescape.coin5000";
    private string coin10000 = "com.davincoswarehouse.animalescape.coin10000";
    private string gem1000 = "com.davincoswarehouse.animalescape.gem1000";
    private string gem5000 = "com.davincoswarehouse.animalescape.gem5000";
    private string gem10000 = "com.davincoswarehouse.animalescape.gem10000";
    private string heart1000 = "com.davincoswarehouse.animalescape.heart1000";
    private string heart5000 = "com.davincoswarehouse.animalescape.heart5000";
    private string heart10000 = "com.davincoswarehouse.animalescape.heart10000";
    private string removeADS = "com.davincoswarehouse.animalescape.removeads";
    private string supportDev = "com.davincoswarehouse.animalescape.supportdev";
    public Player player;
    public Store store;
    
   
    private static IStoreController m_StoreController;          // The Unity Purchasing system.
    private static IExtensionProvider m_StoreExtensionProvider; // The store-specific Purchasing subsystems.
    private static Product test_product = null;

    private Boolean return_complete = true;

    void Start()
    {


        // If we haven't set up the Unity Purchasing reference
        if (m_StoreController == null)
        {
            // Begin to configure our connection to Purchasing
            InitializePurchasing();
        }
    }

    public void InitializePurchasing()
    {
        if (IsInitialized())
        {
            return;
        }

        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

        builder.AddProduct(coin1000, ProductType.Consumable);
        builder.AddProduct(coin5000, ProductType.Consumable);
        builder.AddProduct(coin10000, ProductType.Consumable);
        builder.AddProduct(gem1000, ProductType.Consumable);
        builder.AddProduct(gem5000, ProductType.Consumable);
        builder.AddProduct(gem10000, ProductType.Consumable);
        builder.AddProduct(heart1000, ProductType.Consumable);
        builder.AddProduct(heart5000, ProductType.Consumable);
        builder.AddProduct(heart10000, ProductType.Consumable);
        builder.AddProduct(removeADS, ProductType.NonConsumable);
        builder.AddProduct(supportDev, ProductType.NonConsumable);

        UnityPurchasing.Initialize(this, builder);
    }


    private bool IsInitialized()
    {
        return m_StoreController != null && m_StoreExtensionProvider != null;
    }

    public void BuyProduct(string product)
    {
        if (product == "Coin 1000")
        {
            BuyProductID(coin1000);
        }
        else if (product == "Coin 5000")
        {
            BuyProductID(coin5000);
        }
        else if (product == "Coin 10000")
        {
            BuyProductID(coin10000);
        }
        else if (product == "Gem 1000")
        {
            BuyProductID(gem1000);
        }
        else if (product == "Gem 5000")
        {
            BuyProductID(gem5000);
        }
        else if (product == "Gem 10000")
        {
            BuyProductID(gem10000);
        }
        else if (product == "Heart 1000")
        {
            BuyProductID(heart1000);
        }
        else if (product == "Heart 5000")
        {
            BuyProductID(heart5000);
        }
        else if (product == "Heart 10000")
        {
            BuyProductID(heart10000);
        }
        else if (product == "NoAds Basic")
        {
            BuyProductID(removeADS);
        }
        else if (product == "NoAds Premium")
        {
            BuyProductID(supportDev);
        }
        else if (product == "NoAds Excel")
        {
            RestorePurchases();
        }
    }


    public void CompletePurchase()
    {
        if (test_product == null)
            MyDebug("Cannot complete purchase, product not initialized.");
        else
        {
            m_StoreController.ConfirmPendingPurchase(test_product);
            string productID = test_product.definition.id;
            GameObject temp = GameObject.FindGameObjectWithTag("Player");
            player = temp.GetComponent<Player>();
            player.LoadPlayer();
            switch (productID)
            {
                case "com.davincoswarehouse.animalescape.coin1000":

                    player.playerCoins = player.playerCoins + 1000;
                    player.SavePlayer();
                    break;
                case "com.davincoswarehouse.animalescape.coin5000":
                    player.playerCoins = player.playerCoins + 5000;
                    player.SavePlayer();
                    break;
                case "com.davincoswarehouse.animalescape.coin10000":
                    player.playerCoins = player.playerCoins + 10000;
                    player.SavePlayer();
                    break;
                case "com.davincoswarehouse.animalescape.gem1000":
                    player.playerGems = player.playerGems + 1000;
                    player.SavePlayer();
                    break;
                case "com.davincoswarehouse.animalescape.gem5000":
                    player.playerGems = player.playerGems + 5000;
                    player.SavePlayer();
                    break;
                case "com.davincoswarehouse.animalescape.gem10000":
                    player.playerGems = player.playerGems + 10000;
                    player.SavePlayer();
                    break;
                case "com.davincoswarehouse.animalescape.heart1000":
                    player.playerHearts = player.playerHearts + 1000;
                    player.SavePlayer();
                    break;
                case "com.davincoswarehouse.animalescape.heart5000":
                    player.playerHearts = player.playerHearts + 5000;
                    player.SavePlayer();
                    break;
                case "com.davincoswarehouse.animalescape.heart10000":
                    player.playerHearts = player.playerHearts + 10000;
                    player.SavePlayer();
                    break;
                case "com.davincoswarehouse.animalescape.removeads":
                    player.playerRemoveADs = true;
                    player.SavePlayer();
                    break;
                case "com.davincoswarehouse.animalescape.supportdev":
                    // nothing is a donation
                    break;
                default:
                    break;
            }
            store.BuyMenuClosed();
        }
    }

    public void ToggleComplete()
    {
        return_complete = !return_complete;
       // MyDebug("Complete = " + return_complete.ToString());

    }
    public void RestorePurchases()
    {
        m_StoreExtensionProvider.GetExtension<IAppleExtensions>().RestoreTransactions(result => {
            if (result)
            {
                MyDebug("Restore purchases succeeded.");
            }
            else
            {
                MyDebug("Restore purchases failed.");
            }
        });
    }

    void BuyProductID(string productId)
    {
        if (IsInitialized())
        {
            Product product = m_StoreController.products.WithID(productId);

            if (product != null && product.availableToPurchase)
            {
                m_StoreController.InitiatePurchase(product);
            }
            else
            {
                MyDebug("BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
            }
        }
        else
        {
            MyDebug("BuyProductID FAIL. Not initialized.");
        }
    }

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        m_StoreController = controller;
        m_StoreExtensionProvider = extensions;
    }


    public void OnInitializeFailed(InitializationFailureReason error)
    {
        // Purchasing set-up has not succeeded. Check error for reason. Consider sharing this reason with the user.
        MyDebug("OnInitializeFailed InitializationFailureReason:" + error);
    }


    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
    {
        test_product = args.purchasedProduct;



        //MyDebug(string.Format("ProcessPurchase: FAIL. Unrecognized product: '{0}'", args.purchasedProduct.definition.id));

        if (return_complete)
        {
           // MyDebug(string.Format("ProcessPurchase: Complete. Product:" + args.purchasedProduct.definition.id + " - " + test_product.transactionID.ToString()));
            CompletePurchase();
            return PurchaseProcessingResult.Complete;
        }
        else
        {
            //MyDebug(string.Format("ProcessPurchase: Pending. Product:" + args.purchasedProduct.definition.id + " - " + test_product.transactionID.ToString()));
            return PurchaseProcessingResult.Pending;
        }

    }


    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        MyDebug(string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, failureReason));
    }

    private void MyDebug(string debug)
    {

        Debug.Log(debug);
  
    }

}
