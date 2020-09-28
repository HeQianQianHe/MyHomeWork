using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public Sprite home, classroom1, classroom2;
    public SpriteRenderer bgSR;

    public GameObject kaishiButton;
    public GameObject sleepButton;
    public GameObject isClassTadayPage;
    public GameObject getupButton;
    public GameObject eatBreakButton;
    public GameObject checkTimePage;
    public GameObject walkButton, runButton,backButton;
    public GameObject ClassPage;
    public GameObject PlayGameButton;
    public GameObject beginSleepButton;
    public GameObject getKnowledeg;
    public GameObject waitClassDown;
    public GameObject bell;
    public GameObject AnotherClassPage;
    public GameObject ChangeClothButton;
    public GameObject dasaunshuijiaoButton;
    public GameObject tiwenPage;
    public GameObject xiang;
    public GameObject buxiang;

    public AnimatorController animatorController;
    void Start()
    {
    }

    void Update()
    {
        
    }

    public void KaiShi()
    {
        animatorController.SetInt("animation,"+ Random.Range(1, 19));
        kaishiButton.SetActive(false);
        sleepButton.SetActive(true);
    }

    public void Already7()
    {
        animatorController.SetInt("animation," + Random.Range(1, 19));
        ChangeClothButton.SetActive(false);
        sleepButton.SetActive(false);
        isClassTadayPage.SetActive(true);
    }
    public void YesToday()
    {
        animatorController.SetInt("animation," + Random.Range(1, 19));
        getupButton.SetActive(true);
        isClassTadayPage.SetActive(false);
    }
    public void NoToday()
    {
        animatorController.SetInt("animation," + Random.Range(1, 19));
        dasaunshuijiaoButton.SetActive(true);
        isClassTadayPage.SetActive(false);
    }
    public void GetUpready()
    {
        animatorController.SetInt("animation," + 15);
        getupButton.SetActive(false);
        eatBreakButton.SetActive(true);
    }
    public void EatBreakready()
    {
        animatorController.SetInt("animation," + Random.Range(1, 19));
        eatBreakButton.SetActive(false);
        checkTimePage.SetActive(true);
    }
    public void GoSchool(int mode)
    {
        
        checkTimePage.SetActive(false);
        if (mode == 1)
        {
            bgSR.sprite = classroom1;
            animatorController.SetInt("animation,10");
            runButton.SetActive(true);
        }
        if (mode == 2)
        {
            bgSR.sprite = classroom1;
            animatorController.SetInt("animation,6");
            walkButton.SetActive(true);
        }
        if (mode == 3)
        {
            animatorController.SetInt("animation,13");
            backButton.SetActive(true);
        }
    }
    public void GoBackHome()
    {
        bgSR.sprite = home;
        animatorController.SetInt("animation," + Random.Range(1, 19));
        ChangeClothButton.SetActive(true);
        
        PlayGameButton.SetActive(true);
        backButton.SetActive(false);
    }
    public void PlayGame()
    {
        animatorController.SetInt("animation," + Random.Range(1, 19));
        PlayGameButton.SetActive(false);
        tiwenPage.SetActive(true);
    }
    public void ShuiJiao()
    {
        animatorController.SetInt("animation," + Random.Range(1, 19));
        beginSleepButton.SetActive(false);
        sleepButton.SetActive(true);
    }
    public void InClass()
    {
        animatorController.SetInt("animation," + Random.Range(1, 19));
        runButton.SetActive(false);
        walkButton.SetActive(false);
        ClassPage.SetActive(true);
    }
    public void Interested()
    {
        animatorController.SetInt("animation," + Random.Range(1, 19));
        getKnowledeg.SetActive(true);
        Invoke("Close", 1);
    }
    void Close()
    {
        animatorController.SetInt("animation," + Random.Range(1, 19));
        getKnowledeg.SetActive(false);
    }
    public void NoInterested()
    {
        animatorController.SetInt("animation," + Random.Range(1, 19));
        ClassPage.SetActive(false);
        waitClassDown.SetActive(true);
        Invoke("Close2", 2);
    }
    void Close2()
    {
        animatorController.SetInt("animation," + Random.Range(1, 19));
        waitClassDown.SetActive(false);
        bell.SetActive(true);
        Invoke("Close3", 2);
    }
    void Close3()
    {
        animatorController.SetInt("animation," + Random.Range(1, 19));
        bell.SetActive(false);
        AnotherClassPage.SetActive(true);
    }
    public void ZhunBeiShuiJiao()
    {
        bgSR.sprite = home;
        animatorController.SetInt("animation," + Random.Range(1, 19));
        AnotherClassPage.SetActive(false);
        dasaunshuijiaoButton.SetActive(true);
    }
    public void tiwen()
    {
        animatorController.SetInt("animation," + Random.Range(1, 19));
        tiwenPage.SetActive(true);
        dasaunshuijiaoButton.SetActive(false);
    }
    public void can()
    {
        animatorController.SetInt("animation,15" );
        xiang.SetActive(true);
        tiwenPage.SetActive(false);
        ChangeClothButton.SetActive(true);
        
    }
    public void cant()
    {
        animatorController.SetInt("animation,15");
        buxiang.SetActive(true);
        tiwenPage.SetActive(false);
        ChangeClothButton.SetActive(true);
        
    }
    public void shuila()
    {
        animatorController.SetInt("animation,16");
        xiang.SetActive(false);
        buxiang.SetActive(false);
        sleepButton.SetActive(true);
    }

}
