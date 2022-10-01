using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class clear : MonoBehaviour
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
    public void avakadabra(int pagenum)
    {
        if(pagenum == 1)
        {
            answer_status.answer1.Clear();
            Text1.text = "";
            Text2.text = "";
            Text3.text = "";
            Text4.text = "";
            resultjedwad.result="";
        }
        if (pagenum == 2)
        {
            answer_status.answer2.Clear();
            Text21.text = "";
            Text22.text = "";
            Text23.text = "";
            Text24.text = "";
            resultjedwad.result2="";
        }
        if (pagenum == 3)
        {
            answer_status.answer3.Clear();
            Text31.text = "";
            Text32.text = "";
            Text33.text = "";
            Text34.text = "";
            resultjedwad.result3="";
        }
    }
}
