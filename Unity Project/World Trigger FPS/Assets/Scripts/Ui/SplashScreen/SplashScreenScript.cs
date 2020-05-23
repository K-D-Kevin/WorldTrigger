using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashScreenScript : MonoBehaviour
{
    // Parameters
    [SerializeField]
    private float FadeToBlack = 1;
    [SerializeField]
    private float FadeToImage = 2;
    [SerializeField]
    private float WaitTime = 1;
    [SerializeField]
    private LeanTweenType TweenTypeToBlack = LeanTweenType.easeInBack;
    [SerializeField]
    private LeanTweenType TweenTypeToImage = LeanTweenType.linear;
    [SerializeField]
    private bool UseTimer = false;

    // Objects
    [SerializeField]
    private RectTransform FadeImage;
    [SerializeField]
    private TMPro.TextMeshProUGUI TimerText;

    // Variables
    private float WaitTimer = 0;
    private float FodeToImageTimer = 0;
    private float FodeToBlackTimer = 0;
    private FadeState_SplashScreen SplashState;

    void Start()
    {
        SplashState = FadeState_SplashScreen.FadeToImage;
        LeanTween.alpha(FadeImage, 0, FadeToImage).setEase(TweenTypeToImage).setOnComplete(WaitPeriod);
        if (UseTimer)
        {
            TimerText.gameObject.SetActive(true);
        }
        else
        {
            TimerText.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (UseTimer)
        {
            float RoundedTimer = Mathf.Round(FodeToImageTimer * 10) / 10;
            float RoundedToBlackTimer = Mathf.Round(FodeToBlackTimer * 10) / 10;
            float RoundedWaitTimer = Mathf.Round(WaitTimer * 10) / 10;
            TimerText.text = SplashState + "- To Image / Wait / To Black: " + RoundedTimer + " / " + RoundedWaitTimer + " / " + RoundedToBlackTimer;
            if (SplashState == FadeState_SplashScreen.FadeToImage)
                FodeToImageTimer += Time.deltaTime;
            else if (SplashState == FadeState_SplashScreen.FadeToBlack)
                FodeToBlackTimer += Time.deltaTime;
        }
    }

    private void WaitPeriod()
    {
        StartCoroutine(IE_WaitPeriod());
    }

    private IEnumerator IE_WaitPeriod()
    {
        SplashState = FadeState_SplashScreen.Wait;

        while (WaitTimer < WaitTime)
        {
            WaitTimer += Time.deltaTime;
            yield return null;
        }

        SplashState = FadeState_SplashScreen.FadeToBlack;
        LeanTween.alpha(FadeImage, 1, FadeToBlack).setEase(TweenTypeToBlack).setOnComplete(LoadMenu);
    }

    private void LoadMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    enum FadeState_SplashScreen
    {
        FadeToImage,
        Wait,
        FadeToBlack,
    }
}
