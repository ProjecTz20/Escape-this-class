using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainPuzzle : MonoBehaviour
{
    public TextMeshProUGUI CodeText;
    public TextMeshProUGUI ExpectedResult;
    public int CurrentLevel = 1;

    public static List<string> CodeList = new List<string>();

    //Button
    public void button1()
    {
        if (CodeList.Count <= 6)
        {
            CodeList.Add("HelloWorld");
            CodeText.text = CodeText + "\n" + "(\"Print(\\\"HelloWorld\\\")\")";
        }
    }

    public void button2()
    {
        if (CodeList.Count <= 6)
        {
            CodeList.Add("I");
            CodeText.text = CodeText + "\n" + "(\"Print(\\\"I\\\")\")";
        }
    }

    public void button3()
    {
        if (CodeList.Count <= 6)
        {
            CodeList.Add("for");
        }
    }
    public void clearButton()
    {
        CodeList.Clear();
        CodeText.text = "";
    }

    public void runButton()
    {
        
    }

    IEnumerator CodeRunning()
    {
        yield return new WaitForSeconds(.5f);
    }


}
