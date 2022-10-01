using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondRTest : MonoBehaviour
{
    public static bool secondRInserted;

    // Start is called before the first frame update
    void Start()
    {
        secondRInserted = false;
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "110R" || collider.gameObject.tag == "11R")
        {
            secondRInserted = true;
            print("SecondRinserted");
        }
    }
}
