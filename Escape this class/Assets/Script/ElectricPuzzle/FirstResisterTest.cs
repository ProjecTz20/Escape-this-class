using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstResisterTest : MonoBehaviour
{
    public static bool firstRInserted;

    // Start is called before the first frame update
    void Start()
    {
        firstRInserted = false;
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "110R" || collider.gameObject.tag == "11R")
        {
            firstRInserted = true;
            print("FirstResisterinserted");
        }
    }
}
