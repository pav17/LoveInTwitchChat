using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogController : MonoBehaviour
{

    public Text question;
    public Text option1text;
    public Text option2text;
    public Text option3text;
    public Text option4text;

    // Start is called before the first frame update
    public void Create(string input1, string input2, string input3, string input4, string inputQuestion)
    {
        option1text.text = input1;
        option2text.text = input2;
        option3text.text = input3;
        option4text.text = input4;
        question.text = inputQuestion;
    }

    void Poll()
    {
        Global.global.pollStatus = true;
        //Poll Script
    }
}
