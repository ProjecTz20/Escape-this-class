using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class keypadbutton : MonoBehaviour
{
    keypad key;
    TextMeshProUGUI buttonText;

    // Start is called before the first frame update
    void Start()
    {
        key = GetComponentInParent<keypad>();
        buttonText = GetComponentInParent<TextMeshProUGUI>();
        if (buttonText.text.Length == 1)
        {
            NameToButtonText();
            GetComponentInChildren<ButtonVR>().onRelease.AddListener(delegate { keypad.InsertChar(buttonText.text); });
        }
    }
    public void NameToButtonText()
    {
        buttonText.text = gameObject.name;
    }
}
