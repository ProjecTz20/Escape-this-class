using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject wowza;

    public void buttonPress(GameObject SceneOpen)
    {
        SceneOpen.SetActive(true);
    }

    public void QuitInfo(GameObject SceneOpen)
    {
        SceneOpen.SetActive(false);
    }
}
