using System.Collections;
using UnityEngine;

public class Mathlockerkeypad : MonoBehaviour
{
    public Animator WrongPassword;
    public GameObject WrongPasswordGameObject;

    private void Start()
    {
        WrongPasswordGameObject = GameObject.FindGameObjectWithTag("PasswordDisplay");
        WrongPassword = WrongPasswordGameObject.GetComponent<Animator>();
    }

    public void buttonPressed(string password)
    {
        if (password == "Clr")
        {
            displayPassword.PasswordText.text = "";
        }
        else if (password == "Enter")
        {
            if (displayPassword.PasswordText.text == "2531")
            {
                displayPassword.Unlocked = true;
            }
            else
            {
                StartCoroutine(WrongPass());
            }
        }
        else
        {
            displayPassword.PasswordText.text += password;
        }
    }

    IEnumerator WrongPass()
    {
        WrongPassword.SetTrigger("WorngPassword");
        yield return new WaitForSeconds(.5f);
        displayPassword.PasswordText.text = "";
    }
}
