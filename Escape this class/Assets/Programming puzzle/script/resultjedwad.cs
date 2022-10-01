using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class resultjedwad : MonoBehaviour
{
    public static string result;
    public static string result2;
    public static string result3;
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
    public GameObject functionpad1;
    public GameObject functionpad2;
    public GameObject functionpad3;
    public GameObject errorpage;
    public void button1_r(string check)
    {
        if (answer_status.answer1.Count > 3)
        {
            StartCoroutine(counterror_r());
        }
        else
        {
            if (answer_status.answer1.Count == 0)
            {
                if (check == "a")
                {
                    functionpad1.SetActive(false);
                    Text1.text = "    Print(\"Hello\")";
                    result += "Hello" + "\n";
                    answer_status.answer1.Add("a");
                }
                if (check == "b")
                {
                    functionpad1.SetActive(false);
                    Text1.text = "    Print(\"World\")";
                    result += "World" + "\n";
                    answer_status.answer1.Add("b");
                }
                if (check == "c")
                {
                    functionpad1.SetActive(false);
                    answer_status.answer1.Add("c");
                    Text1.text = "Print(i)";
                }
            }
            else if (answer_status.answer1.Count == 1)
            {
                if (check == "a")
                {
                    functionpad1.SetActive(false);
                    Text2.text = "    Print(\"Hello\")";
                    answer_status.answer1.Add("a");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result += "Hello" + "\n";
                    }
                }
                if (check == "b")
                {
                    functionpad1.SetActive(false);
                    Text2.text = "    Print(\"World\")";
                    answer_status.answer1.Add("b");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result += "Hello" + "\n";
                    }
                }
                if (check == "c")
                {
                    functionpad1.SetActive(false);
                    Text2.text = "    Print(i)";
                    answer_status.answer1.Add("c");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result += i + "\n";
                    }
                }

            }
            else if (answer_status.answer1.Count == 2)
            {
                if (check == "a")
                {
                    functionpad1.SetActive(false);
                    Text3.text = "    Print(\"Hello\")";
                    answer_status.answer1.Add("a");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result += "Hello" + "\n";
                    }

                }
                if (check == "b")
                {
                    functionpad1.SetActive(false);
                    Text3.text = "    Print(\"World\")";
                    answer_status.answer1.Add("b");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result += "World" + "\n";
                    }
                }
                if (check == "c")
                {
                    functionpad1.SetActive(false);
                    Text3.text = "    Print(i)";
                    answer_status.answer1.Add("c");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result += i + "\n";
                    }
                }
            }
            else if (answer_status.answer1.Count == 3)
            {
                if (check == "a")
                {
                    functionpad1.SetActive(false);
                    Text4.text = "    Print(\"Hello\")";
                    answer_status.answer1.Add("a");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result += "Hello" + "\n";
                    }

                }
                if (check == "b")
                {
                    functionpad1.SetActive(false);
                    Text4.text = "    Print(\"World\")";
                    answer_status.answer1.Add("b");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result += "World" + "\n";
                    }
                }
                if (check == "c")
                {
                    functionpad1.SetActive(false);
                    Text4.text = "    Print(i)";
                    answer_status.answer1.Add("c");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result += i + "\n";
                    }
                }
            }

        }
    }
    public void button2_r(string check)
    {
        if (answer_status.answer2.Count > 3)
        {
            StartCoroutine(counterror_r());
        }
        else
        {
            if (answer_status.answer2.Count == 0)
            {
                if (check == "a")
                {
                    functionpad2.SetActive(false);
                    Text21.text = "    Print(\"Hello\")";
                    result2 += "Hello" + "\n";
                    answer_status.answer2.Add("a");
                }
                if (check == "b")
                {
                    functionpad2.SetActive(false);
                    Text21.text = "    Print(\"World\")";
                    result2 += "World" + "\n";
                    answer_status.answer2.Add("b");
                }
                if (check == "c")
                {
                    functionpad2.SetActive(false);
                    answer_status.answer2.Add("c");
                    Text21.text = "Print(i)";
                }
            }
            else if (answer_status.answer2.Count == 1)
            {
                if (check == "a")
                {
                    functionpad2.SetActive(false);
                    Text22.text = "    Print(\"Hello\")";
                    answer_status.answer2.Add("a");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result2 += "Hello" + "\n";
                    }
                }
                if (check == "b")
                {
                    functionpad2.SetActive(false);
                    Text22.text = "    Print(\"World\")";
                    answer_status.answer2.Add("b");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result2 += "Hello" + "\n";
                    }
                }
                if (check == "c")
                {
                    functionpad2.SetActive(false);
                    Text22.text = "    Print(i)";
                    answer_status.answer2.Add("c");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result2 += i + "\n";
                    }
                }

            }
            else if (answer_status.answer2.Count == 2)
            {
                if (check == "a")
                {
                    functionpad2.SetActive(false);
                    Text23.text = "    Print(\"Hello\")";
                    answer_status.answer2.Add("a");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result2 += "Hello" + "\n";
                    }

                }
                if (check == "b")
                {
                    functionpad2.SetActive(false);
                    Text23.text = "    Print(\"World\")";
                    answer_status.answer2.Add("b");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result2 += "World" + "\n";
                    }
                }
                if (check == "c")
                {
                    functionpad2.SetActive(false);
                    Text23.text = "    Print(i)";
                    answer_status.answer2.Add("c");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result2 += i + "\n";
                    }
                }
            }
            else if (answer_status.answer2.Count == 3)
            {
                if (check == "a")
                {
                    functionpad2.SetActive(false);
                    Text24.text = "    Print(\"Hello\")";
                    answer_status.answer2.Add("a");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result2 += "Hello" + "\n";
                    }

                }
                if (check == "b")
                {
                    functionpad2.SetActive(false);
                    Text24.text = "    Print(\"World\")";
                    answer_status.answer2.Add("b");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result2 += "World" + "\n";
                    }
                }
                if (check == "c")
                {
                    functionpad2.SetActive(false);
                    Text24.text = "    Print(i)";
                    answer_status.answer2.Add("c");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result2 += i + "\n";
                    }
                }
            }

        }
    }
    public void button3_r(string check)
    {
        if (answer_status.answer3.Count > 3)
        {
            StartCoroutine(counterror_r());
        }
        else
        {
            if (answer_status.answer3.Count == 0)
            {
                if (check == "a")
                {
                    functionpad3.SetActive(false);
                    Text31.text = "    Print(\"Hello\")";
                    result3 += "Hello" + "\n";
                    answer_status.answer3.Add("a");
                }
                if (check == "b")
                {
                    functionpad3.SetActive(false);
                    Text31.text = "    Print(\"World\")";
                    result3 += "World" + "\n";
                    answer_status.answer3.Add("b");
                }
                if (check == "c")
                {
                    functionpad3.SetActive(false);
                    answer_status.answer3.Add("c");
                    Text31.text = "Print(i)";
                }
            }
            else if (answer_status.answer3.Count == 1)
            {
                if (check == "a")
                {
                    functionpad3.SetActive(false);
                    Text32.text = "    Print(\"Hello\")";
                    answer_status.answer3.Add("a");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result3 += "Hello" + "\n";
                    }
                }
                if (check == "b")
                {
                    functionpad3.SetActive(false);
                    Text32.text = "    Print(\"World\")";
                    answer_status.answer3.Add("b");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result3 += "Hello" + "\n";
                    }
                }
                if (check == "c")
                {
                    functionpad3.SetActive(false);
                    Text32.text = "    Print(i)";
                    answer_status.answer3.Add("c");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result3 += i + "\n";
                    }
                }

            }
            else if (answer_status.answer3.Count == 2)
            {
                if (check == "a")
                {
                    functionpad3.SetActive(false);
                    Text33.text = "    Print(\"Hello\")";
                    answer_status.answer3.Add("a");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result3 += "Hello" + "\n";
                    }

                }
                if (check == "b")
                {
                    functionpad3.SetActive(false);
                    Text33.text = "    Print(\"World\")";
                    answer_status.answer3.Add("b");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result3 += "World" + "\n";
                    }
                }
                if (check == "c")
                {
                    functionpad3.SetActive(false);
                    Text33.text = "    Print(i)";
                    answer_status.answer3.Add("c");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result3 += i + "\n";
                    }
                }
            }
            else if (answer_status.answer3.Count == 3)
            {
                if (check == "a")
                {
                    functionpad3.SetActive(false);
                    Text34.text = "    Print(\"Hello\")";
                    answer_status.answer3.Add("a");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result3 += "Hello" + "\n";
                    }

                }
                if (check == "b")
                {
                    functionpad3.SetActive(false);
                    Text34.text = "    Print(\"World\")";
                    answer_status.answer3.Add("b");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result3 += "World" + "\n";
                    }
                }
                if (check == "c")
                {
                    functionpad3.SetActive(false);
                    Text34.text = "    Print(i)";
                    answer_status.answer3.Add("c");
                    for (int i = 0; i < numpad.n; i++)
                    {
                        result3 += i + "\n";
                    }
                }
            }

        }
    }
    IEnumerator counterror_r()
    {
        errorpage.SetActive(true);
        yield return new WaitForSeconds(1);
        errorpage.SetActive(false);
    }
}

