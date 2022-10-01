using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class numpad : MonoBehaviour
{
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
    public GameObject functionpad_1;
    public GameObject functionpad_2;
    public GameObject functionpad_3;
    public GameObject numpadpage1;
    public GameObject numpadpage2;
    public GameObject numpadpage3;
    public static int n;
    public static string for_i_in_x;
    public void numbpad1(string number)
    {
        if (answer_status.answer1.Count == 0)
        {
            if (number == "1")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("5");
                n = 1;
                Text1.text = "for i in range(" +number+ ")";
            }
            if (number == "2")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("6");
                n = 2;
                Text1.text = "for i in range(" +number+ ")";
            }
            if (number == "3")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("7");
                n = 3;
                Text1.text = "for i in range(" +number+ ")";
            }
            if (number == "4")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("8");
                n = 4;
                Text1.text = "for i in range(" +number+ ")";
            }
            if (number == "5")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("9");
                n = 5;
                Text1.text = "for i in range(" +number+ ")";
            }
            if (number == "6")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("10");
                n = 6;
                Text1.text = "for i in range(" +number+ ")";
            }
            if (number == "7")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("11");
                n = 7;
                Text1.text = "for i in range(" +number+ ")";
            }
            if (number == "8")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("12");
                n = 8;
                Text1.text = "for i in range(" +number+ ")";
            }
            if (number == "9")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("13");
                n = 9;
                Text1.text = "for i in range(" +number+ ")";
            }
        }
        else if (answer_status.answer1.Count == 1)
        {
            if (number == "1")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("5");
                n = 1;
                Text2.text = "for i in range(" +number+ ")";
            }
            if (number == "2")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("6");
                n = 2;
                Text2.text = "for i in range(" +number+ ")";
            }
            if (number == "3")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("7");
                n = 3;
                Text2.text = "for i in range(" +number+ ")";
            }
            if (number == "4")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("8");
                n = 4;
                Text2.text = "for i in range(" +number+ ")";
            }
            if (number == "5")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("9");
                n = 5;
                Text2.text = "for i in range(" +number+ ")";
            }
            if (number == "6")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("10");
                n = 6;
                Text2.text = "for i in range(" +number+ ")";
            }
            if (number == "7")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("11");
                n = 7;
                Text2.text = "for i in range(" +number+ ")";
            }
            if (number == "8")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("12");
                n = 8;
                Text2.text = "for i in range(" +number+ ")";
            }
            if (number == "9")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("13");
                n = 9;
                Text2.text = "for i in range(" +number+ ")";
            }
        }
        else if (answer_status.answer1.Count == 2)
        {
            if (number == "1")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("5");
                n = 1;
                Text3.text = "for i in range(" +number+ ")";
            }
            if (number == "2")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("6");
                n = 2;
                Text3.text = "for i in range(" +number+ ")";
            }
            if (number == "3")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("7");
                n = 3;
                Text3.text = "for i in range(" +number+ ")";
            }
            if (number == "4")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("8");
                n = 4;
                Text3.text = "for i in range(" +number+ ")";
            }
            if (number == "5")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("9");
                n = 5;
                Text3.text = "for i in range(" +number+ ")";
            }
            if (number == "6")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("10");
                n = 6;
                Text3.text = "for i in range(" +number+ ")";
            }
            if (number == "7")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("11");
                n = 7;
                Text3.text = "for i in range(" +number+ ")";
            }
            if (number == "8")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("12");
                Text3.text = "for i in range(" +number+ ")";
            }
            if (number == "9")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("13");
                n = 8;
                Text3.text = "for i in range(" +number+ ")";
            }
        }
        else if (answer_status.answer1.Count == 3)
        {
            if (number == "1")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("5");
                n = 1;
                Text4.text = "for i in range(" +number+ ")";
            }
            if (number == "2")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("6");
                n = 2;
                Text4.text = "for i in range(" +number+ ")";
            }
            if (number == "3")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("7");
                n = 3;
                Text4.text = "for i in range(" +number+ ")";
            }
            if (number == "4")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("8");
                n = 4;
                Text4.text = "for i in range(" +number+ ")";
            }
            if (number == "5")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("9");
                n = 5;
                Text4.text = "for i in range(" +number+ ")";
            }
            if (number == "6")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("10");
                n = 6;
                Text4.text = "for i in range(" +number+ ")";
            }
            if (number == "7")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("11");
                n = 7;
                Text4.text = "for i in range(" +number+ ")";
            }
            if (number == "8")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("12");
                n = 8;
                Text4.text = "for i in range(" +number+ ")";
            }
            if (number == "9")
            {
                numpadpage1.SetActive(false);
                functionpad_1.SetActive(true);
                answer_status.answer1.Add("13");
                n = 9;
                Text4.text = "for i in range(" +number+ ")";
            }
        }
    }
    public void numbpad2(string number)
    {
        if (answer_status.answer2.Count == 0)
        {
            if (number == "1")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("5");
                n = 1;
                Text21.text = "for i in range(" + number + ")";
            }
            if (number == "2")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("6");
                n = 2;
                Text21.text = "for i in range(" + number + ")";
            }
            if (number == "3")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("7");
                n = 3;
                Text21.text = "for i in range(" + number + ")";
            }
            if (number == "4")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("8");
                n = 4;
                Text21.text = "for i in range(" + number + ")";
            }
            if (number == "5")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("9");
                n = 5;
                Text21.text = "for i in range(" + number + ")";
            }
            if (number == "6")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("10");
                n = 6;
                Text21.text = "for i in range(" + number + ")";
            }
            if (number == "7")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("11");
                n = 7;
                Text21.text = "for i in range(" + number + ")";
            }
            if (number == "8")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("12");
                n = 8;
                Text21.text = "for i in range(" + number + ")";
            }
            if (number == "9")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("13");
                n = 9;
                Text21.text = "for i in range(" + number + ")";
            }
        }
        else if (answer_status.answer2.Count == 1)
        {
            if (number == "1")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("5");
                n = 1;
                Text22.text = "for i in range(" + number + ")";
            }
            if (number == "2")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("6");
                n = 2;
                Text22.text = "for i in range(" + number + ")";
            }
            if (number == "3")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("7");
                n = 3;
                Text22.text = "for i in range(" + number + ")";
            }
            if (number == "4")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("8");
                n = 4;
                Text22.text = "for i in range(" + number + ")";
            }
            if (number == "5")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("9");
                n = 5;
                Text22.text = "for i in range(" + number + ")";
            }
            if (number == "6")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("10");
                n = 6;
                Text22.text = "for i in range(" + number + ")";
            }
            if (number == "7")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("11");
                n = 7;
                Text22.text = "for i in range(" + number + ")";
            }
            if (number == "8")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("12");
                n = 8;
                Text22.text = "for i in range(" + number + ")";
            }
            if (number == "9")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("13");
                n = 9;
                Text22.text = "for i in range(" + number + ")";
            }
        }
        else if (answer_status.answer2.Count == 2)
        {
            if (number == "1")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("5");
                n = 1;
                Text23.text = "for i in range(" + number + ")";
            }
            if (number == "2")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("6");
                n = 2;
                Text23.text = "for i in range(" + number + ")";
            }
            if (number == "3")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("7");
                n = 3;
                Text23.text = "for i in range(" + number + ")";
            }
            if (number == "4")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("8");
                n = 4;
                Text23.text = "for i in range(" + number + ")";
            }
            if (number == "5")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("9");
                n = 5;
                Text23.text = "for i in range(" + number + ")";
            }
            if (number == "6")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("10");
                n = 6;
                Text23.text = "for i in range(" + number + ")";
            }
            if (number == "7")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("11");
                n = 7;
                Text23.text = "for i in range(" + number + ")";
            }
            if (number == "8")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("12");
                n = 8;
                Text23.text = "for i in range(" + number + ")";
            }
            if (number == "9")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("13");
                n = 9;
                Text23.text = "for i in range(" + number + ")";
            }
        }
        else if (answer_status.answer2.Count == 3)
        {
            if (number == "1")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("5");
                n = 1;
                Text24.text = "for i in range(" + number + ")";
            }
            if (number == "2")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("6");
                n = 2;
                Text24.text = "for i in range(" + number + ")";
            }
            if (number == "3")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("7");
                n = 3;
                Text24.text = "for i in range(" + number + ")";
            }
            if (number == "4")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("8");
                n = 4;
                Text24.text = "for i in range(" + number + ")";
            }
            if (number == "5")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("9");
                n = 5;
                Text24.text = "for i in range(" + number + ")";
            }
            if (number == "6")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("10");
                n = 6;
                Text24.text = "for i in range(" + number + ")";
            }
            if (number == "7")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("11");
                n = 7;
                Text24.text = "for i in range(" + number + ")";
            }
            if (number == "8")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("12");
                n = 8;
                Text24.text = "for i in range(" + number + ")";
            }
            if (number == "9")
            {
                numpadpage2.SetActive(false);
                functionpad_2.SetActive(true);
                answer_status.answer2.Add("13");
                n = 9;
                Text4.text = "for i in range(" + number + ")";
            }
        }
    }
    public void numbpad3(string number)
    {
        if (answer_status.answer3.Count == 0)
        {
            if (number == "1")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("5");
                n = 1;
                Text31.text = "for i in range(" + number + ")";
            }
            if (number == "2")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("6");
                n = 2;
                Text31.text = "for i in range(" + number + ")";
            }
            if (number == "3")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("7");
                n = 3;
                Text31.text = "for i in range(" + number + ")";
            }
            if (number == "4")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("8");
                n = 4;
                Text31.text = "for i in range(" + number + ")";
            }
            if (number == "5")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("9");
                n = 5;
                Text31.text = "for i in range(" + number + ")";
            }
            if (number == "6")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("10");
                n = 6;
                Text31.text = "for i in range(" + number + ")";
            }
            if (number == "7")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("11");
                n = 7;
                Text31.text = "for i in range(" + number + ")";
            }
            if (number == "8")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("12");
                n = 8;
                Text31.text = "for i in range(" + number + ")";
            }
            if (number == "9")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("13");
                n = 9;
                Text31.text = "for i in range(" + number + ")";
            }
        }
        else if (answer_status.answer3.Count == 1)
        {
            if (number == "1")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("5");
                n = 1;
                Text32.text = "for i in range(" + number + ")";
            }
            if (number == "2")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("6");
                n = 2;
                Text32.text = "for i in range(" + number + ")";
            }
            if (number == "3")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("7");
                n = 3;
                Text32.text = "for i in range(" + number + ")";
            }
            if (number == "4")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("8");
                n = 4;
                Text32.text = "for i in range(" + number + ")";
            }
            if (number == "5")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("9");
                n = 5;
                Text32.text = "for i in range(" + number + ")";
            }
            if (number == "6")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("10");
                n = 6;
                Text32.text = "for i in range(" + number + ")";
            }
            if (number == "7")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("11");
                n = 7;
                Text32.text = "for i in range(" + number + ")";
            }
            if (number == "8")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("12");
                n = 8;
                Text32.text = "for i in range(" + number + ")";
            }
            if (number == "9")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("13");
                n = 9;
                Text32.text = "for i in range(" + number + ")";
            }
        }
        else if (answer_status.answer3.Count == 2)
        {
            if (number == "1")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("5");
                n = 1;
                Text33.text = "for i in range(" + number + ")";
            }
            if (number == "2")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("6");
                n = 2;
                Text33.text = "for i in range(" + number + ")";
            }
            if (number == "3")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("7");
                n = 3;
                Text33.text = "for i in range(" + number + ")";
            }
            if (number == "4")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("8");
                n = 4;
                Text33.text = "for i in range(" + number + ")";
            }
            if (number == "5")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("9");
                n = 5;
                Text33.text = "for i in range(" + number + ")";
            }
            if (number == "6")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("10");
                n = 6;
                Text33.text = "for i in range(" + number + ")";
            }
            if (number == "7")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("11");
                n = 7;
                Text33.text = "for i in range(" + number + ")";
            }
            if (number == "8")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("12");
                n = 8;
                Text33.text = "for i in range(" + number + ")";
            }
            if (number == "9")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("13");
                n = 9;
                Text33.text = "for i in range(" + number + ")";
            }
        }
        else if (answer_status.answer3.Count == 3)
        {
            if (number == "1")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("5");
                n = 1;
                Text34.text = "for i in range(" + number + ")";
            }
            if (number == "2")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("6");
                n = 2;
                Text34.text = "for i in range(" + number + ")";
            }
            if (number == "3")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("7");
                n = 3;
                Text34.text = "for i in range(" + number + ")";
            }
            if (number == "4")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("8");
                n = 4;
                Text34.text = "for i in range(" + number + ")";
            }
            if (number == "5")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("9");
                n = 5;
                Text34.text = "for i in range(" + number + ")";
            }
            if (number == "6")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("10");
                n = 6;
                Text34.text = "for i in range(" + number + ")";
            }
            if (number == "7")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("11");
                n = 7;
                Text34.text = "for i in range(" + number + ")";
            }
            if (number == "8")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("12");
                n = 8;
                Text34.text = "for i in range(" + number + ")";
            }
            if (number == "9")
            {
                numpadpage3.SetActive(false);
                functionpad_3.SetActive(true);
                answer_status.answer3.Add("13");
                n = 9;
                Text34.text = "for i in range(" + number + ")";
            }
        }
    }
}