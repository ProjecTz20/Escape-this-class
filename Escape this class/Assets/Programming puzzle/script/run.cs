using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class run : MonoBehaviour
{
    public static List<string> answer1check1 = new List<string>() {"1","2"};
    public static List<string> answer1check2 = new List<string>() { "5","a","5","b" };
    public static List<string> answer1check3 = new List<string>() { "1", "5","b" };
    public static List<string> answer1check4 = new List<string>() { "5", "a","2" };
    public static List<string> answer2check1 = new List<string>() { "6","a","8","b" };
    public static List<string> answer2check2 = new List<string>() { "1", "1", "8", "b" };
    public static List<string> answer3check = new List<string>() { "10", "c" };
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject resultpage1;
    public GameObject resultpage2;
    public GameObject resultpage3;
    public TextMeshProUGUI resulttext1;
    public TextMeshProUGUI resulttext2;
    public TextMeshProUGUI resulttext3;
    public TextMeshProUGUI Text1;
    public TextMeshProUGUI Text2;
    public TextMeshProUGUI Text3;
    public TextMeshProUGUI Text4;
    public TextMeshProUGUI Text21;
    public TextMeshProUGUI Text22;
    public TextMeshProUGUI Text23;
    public TextMeshProUGUI Text24;
    public TextMeshProUGUI Text31;
    public TextMeshProUGUI Text32;
    public TextMeshProUGUI Text33;
    public TextMeshProUGUI Text34;
    public GameObject levelcompletescreen1;
    public GameObject levelcompletescreen2;
    public GameObject levelcompletescreen3;

    public void startgogogo(int thispagenum)
    {
        StartCoroutine(gogogo(thispagenum));
    }
    IEnumerator gogogo(int thispagenum)
    {
        if (thispagenum == 1)
        {
            if (answer_status.answer1.Contains("4"))
            {
                resultpage1.SetActive(true);
                resulttext1.text = "error";
                yield return new WaitForSeconds(3);
                resultpage1.SetActive(false);
                answer_status.answer1.Clear();
                Text1.text = "";
                Text2.text = "";
                Text3.text = "";
                Text4.text = "";
                resultjedwad.result = "";
            }
            else
            {
                resultpage1.SetActive(true);
                resulttext1.text = resultjedwad.result;
                yield return new WaitForSeconds(3);
                foreach (string item in answer1check1)
                {
                    /*Debug.Log(item);*/
                }
                bool isEqual1 = answer_status.answer1.SequenceEqual(answer1check1);
                bool isEqual2 = answer_status.answer1.SequenceEqual(answer1check2);
                bool isEqual3 = answer_status.answer1.SequenceEqual(answer1check3);
                bool isEqual4 = answer_status.answer1.SequenceEqual(answer1check4);
                /*Debug.Log(isEqual);*/
                foreach (string item in answer_status.answer1)
                {
                    Debug.Log(item);
                }
                if (isEqual1|| isEqual2|| isEqual3|| isEqual4)
                {
                    page1.SetActive(false);
                    resulttext1.text = "";
                    answer_status.answer1.Clear();
                    Text1.text = "";
                    Text2.text = "";
                    Text3.text = "";
                    Text4.text = "";
                    resultjedwad.result = "";
                    /*Debug.Log("equal");*/
                    levelcompletescreen1.SetActive(true);
                    yield return new WaitForSeconds(2);
                    levelcompletescreen1.SetActive(false);
                }
                else
                {
                    resultpage1.SetActive(false);
                    resulttext1.text = "";
                    answer_status.answer1.Clear();
                    Text1.text = "";
                    Text2.text = "";
                    Text3.text = "";
                    Text4.text = "";
                    resultjedwad.result = "";
                    /*Debug.Log("not equal");*/
                }
            }
        }
        if (thispagenum == 2)
        {
            if (answer_status.answer2.Contains("4"))
            {
                resultpage2.SetActive(true);
                resulttext2.text = "error";
                yield return new WaitForSeconds(3);
                resultpage2.SetActive(false);
                answer_status.answer2.Clear();
                Text21.text = "";
                Text22.text = "";
                Text23.text = "";
                Text24.text = "";
                resultjedwad.result2 = "";
            }
            else
            {
                resultpage2.SetActive(true);
                resulttext2.text = resultjedwad.result2;
                yield return new WaitForSeconds(3);
                foreach (string item in answer2check2)
                {
                    /*Debug.Log(item);*/
                }
                bool isEqual1 = answer_status.answer2.SequenceEqual(answer2check1);
                bool isEqual2 = answer_status.answer2.SequenceEqual(answer2check2);
                /*Debug.Log(isEqual);*/
                foreach (string item in answer_status.answer2)
                {
                    Debug.Log(item);
                }
                if (isEqual1|| isEqual2)
                {
                    page2.SetActive(false);
                    resulttext2.text = "";
                    answer_status.answer2.Clear();
                    Text21.text = "";
                    Text22.text = "";
                    Text23.text = "";
                    Text24.text = "";
                    resultjedwad.result2 = "";
                    /*Debug.Log("equal");*/
                    levelcompletescreen2.SetActive(true);
                    yield return new WaitForSeconds(2);
                    levelcompletescreen2.SetActive(false);
                }
                else
                {
                    resultpage2.SetActive(false);
                    resulttext2.text = "";
                    answer_status.answer2.Clear();
                    Text21.text = "";
                    Text22.text = "";
                    Text23.text = "";
                    Text24.text = "";
                    resultjedwad.result2 = "";
                    /*Debug.Log("not equal");*/
                }
            }
        }
        if (thispagenum == 3)
        {
            if (answer_status.answer3.Contains("4"))
            {
                resultpage3.SetActive(true);
                resulttext3.text = "error";
                yield return new WaitForSeconds(3);
                resultpage3.SetActive(false);
                answer_status.answer3.Clear();
                Text31.text = "";
                Text32.text = "";
                Text33.text = "";
                Text34.text = "";
                resultjedwad.result3 = "";
            }
            else
            {
                resultpage3.SetActive(true);
                resulttext3.text = resultjedwad.result3;
                yield return new WaitForSeconds(3);
                foreach (string item in answer3check)
                {
                    /*Debug.Log(item);*/
                }
                bool isEqual = answer_status.answer3.SequenceEqual(answer3check);
                /*Debug.Log(isEqual);*/
                foreach (string item in answer_status.answer3)
                {
                    Debug.Log(item);
                }
                if (isEqual)
                {
                    page3.SetActive(false);
                    resulttext3.text = "";
                    answer_status.answer3.Clear();
                    Text31.text = "";
                    Text32.text = "";
                    Text33.text = "";
                    Text34.text = "";
                    resultjedwad.result3 = "";
                    /*Debug.Log("equal");*/
                    levelcompletescreen3.SetActive(true);
                    yield return new WaitForSeconds(2);
                    levelcompletescreen3.SetActive(false);
                }
                else
                {
                    resultpage3.SetActive(false);
                    resulttext3.text = "";
                    answer_status.answer3.Clear();
                    Text31.text = "";
                    Text32.text = "";
                    Text33.text = "";
                    Text34.text = "";
                    resultjedwad.result3 = "";
                    /*Debug.Log("not equal");*/
                }
            }
        }
    }
}

