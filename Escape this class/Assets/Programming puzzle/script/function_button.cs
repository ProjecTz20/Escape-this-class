using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class function_button : MonoBehaviour
{
    public GameObject errorpage;
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
    public GameObject numpadpage1;
    public GameObject numpadpage2;
    public GameObject numpadpage3;
    public void button1(string check)
    {
        if (answer_status.answer1.Count > 3)
        {
            StartCoroutine(counterror());
        }
        else
        {
            if (answer_status.answer1.Count == 0)
            {
                Text1.text = " ";
                Text2.text = " ";
                Text4.text = " ";
                if (check == "1")
                {
                    answer_status.answer1.Add(check);
                    Text1.text = "Print(\"Hello\")";
                    resultjedwad.result += "Hello"+"\n";
                }
                if (check == "2")
                {
                    answer_status.answer1.Add(check);
                    Text1.text = "Print(\"World\")";
                    resultjedwad.result += "World" + "\n";
                }
                if (check == "3")
                {
                    numpadpage1.SetActive(true);
                }
                if (check == "4")
                {
                    answer_status.answer1.Add(check);
                    Text1.text = "Print(i)";
                    resultjedwad.result = "error";
                }

            }
            else if (answer_status.answer1.Count == 1)
            {
                if (check == "1")
                {
                    answer_status.answer1.Add(check);
                    Text2.text = "Print(\"Hello\")";
                    resultjedwad.result += "Hello" + "\n";
                }
                if (check == "2")
                {
                    answer_status.answer1.Add(check);
                    Text2.text = "Print(\"World\")";
                    resultjedwad.result += "World" + "\n";
                }
                if (check == "3")
                {
                    numpadpage1.SetActive(true);
                }
                if (check == "4")
                {
                    answer_status.answer1.Add(check);
                    Text2.text = "Print(i)";
                    resultjedwad.result = "error";
                }

            }
            else if (answer_status.answer1.Count == 2)
            {
                if (check == "1")
                {
                    answer_status.answer1.Add(check);
                    Text3.text = "Print(\"Hello\")";
                    resultjedwad.result += "Hello" + "\n";
                }
                if (check == "2")
                {
                    answer_status.answer1.Add(check);
                    Text3.text = "Print(\"World\")";
                    resultjedwad.result += "World" + "\n";
                }
                if (check == "3")
                {
                    numpadpage1.SetActive(true);
                }
                if (check == "4")
                {
                    answer_status.answer1.Add(check);
                    Text3.text = "Print(i)";
                    resultjedwad.result = "error";
                }
            }
            else if (answer_status.answer1.Count == 3)
            {
                if (check == "1")
                {
                    answer_status.answer1.Add(check);
                    Text4.text = "Print(\"Hello\")";
                    resultjedwad.result += "Hello" + "\n";
                }
                if (check == "2")
                {
                    answer_status.answer1.Add(check);
                    Text4.text = "Print(\"World\")";
                    resultjedwad.result += "World" + "\n";
                }
                if (check == "3")
                {
                    numpadpage1.SetActive(true);
                }
                if (check == "4")
                {
                    answer_status.answer1.Add(check);
                    Text4.text = "Print(i)";
                    resultjedwad.result = "error";
                }
            }
        }
    }
    public void button2(string check2)
    {
        if (answer_status.answer2.Count > 3)
        {
            StartCoroutine(counterror());
        }
        else
        {
            if (answer_status.answer2.Count == 0)
            {
                Text21.text = " ";
                Text22.text = " ";
                Text24.text = " ";
                if (check2 == "1")
                {
                    answer_status.answer2.Add(check2);
                    Text21.text = "Print(\"Hello\")";
                    resultjedwad.result2 += "Hello" + "\n";
                }
                if (check2 == "2")
                {
                    answer_status.answer2.Add(check2);
                    Text21.text = "Print(\"World\")";
                    resultjedwad.result2 += "World" + "\n";
                }
                if (check2 == "3")
                {
                    numpadpage2.SetActive(true);
                }
                if (check2 == "4")
                {
                    answer_status.answer2.Add(check2);
                    Text21.text = "Print(i)";
                    resultjedwad.result2 = "error";
                }

            }
            else if (answer_status.answer2.Count == 1)
            {
                if (check2 == "1")
                {
                    answer_status.answer2.Add(check2);
                    Text22.text = "Print(\"Hello\")";
                    resultjedwad.result2 += "Hello" + "\n";
                }
                if (check2 == "2")
                {
                    answer_status.answer2.Add(check2);
                    Text22.text = "Print(\"World\")";
                    resultjedwad.result2 += "World" + "\n";
                }
                if (check2 == "3")
                {
                    numpadpage2.SetActive(true);
                }
                if (check2 == "4")
                {
                    answer_status.answer2.Add(check2);
                    Text22.text = "Print(i)";
                    resultjedwad.result2 = "error";
                }

            }
            else if (answer_status.answer2.Count == 2)
            {
                if (check2 == "1")
                {
                    answer_status.answer2.Add(check2);
                    Text23.text = "Print(\"Hello\")";
                    resultjedwad.result2 += "Hello" + "\n";
                }
                if (check2 == "2")
                {
                    answer_status.answer2.Add(check2);
                    Text23.text = "Print(\"World\")";
                    resultjedwad.result2 += "World" + "\n";
                }
                if (check2 == "3")
                {
                    numpadpage2.SetActive(true);
                }
                if (check2 == "4")
                {
                    answer_status.answer2.Add(check2);
                    Text23.text = "Print(i)";
                    resultjedwad.result2 = "error";
                }
            }
            else if (answer_status.answer2.Count == 3)
            {
                if (check2 == "1")
                {
                    answer_status.answer2.Add(check2);
                    Text24.text = "Print(\"Hello\")";
                    resultjedwad.result2 += "Hello" + "\n";
                }
                if (check2 == "2")
                {
                    answer_status.answer2.Add(check2);
                    Text24.text = "Print(\"World\")";
                    resultjedwad.result2 += "World" + "\n";
                }
                if (check2 == "3")
                {
                    numpadpage2.SetActive(true);
                }
                if (check2 == "4")
                {
                    answer_status.answer2.Add(check2);
                    Text24.text = "Print(i)";
                    resultjedwad.result2 = "error";
                }
            }
        }
    }
    public void button3(string check3)
    {
        if (answer_status.answer3.Count > 3)
        {
            StartCoroutine(counterror());
        }
        else
        {
            if (answer_status.answer2.Count == 0)
            {
                Text31.text = " ";
                Text32.text = " ";
                Text34.text = " ";
                if (check3 == "1")
                {
                    answer_status.answer2.Add(check3);
                    Text31.text = "Print(\"Hello\")";
                    resultjedwad.result3 += "Hello" + "\n";
                }
                if (check3 == "2")
                {
                    answer_status.answer2.Add(check3);
                    Text31.text = "Print(\"World\")";
                    resultjedwad.result3 += "World" + "\n";
                }
                if (check3 == "3")
                {
                    numpadpage3.SetActive(true);
                }
                if (check3 == "4")
                {
                    answer_status.answer2.Add(check3);
                    Text31.text = "Print(i)";
                    resultjedwad.result3 = "error";
                }

            }
            else if (answer_status.answer2.Count == 1)
            {
                if (check3 == "1")
                {
                    answer_status.answer2.Add(check3);
                    Text32.text = "Print(\"Hello\")";
                    resultjedwad.result3 += "Hello" + "\n";
                }
                if (check3 == "2")
                {
                    answer_status.answer2.Add(check3);
                    Text32.text = "Print(\"World\")";
                    resultjedwad.result3 += "World" + "\n";
                }
                if (check3 == "3")
                {
                    numpadpage3.SetActive(true);
                }
                if (check3 == "4")
                {
                    answer_status.answer2.Add(check3);
                    Text32.text = "Print(i)";
                    resultjedwad.result3 = "error";
                }

            }
            else if (answer_status.answer2.Count == 2)
            {
                if (check3 == "1")
                {
                    answer_status.answer2.Add(check3);
                    Text33.text = "Print(\"Hello\")";
                    resultjedwad.result3 += "Hello" + "\n";
                }
                if (check3 == "2")
                {
                    answer_status.answer2.Add(check3);
                    Text33.text = "Print(\"World\")";
                    resultjedwad.result3 += "World" + "\n";
                }
                if (check3 == "3")
                {
                    numpadpage3.SetActive(true);
                }
                if (check3 == "4")
                {
                    answer_status.answer2.Add(check3);
                    Text33.text = "Print(i)";
                    resultjedwad.result3 = "error";
                }
            }
            else if (answer_status.answer2.Count == 3)
            {
                if (check3 == "1")
                {
                    answer_status.answer2.Add(check3);
                    Text34.text = "Print(\"Hello\")";
                    resultjedwad.result3 += "Hello" + "\n";
                }
                if (check3 == "2")
                {
                    answer_status.answer2.Add(check3);
                    Text34.text = "Print(\"World\")";
                    resultjedwad.result3 += "World" + "\n";
                }
                if (check3 == "3")
                {
                    numpadpage3.SetActive(true);
                }
                if (check3 == "4")
                {
                    answer_status.answer2.Add(check3);
                    Text34.text = "Print(i)";
                    resultjedwad.result3 = "error";
                }
            }
        }
    }

    IEnumerator counterror()
    {
            errorpage.SetActive(true);
            yield return new WaitForSeconds(1);
            errorpage.SetActive(false);
    }
}
