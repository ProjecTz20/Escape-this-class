using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displayPassword : MonoBehaviour
{
    public static TextMeshProUGUI PasswordText;
    public Animator Dooropen;
    public static bool Unlocked = false;

    private void Start()
    {
       PasswordText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (Unlocked == true)
        {
            Dooropen.SetTrigger("Unlocked");
            print("unlocked");
        }
    }
}
