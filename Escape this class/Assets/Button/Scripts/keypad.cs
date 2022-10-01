using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class keypad : MonoBehaviour
{
    public static TMP_InputField inputField;
    public GameObject Button;

    public static void InsertChar(string c)
    {
        inputField.text += c;
    }

    public void DeleteChar()
    {
        if (inputField.text.Length > 0)
        {
            inputField.text = inputField.text.Substring(0, inputField.text.Length - 1);
        }
    }
}
