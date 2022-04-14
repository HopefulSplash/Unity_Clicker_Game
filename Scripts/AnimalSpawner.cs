using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.FantasyMonsters.Scripts;
using UnityEngine.UI;
public class AnimalSpawner : MonoBehaviour
{
    public GameObject chick;
    public GameController gameController;
    public GameObject spwanerGameObjectSmall;
    public GameObject spwanerGameObjectMedium;
    public GameObject spwanerGameObjectShield;
    public GameObject spwanerGameObjectLarge;
    public GameObject spwanerGameObjectBoss;
    public GameObject HPbar;
    public int layerManager;
    public LayerManager layerManagerScript;
    public KeepAudio KeepAudio;
    public List<GameObject> animals;
    public List<Slider> animalsHP;
    public List<int> valueHPList;
    public List<bool> animalHasDied;
    public int animalHPValue;
    public int animalID;
    private GameObject animal;
    public SortingLayer sortingLayer;
    public GameObject[] gameObjects;
    public int attackValue;
    public AnimalSpawner instance;
    public StateHandler stateHandler;
    public int animalReference;
    public int lastAnimalReference;
    public int animalKill;
    public string acStatus;
    public string aiStatus;
    public string aStatus;
    //Quest / achivement Amount

    

    private void Start()
    {
     
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public AnimalSpawner GetSpawner()
    {
        return instance;
    }
    public void SPawn(int option ,int animalNumberSpawn, int HP)
    {
        //add to method call for final
        animalHPValue = HP;
        int i = animalNumberSpawn;
        if (option == 1)
        {
            //change after testing
 
                Vector2 spawnPosition = new Vector2(0, 0);

                animal = Instantiate(gameObjects[i], spawnPosition, Quaternion.identity, spwanerGameObjectSmall.transform);
                SpriteRenderer[] renders = animal.GetComponentsInChildren<SpriteRenderer>();

                float spawnY = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y + (animal.GetComponent<CapsuleCollider2D>().bounds.size.y - 0.65f), Camera.main.ScreenToWorldPoint(new Vector2(0, ((Screen.height / 2) - 80))).y);
                float spawnX = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x + animal.GetComponent<CapsuleCollider2D>().bounds.size.x / 1.6f, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x - animal.GetComponent<CapsuleCollider2D>().bounds.size.x / 1.5f);

                spawnPosition = new Vector2(spawnX, spawnY);
                animal.transform.position = spawnPosition;
                animal.GetComponent<LayerManager>().SortingGroup.sortingOrder = layerManager;
                animal.GetComponent<SpriteRenderer>().sortingOrder = layerManager;
                animal.GetComponent<Monster>().name = animal.GetComponent<Monster>().name + animalID;
                animal.GetComponent<Monster>().SetupSpawner(this);
                animals.Add(animal);

                Canvas canvas = animal.GetComponentInChildren<Canvas>();
                animalsHP.Add(canvas.GetComponentInChildren<Slider>());
                RectTransform[] rect = canvas.GetComponentsInChildren<RectTransform>();
                GameObject temp = GameObject.FindGameObjectWithTag("Shadow");



                //size
                float width = animal.GetComponent<CapsuleCollider2D>().bounds.size.x;//temp.GetComponent<SpriteRenderer>().size.x / 1.5f;
                float hieght = rect[1].sizeDelta.y;
                //set size
                rect[1].GetComponent<RectTransform>().sizeDelta = new Vector2(width, hieght);
                //poistion
                Rect rect1 = new Rect(0, 0, width, hieght);

                float x = animal.GetComponent<SpriteRenderer>().bounds.center.x - rect1.center.x / 1.50f;
                float y = spawnPosition.y + animal.GetComponent<CapsuleCollider2D>().bounds.size.y;


                rect[1].GetComponent<RectTransform>().transform.position = new Vector2(x, y);

                canvas.GetComponentInParent<Canvas>().sortingOrder = layerManager;
                animalsHP[layerManager].name = animalsHP[layerManager].name + animalID;
                PlayAnimalSound("Appear", animal);
                valueHPList.Add(animalHPValue);
                SetAnimalHP(layerManager);
                animalHasDied.Add(false);
                animalID++;
                layerManager++;
            
        }
        else if (option == 2)
        {
            
                Vector2 spawnPosition = new Vector2(0, 0);

                animal = Instantiate(gameObjects[i], spawnPosition, Quaternion.identity, spwanerGameObjectMedium.transform);
                SpriteRenderer[] renders = animal.GetComponentsInChildren<SpriteRenderer>();

                float spawnY = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y + (animal.GetComponent<CapsuleCollider2D>().bounds.size.y - 0.85f), Camera.main.ScreenToWorldPoint(new Vector2(0, ((Screen.height / 2) - 80))).y);
                float spawnX = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x + animal.GetComponent<CapsuleCollider2D>().bounds.size.x / 1.6f, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x - animal.GetComponent<CapsuleCollider2D>().bounds.size.x / 1.5f);

                spawnPosition = new Vector2(spawnX, spawnY);
                animal.transform.position = spawnPosition;
                animal.GetComponent<LayerManager>().SortingGroup.sortingOrder = layerManager;
                animal.GetComponent<SpriteRenderer>().sortingOrder = layerManager;
                animal.GetComponent<Monster>().name = animal.GetComponent<Monster>().name + animalID;
                animal.GetComponent<Monster>().SetupSpawner(this);
                animals.Add(animal);

                Canvas canvas = animal.GetComponentInChildren<Canvas>();
                animalsHP.Add(canvas.GetComponentInChildren<Slider>());
                RectTransform[] rect = canvas.GetComponentsInChildren<RectTransform>();
                GameObject temp = GameObject.FindGameObjectWithTag("Shadow");



                //size
                float width = animal.GetComponent<CapsuleCollider2D>().bounds.size.x / 1.50f;
                float hieght = rect[1].sizeDelta.y;
                //set size
                rect[1].GetComponent<RectTransform>().sizeDelta = new Vector2(width, hieght);
                //poistion
                Rect rect1 = new Rect(0, 0, width, hieght);

                float x = animal.GetComponent<SpriteRenderer>().bounds.center.x - rect1.center.x / 1.125f;
                float y = spawnPosition.y + animal.GetComponent<CapsuleCollider2D>().bounds.size.y;


                rect[1].GetComponent<RectTransform>().transform.position = new Vector2(x, y);

                canvas.GetComponentInParent<Canvas>().sortingOrder = layerManager;
                animalsHP[layerManager].name = animalsHP[layerManager].name + animalID;
                PlayAnimalSound("Appear", animal);
                valueHPList.Add(animalHPValue);
                SetAnimalHP(layerManager);
                animalHasDied.Add(false);
                animalID++;
                layerManager++;
            
        }
        else if (option == 3)
        {
           
                Vector2 spawnPosition = new Vector2(0, 0);

                animal = Instantiate(gameObjects[i], spawnPosition, Quaternion.identity, spwanerGameObjectLarge.transform);
                SpriteRenderer[] renders = animal.GetComponentsInChildren<SpriteRenderer>();

                float spawnY = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y + (animal.GetComponent<CapsuleCollider2D>().bounds.size.y - 1.08f), Camera.main.ScreenToWorldPoint(new Vector2(0, ((Screen.height / 2) - 80))).y);
                float spawnX = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x + animal.GetComponent<CapsuleCollider2D>().bounds.size.x / 1.6f, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x - animal.GetComponent<CapsuleCollider2D>().bounds.size.x / 1.5f);

                spawnPosition = new Vector2(spawnX, spawnY);
                animal.transform.position = spawnPosition;
                animal.GetComponent<LayerManager>().SortingGroup.sortingOrder = layerManager;
                animal.GetComponent<SpriteRenderer>().sortingOrder = layerManager;
                animal.GetComponent<Monster>().name = animal.GetComponent<Monster>().name + animalID;
                animal.GetComponent<Monster>().SetupSpawner(this);
                animals.Add(animal);

                Canvas canvas = animal.GetComponentInChildren<Canvas>();
                animalsHP.Add(canvas.GetComponentInChildren<Slider>());
                RectTransform[] rect = canvas.GetComponentsInChildren<RectTransform>();
                GameObject temp = GameObject.FindGameObjectWithTag("Shadow");



                //size
                float width = animal.GetComponent<CapsuleCollider2D>().bounds.size.x / 2f;//temp.GetComponent<SpriteRenderer>().size.x / 1.5f;
                float hieght = rect[1].sizeDelta.y;
                //set size
                rect[1].GetComponent<RectTransform>().sizeDelta = new Vector2(width, hieght);
                //poistion
                Rect rect1 = new Rect(0, 0, width, hieght);

                float x = animal.GetComponent<SpriteRenderer>().bounds.center.x - rect1.center.x / 0.90f;
                float y = spawnPosition.y + animal.GetComponent<CapsuleCollider2D>().bounds.size.y;


                rect[1].GetComponent<RectTransform>().transform.position = new Vector2(x, y);

                canvas.GetComponentInParent<Canvas>().sortingOrder = layerManager;
                animalsHP[layerManager].name = animalsHP[layerManager].name + animalID;
                PlayAnimalSound("Appear", animal);
                valueHPList.Add(animalHPValue);
                SetAnimalHP(layerManager);
                animalHasDied.Add(false);
                animalID++;
                layerManager++;
            
        }
        else if (option == 4)
        {
            
                Vector2 spawnPosition = new Vector2(0, 0);

                animal = Instantiate(gameObjects[i], spawnPosition, Quaternion.identity, spwanerGameObjectShield.transform);
                SpriteRenderer[] renders = animal.GetComponentsInChildren<SpriteRenderer>();

                float spawnY = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y + (animal.GetComponent<CapsuleCollider2D>().bounds.size.y - 0.90f), Camera.main.ScreenToWorldPoint(new Vector2(0, ((Screen.height / 2) - 80))).y);
                float spawnX = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x + animal.GetComponent<CapsuleCollider2D>().bounds.size.x / 1.6f, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x - animal.GetComponent<CapsuleCollider2D>().bounds.size.x / 1.5f);

                spawnPosition = new Vector2(spawnX, spawnY);
                animal.transform.position = spawnPosition;
                animal.GetComponent<LayerManager>().SortingGroup.sortingOrder = layerManager;
                animal.GetComponent<SpriteRenderer>().sortingOrder = layerManager;
                animal.GetComponent<Monster>().name = animal.GetComponent<Monster>().name + animalID;
                animal.GetComponent<Monster>().SetupSpawner(this);
                animals.Add(animal);

                Canvas canvas = animal.GetComponentInChildren<Canvas>();
                animalsHP.Add(canvas.GetComponentInChildren<Slider>());
                RectTransform[] rect = canvas.GetComponentsInChildren<RectTransform>();
                GameObject temp = GameObject.FindGameObjectWithTag("Shadow");



                //size
                float width = animal.GetComponent<CapsuleCollider2D>().bounds.size.x / 1.75f;//temp.GetComponent<SpriteRenderer>().size.x / 1.5f;
                float hieght = rect[1].sizeDelta.y;
                //set size
                rect[1].GetComponent<RectTransform>().sizeDelta = new Vector2(width, hieght);
                //poistion
                Rect rect1 = new Rect(0, 0, width, hieght);

                float x = animal.GetComponent<SpriteRenderer>().bounds.center.x - rect1.center.x / 1f;
                float y = spawnPosition.y + animal.GetComponent<CapsuleCollider2D>().bounds.size.y;


                rect[1].GetComponent<RectTransform>().transform.position = new Vector2(x, y);

                canvas.GetComponentInParent<Canvas>().sortingOrder = layerManager;
                animalsHP[layerManager].name = animalsHP[layerManager].name + animalID;
                PlayAnimalSound("Appear", animal);
                valueHPList.Add(animalHPValue);
                SetAnimalHP(layerManager);
                animalHasDied.Add(false);
                animalID++;
                layerManager++;
            
        }
        else if (option == 5)
        {
            
                Vector2 spawnPosition = new Vector2(0, 0);

                animal = Instantiate(gameObjects[i], spawnPosition, Quaternion.identity, spwanerGameObjectBoss.transform);
                SpriteRenderer[] renders = animal.GetComponentsInChildren<SpriteRenderer>();

                float spawnY = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y + (animal.GetComponent<CapsuleCollider2D>().bounds.size.y - 1.65f), Camera.main.ScreenToWorldPoint(new Vector2(0, ((Screen.height / 2) - 80))).y);
                float spawnX = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x + animal.GetComponent<CapsuleCollider2D>().bounds.size.x / 1.6f, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x - animal.GetComponent<CapsuleCollider2D>().bounds.size.x / 1.5f);

                spawnPosition = new Vector2(spawnX, spawnY);
                animal.transform.position = spawnPosition;
                animal.GetComponent<LayerManager>().SortingGroup.sortingOrder = layerManager;
                animal.GetComponent<SpriteRenderer>().sortingOrder = layerManager;
                animal.GetComponent<Monster>().name = animal.GetComponent<Monster>().name + animalID;
                animal.GetComponent<Monster>().SetupSpawner(this);
                animals.Add(animal);

                Canvas canvas = animal.GetComponentInChildren<Canvas>();
                animalsHP.Add(canvas.GetComponentInChildren<Slider>());
                RectTransform[] rect = canvas.GetComponentsInChildren<RectTransform>();
                GameObject temp = GameObject.FindGameObjectWithTag("Shadow");



                //size
                float width = animal.GetComponent<CapsuleCollider2D>().bounds.size.x / 3f;//temp.GetComponent<SpriteRenderer>().size.x / 1.5f;
                float hieght = rect[1].sizeDelta.y;
                //set size
                rect[1].GetComponent<RectTransform>().sizeDelta = new Vector2(width, hieght);
                //poistion
                Rect rect1 = new Rect(0, 0, width, hieght);

                float x = animal.GetComponent<SpriteRenderer>().bounds.center.x - rect1.center.x / 0.505f;
                float y = spawnPosition.y + animal.GetComponent<CapsuleCollider2D>().bounds.size.y;


                rect[1].GetComponent<RectTransform>().transform.position = new Vector2(x, y);

                canvas.GetComponentInParent<Canvas>().sortingOrder = layerManager;
                animalsHP[layerManager].name = animalsHP[layerManager].name + animalID;

                PlayAnimalSound("Appear", animal);
                valueHPList.Add(animalHPValue);
                SetAnimalHP(layerManager);
                animalHasDied.Add(false);
                animalID++;
                layerManager++;
            
        }

    }
    [System.Obsolete]
    public void testAnimations()
    {
        for (int i = 0; i < animals.ToArray().Length; i++)
        {
            if (animalHasDied[i] != true)
            {

                GameObject tempS = GameObject.Find(animalsHP[i].name);
                tempS.GetComponent<Slider>().value = tempS.GetComponent<Slider>().value - attackValue;
                StartCoroutine(CheckIfDead(i));
            }
        }
    }
    [System.Obsolete]
    public void ChangeHP(string animalName)
    {
        if (gameController.attackNow)
        {
            attackValue = gameController.player.playerAttack;
        }
        else if (gameController.potionNow)
        {
            attackValue = gameController.player.playerAttack * 3;
            gameController.playerPotionNumber = gameController.playerPotionNumber - 1;
            gameController.player.playerPotions = gameController.playerPotionNumber;
            gameController.player.SavePlayer();
            gameController.CheckPotions(gameController.playerPotionNumber);

        }

        gameController.totalClickCountGame++;
        gameController.thisGameScore++;
        for (int i = 0; i < animals.ToArray().Length; i++)
        {
            if (animalHasDied[i] != true)
            {
                if (animals[i].gameObject.name == animalName)
                {
                    if (lastAnimal != null)
                    {
                        if (lastAnimal.name != animals[i].name && lastAnimal != animals[animalKill])
                        {
                            if (lastAnimal.name.Contains("Duck") || lastAnimal.name.Contains("Goose") || lastAnimal.name.Contains("Drake"))
                            {
                                lastAnimal.GetComponent<Monster>().SetHead(1);
                                lastAnimal.GetComponent<Monster>().SetState(MonsterState.Idle);
                            }
                            else
                            {
                                lastAnimal.GetComponent<Monster>().SetHead(0);
                                lastAnimal.GetComponent<Monster>().SetState(MonsterState.Idle);
                            }
                        }

                    }
                    lastAnimal = animals[i];
                    GameObject tempS = GameObject.Find(animalsHP[i].name);
                    tempS.GetComponent<Slider>().value = tempS.GetComponent<Slider>().value - attackValue;
                    StartCoroutine(CheckIfDead(i));
                }
                else if (animals[i].GetComponent<Monster>().Head.sprite.name != "HeadNormal")
                {
                    if (animals[i].name.Contains("Duck") || animals[i].name.Contains("Goose") || animals[i].name.Contains("Drake"))
                    {
                        animals[i].GetComponent<Monster>().SetHead(1);
                        animals[i].GetComponent<Monster>().SetState(MonsterState.Idle);
                    }
                    else
                    {
                        animals[i].GetComponent<Monster>().SetHead(0);
                        animals[i].GetComponent<Monster>().SetState(MonsterState.Idle);
                    }
                }
            }
        }
    }
    GameObject lastAnimal;
    IEnumerator playAnimation(string option, GameObject i)
    {
        GameObject temp = GameObject.Find(i.name);
        acStatus = "New";
        if (option == "Attack")
        {
            PlayAnimalSound("Hit", i);
            temp.GetComponent<Monster>().Attack();
            yield return null;
        }
    }
    IEnumerator playDeathAnimation(string option, string i, Slider hpSlider)
    {
        GameObject temp = GameObject.Find(i);
        GameObject tempS = GameObject.Find(hpSlider.name);
        aStatus = "New";
        if (option == "Death")
        {
            PlayAnimalSound("Die", temp);
            temp.GetComponent<Monster>().SetState(MonsterState.Death);
            temp.GetComponent<Monster>().SetHead(2);
            StartCoroutine(FadeAnimalOut(temp.GetComponent<SpriteRenderer>(), tempS.GetComponentInParent<CanvasGroup>()));
        }
        while (aStatus != "Finished")
        {
            yield return null;
        }
    }
    [System.Obsolete]
    IEnumerator CheckIfDead(int animalRefer)
    {
        if (animalsHP[animalRefer].GetComponent<Slider>().value <= 0)
        {
            if (animalsHP[animalRefer].GetComponent<Slider>().maxValue == gameController.smallHp)
            {
                gameController.thisGameScore = gameController.thisGameScore + gameController.smallPoiints;
                gameController.smallLeft = gameController.smallLeft - 1;

            }
            else if (animalsHP[animalRefer].GetComponent<Slider>().maxValue == gameController.mediumHp)
            {
                gameController.thisGameScore = gameController.thisGameScore + gameController.mediumPoiints;
                gameController.mediumLeft = gameController.mediumLeft - 1;
            }
            else if (animalsHP[animalRefer].GetComponent<Slider>().maxValue == gameController.largeHp)
            {
                gameController.thisGameScore = gameController.thisGameScore + gameController.largePoiints;
                gameController.largeLeft = gameController.largeLeft - 1;
            }
            else if (animalsHP[animalRefer].GetComponent<Slider>().maxValue == gameController.sheildHp)
            {
                gameController.thisGameScore = gameController.thisGameScore + gameController.sheildPoiints;
                gameController.sheildLeft = gameController.sheildLeft - 1;
            }
            else if (animalsHP[animalRefer].GetComponent<Slider>().maxValue == gameController.bossHp)
            { 
                gameController.thisGameScore = gameController.thisGameScore + gameController.bossPoiints;
                gameController.bossLeft = gameController.bossLeft - 1;
            }
            gameController.killCount = gameController.killCount + 1;
            animals[animalRefer].layer = LayerMask.NameToLayer("Ignore Raycast");
            animalKill = animalRefer;
            animalHasDied[animalRefer] = true;
            string animalName = animals[animalRefer].name;
            StartCoroutine(playDeathAnimation("Death", animalName, animalsHP[animalRefer]));
            yield return null;

        }
        else
        {
            StartCoroutine(playAnimation("Attack", animals[animalRefer]));
            yield return null;
        }


    }
    public void CleanUpAnimals(GameObject animal)
    {
        SpriteRenderer[] animalsInSpawner = animal.GetComponentsInChildren<SpriteRenderer>();
        foreach (SpriteRenderer s in animalsInSpawner)
        {
            if (s.GetComponent<Monster>() != null)
            {
                foreach (SpriteRenderer sb in s.GetComponentsInChildren<SpriteRenderer>())
                {
                    if (sb.GetComponent<SpriteRenderer>().material.color.a != 1)
                    {
                        StartCoroutine(Delete(s.gameObject));
                    }
                }  
            }
        }
    }
    IEnumerator FadeAnimalOut(SpriteRenderer renderer, CanvasGroup canvas)
    {
        SpriteRenderer[] sprites = renderer.GetComponentsInChildren<SpriteRenderer>();
        float alpha = sprites[0].material.color.a;
        while (sprites[0].material.color.a > 0)
        {
            foreach (SpriteRenderer s in sprites)
            {
                s.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, alpha);
            }
            alpha -= 0.9f * Time.deltaTime;
            canvas.alpha -= 0.9f * Time.deltaTime;

            yield return null;
        }
        yield return new WaitForEndOfFrame();
        StartCoroutine(Delete(renderer.gameObject));
    }
    IEnumerator Delete(GameObject name)
    {
        GameObject destroyThis = GameObject.Find(name.name);
        Destroy(destroyThis);
        yield return null;
    }
    public void SetAnimalHP(int i)
    {
        animalsHP[i].GetComponent<Slider>().maxValue = valueHPList[i];
        animalsHP[i].GetComponent<Slider>().minValue = 0;
        animalsHP[i].GetComponent<Slider>().value = animalsHP[i].GetComponent<Slider>().maxValue;
    }
    public void DAnimationStarted(string started)
    {
        aStatus = started;
    }
    public void DAnimationFinished(string finished)
    {
        aStatus = finished;
    }
    public void AAnimationStarted(string started)
    {
        acStatus = started;
    }
    public void AAnimationFinished(string finished)
    {
        acStatus = finished;
    }
    public void IAnimationStarted(string started)
    {
        aiStatus = started;
    }
    public void IAnimationFinished(string finished)
    {
        aiStatus = finished;
    }
    int soundID;
    public void PlayAnimalSound(string option, GameObject animal)
    {
        if (option == "Appear")
        {
            if (animal != null)
            {
                AudioSource temp = Instantiate(animal.GetComponentInChildren<AudioSource>(), new Vector3(0f, 4.51f, 0f), Quaternion.identity, animal.transform);
                temp.name = animal.name + soundID;
                temp.volume = KeepAudio.SFX[0].volume;
                temp.Play();
                StartCoroutine(Fade(temp));
            }

        }
        else if (option == "Hit")
        {
            AudioSource temp = Instantiate(animal.GetComponentInChildren<AudioSource>(), new Vector3(0f, 4.51f, 0f), Quaternion.identity, animal.transform);
            temp.name = animal.name + soundID;
            temp.volume = KeepAudio.SFX[0].volume;
            temp.Play();
            StartCoroutine(Fade(temp));
        }
        else if (option == "Die")
        {
            AudioSource temp = Instantiate(animal.GetComponentInChildren<AudioSource>(), new Vector3(0f, 4.51f, 0f), Quaternion.identity, animal.transform);
            temp.volume = KeepAudio.SFX[0].volume;
            temp.name = animal.name + soundID;
            temp.Play();
            StartCoroutine(Fade(temp));
        }
        soundID++;
    }
    IEnumerator Fade(AudioSource fade)
    {
        float volume = fade.volume;
        float SFXVolume = KeepAudio.SFX[0].volume;
        while (fade.volume > 0)
        {
            fade.volume -= volume * Time.deltaTime / fade.clip.length;
            yield return null;
        }
        fade.Stop();
        StartCoroutine(Delete(fade.gameObject));
    }
}