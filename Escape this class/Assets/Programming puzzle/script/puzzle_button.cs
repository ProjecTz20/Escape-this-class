using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle_button : MonoBehaviour
{
    public GameObject background1;
    public GameObject button1;
    public void next(GameObject background1)
    {
        background1.SetActive(false);
        button1.SetActive(false);
    }
}
