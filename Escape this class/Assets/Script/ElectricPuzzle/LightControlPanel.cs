using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControlPanel : MonoBehaviour
{
    public bool firstRInserted;
    public bool secondRInserted;
    public bool leveron;
    public AudioSource LightHum;
    public GameObject Light;
    public static bool ClassLightOn;


    //programmingPuzzle
    public GameObject ProgrammingCanvas;
    public AudioSource WindowstartSFX;
    void Update()
    {
        firstRInserted = FirstResisterTest.firstRInserted;
        secondRInserted = SecondRTest.secondRInserted;
        leveron = levertext.switchon;

        if (leveron && firstRInserted && secondRInserted && !ClassLightOn)
        {

            ClassLightOn = true;
            LightOn();
        }
    }

    public void LightOn()
    {
        Light.SetActive(true);
        LightHum.Play();

        //turnOnPrograamingPuzzle
        ProgrammingCanvas.SetActive(true);
        WindowstartSFX.Play();

    }
}
