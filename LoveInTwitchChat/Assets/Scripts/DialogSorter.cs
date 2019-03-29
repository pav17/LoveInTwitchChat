using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogSorter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<string[]> basicQuestions = new List<string[]>();
        List<string[]> highQuestions = new List<string[]>();
        List<string[]> lowQuestions = new List<string[]>();

        basicQuestions = BuildBasicQuestions(basicQuestions);
    }

    
    public List<string[]> BuildBasicQuestions(List<string[]> basicQuestions)
    {
        string[] question1 = new string[3];
        question1[0] = ""
        basicQuestions.Add();
        return (basicQuestions);
    }

    public void QuestionPicker()
    {

    }
}
