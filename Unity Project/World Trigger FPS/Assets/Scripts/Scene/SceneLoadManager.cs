using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoadManager : MonoBehaviour
{
    // Parameters
    [SerializeField]
    private float AutomaticTipChangeTime = 5;
    [SerializeField]
    private float AutomaticTipFadeTime = 1;
    [SerializeField]
    private LeanTweenType AutomaticTipTweenType = LeanTweenType.linear;
    [SerializeField]
    private float MinLoadTime = 5;


    // Objects
    // Tips
    [SerializeField]
    private SceneLoadTipsScriptableObject TipsObject;
    [SerializeField]
    private TMPro.TextMeshProUGUI TipText;
    [SerializeField]
    private Image TipImage;
    [SerializeField]
    private RectTransform TipFadeObject;
    [SerializeField]
    private Canvas SceneLoaderCanvas;

    // Loading
    [SerializeField]
    private TMPro.TextMeshProUGUI LoadPercentageText;
    [SerializeField]
    private Image LoadPercentageImage;
    [SerializeField]
    private GameObject LoadObjectsOnOff;
    [SerializeField]
    private RectTransform FadeObject;

    // Background Image
    [SerializeField]
    private Image BackgroundImage;

    // Variables
    private float AutoTipChangeTimer = 0;
    private string SceneToLoad;
    private float MinLoadTimer = 0;
    public static SceneLoadManager Instance = null;

    // Functions
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }

        LeanTween.alpha(FadeObject, 0, AutomaticTipFadeTime).setEase(AutomaticTipTweenType).setOnComplete(MinSortOrder);
    }

    public void LoadGameScene(string SceneName)
    {
        SceneToLoad = SceneName;
        StartCoroutine(IE_LoadGameScene());
    }

    private IEnumerator IE_LoadGameScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneToLoad);
        Debug.Log("Load Scene; " + SceneToLoad);
        SceneLoaderCanvas.sortingOrder = 100;
        LeanTween.alpha(FadeObject, 1, AutomaticTipFadeTime).setEase(AutomaticTipTweenType).setOnComplete(OnLoadStart);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone || MinLoadTimer < MinLoadTime)
        {
            float RoundedPercentage = Mathf.Round(asyncLoad.progress * 10) / 10;
            LoadPercentageImage.fillAmount = RoundedPercentage / 100;
            LoadPercentageText.text = RoundedPercentage + "%";

            MinLoadTimer += Time.deltaTime;
            AutoTipChangeTimer += Time.deltaTime;
            if (AutoTipChangeTimer >= AutomaticTipChangeTime)
            {
                FadeOutOldTip();
            }
            yield return null;
        }

        LeanTween.alpha(FadeObject, 1, AutomaticTipFadeTime).setEase(AutomaticTipTweenType).setOnComplete(OnLoadComplete);
    }

    public void MinSortOrder()
    {
        SceneLoaderCanvas.sortingOrder = 0;
    }

    public void OnLoadStart()
    {
        LoadObjectsTurn();
        LoadNewTip();
        LeanTween.alpha(FadeObject, 0, AutomaticTipFadeTime).setEase(AutomaticTipTweenType);
    }

    public void OnLoadComplete()
    {
        LoadObjectsTurn(false);
        SceneLoaderCanvas.sortingOrder = 0;
    }

    private void LoadNewTip()
    {
        LoadingTip RandomTip = TipsObject.GetRandomTip();
        TipText.text = RandomTip.Tip;
        TipImage.sprite = RandomTip.TipImage;
    }
    private void FadeInNewTip()
    {
        LoadNewTip();
        LeanTween.alpha(TipFadeObject, 0, AutomaticTipFadeTime).setEase(AutomaticTipTweenType);
    }
    private void FadeOutOldTip()
    {
        LeanTween.alpha(TipFadeObject, 1, AutomaticTipFadeTime).setEase(AutomaticTipTweenType).setOnComplete(FadeInNewTip);
    }
    private void LoadObjectsTurn(bool On = true)
    {
        LoadObjectsOnOff.SetActive(On);
    }
    private void TurnOffObjectsOnLoad()
    {
        LoadObjectsTurn(false);
    }
}
