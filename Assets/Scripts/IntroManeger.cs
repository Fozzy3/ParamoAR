using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroManeger : MonoBehaviour
{
    [SerializeField]
    private GameObject intro;

    [SerializeField]
    private GameObject windowsStart;

    [SerializeField]
    private int timeVideo;

    [SerializeField]
    private int timeProcess;


    void Start()
    {
        InitialPorcess();
    }

    IEnumerator ProcessIntro()
    {
        timeProcess++;

        if(timeProcess == timeVideo)
        {
            intro.SetActive(false);
            windowsStart.SetActive(true);
        }
        yield return new WaitForSeconds(1);
        InitialPorcess();
    }

    private void InitialPorcess()
    { 
        StartCoroutine(ProcessIntro());
    }





}
