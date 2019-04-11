using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Janken : MonoBehaviour
{
    bool figJanken = false;
    bool showSelectJanken = false;
    bool clickJanken = false;
    GameObject jButton;
    GameObject gooButton;
    GameObject chokiButton;
    GameObject parButton;
    int modeJanken = 0;
    public AudioClip voice_janken_start;
    public AudioClip voice_janken_pon;
    public AudioClip voice_janken_choki;
    public AudioClip voice_janken_par;
    public AudioClip voice_janken_win;
    public AudioClip voice_janken_draw;
    public AudioClip voice_janken_loose;
    const int JANKEN = 0;
    const int GOO = 1;
    const int CHOKI = 2;
    const int PAR = 3;
    const int DRAW = 4;
    const int WIN = 5;
    const int LOOSE = 6;
    Animator animator;
    AudioSource univoice;
    int myHand;
    int uniHand;
    int figResult;
    float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        jButton = GameObject.Find("JButton");
        gooButton = GameObject.Find("GooButton");
        chokiButton = GameObject.Find("ChokiButton");
        parButton = GameObject.Find("ParButton");
        animator = GetComponent<Animator>();
        univoice = GetComponent<AudioSource>();
        gooButton.SetActive(false);
        chokiButton.SetActive(false);
        parButton.SetActive(false);
    }

    void UnitychanAction(int action)
    {
        switch(action)
        {
            case JANKEN:
                animator.SetBool("Janken", true);
                univoice.clip = voice_janken_start;
                break;

            case GOO:
                animator.SetBool("Goo", true);
                univoice.clip = voice_janken_start;
                break;

            case CHOKI:
                animator.SetBool("Choki", true);
                univoice.clip = voice_janken_start;
                break;

            case PAR:
                animator.SetBool("Par", true);
                univoice.clip = voice_janken_start;
                break;

            case DRAW:
                animator.SetBool("Aiko", true);
                univoice.clip = voice_janken_start;
                break;

            case WIN:
                animator.SetBool("Win", true);
                univoice.clip = voice_janken_start;
                break;

            case LOOSE:
                animator.SetBool("Loose", true);
                univoice.clip = voice_janken_start;
                break;
        }
        univoice.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(figJanken == true)
        {
            switch(modeJanken)
            {
                case 0: // 가위바위보 시작
                    UnitychanAction(JANKEN);
                    modeJanken++;
                    break;

                case 1: // 플레이어 입력 기다림
                    animator.SetBool("Janken", false);
                    animator.SetBool("Aiko", false);
                    animator.SetBool("Goo", false);
                    animator.SetBool("Choki", false);
                    animator.SetBool("Par", false);
                    animator.SetBool("Win", false);
                    animator.SetBool("Loose", false);
                    break;

                case 2: // 가위바위보 판정
                    figResult = -1;
                    uniHand = Random.Range(GOO, PAR + 1);
                    UnitychanAction(uniHand);
                    if(myHand == uniHand)
                    {
                        figResult = DRAW;
                    }
                    else
                    {
                        switch(uniHand)
                        {
                            case GOO:
                                if (myHand == PAR)
                                    figResult = LOOSE;
                                break;

                            case CHOKI:
                                if (myHand == GOO)
                                    figResult = LOOSE;
                                break;

                            case PAR:
                                if (myHand == CHOKI)
                                    figResult = LOOSE;
                                break;
                        }
                    }
                    if (figResult != LOOSE)
                        figResult = WIN;
                    modeJanken ++;
                    break;

                case 3: // 가위바위보 결과
                    waitTime += Time.deltaTime;
                    if(waitTime > 1.5)
                    {
                        UnitychanAction(figResult);
                        waitTime = 0;
                        modeJanken++;
                    }
                    break;

                case 4: // 가위바위보 끝
                    figJanken = false;
                    figResult = 0;
                    jButton.SetActive(true);
                    gooButton.SetActive(false);
                    chokiButton.SetActive(false);
                    parButton.SetActive(false);
                    modeJanken = 0;
                    break;
            }
        }
    }

    public void StartJanken()
    {
        figJanken = true;
        jButton.SetActive(false);
        gooButton.SetActive(true);
        chokiButton.SetActive(true);
        parButton.SetActive(true);
    }

    public void SelectGoo()
    {
        myHand = GOO;
        modeJanken++;
    }

    public void Selectchoki()
    {
        myHand = CHOKI;
        modeJanken++;
    }

    public void SelectPar()
    {
        myHand = PAR;
        modeJanken++;
    }
}
