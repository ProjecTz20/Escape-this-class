using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levertext : MonoBehaviour
{
    public static bool switchon = false;
    public AudioSource sfx;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Lever")
        {
            switchon = true;
            sfx.Play();
            print("Leverswitchon");
        }
    }
}
