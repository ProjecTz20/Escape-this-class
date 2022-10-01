using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChemistryRoomopen : MonoBehaviour
{
    public Animator Dooropen;
    public AudioSource Doorcracksfx;

    private void Start()
    {
        //openChemist();
    }

    public void openChemist()
    {
        if (LightControlPanel.ClassLightOn == true)
        {
            Dooropen.SetTrigger("DoorOpen");
            Doorcracksfx.Play();
        }

    }
}
