using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMonitor : MonoBehaviour
{

    public static CharacterMonitor cm;

    List<string> positiveLocation;
    List<string> negativeLocation;

    int positiveOpinion;
    int negativeOpinion;

    void Awake()
    {
        if (cm == null)
        {
            DontDestroyOnLoad(gameObject); 
            cm = this;
        }
        else if (cm != this)
        {
            Destroy(gameObject); 
        }
    }

    void Start()
    {
        BuildPositive();
        BuildNegative();
        Global.global.positiveOpinion = 0;
        Global.global.negativeOpinion = 0;
    }

    public void PositiveOpinionChange(int choice)
    {
        if (choice == 1)
        {
            Global.global.positiveOpinion = Global.global.positiveOpinion + 5;
        }
        else if (choice == 2)
        {
            Global.global.positiveOpinion = Global.global.positiveOpinion + 2;
        }
        else if (choice == 3)
        {
            Global.global.positiveOpinion = Global.global.positiveOpinion - 5;
        }
    }

    public void NegativeOpinionChange(int choice)
    {
        if (choice == 1)
        {
            Global.global.negativeOpinion = Global.global.negativeOpinion - 5;
        }
        else if (choice == 2)
        {
            Global.global.negativeOpinion = Global.global.negativeOpinion - 2;
        }
        else if (choice == 3)
        {
            Global.global.negativeOpinion = Global.global.negativeOpinion + 5;
        }
    }

    public string GetPositiveLocation(int index)
    {
        return (positiveLocation[index]);
    }

    public string GetNegativeLocation(int index)
    {
        return (negativeLocation[index]);
    }

    void BuildPositive()
    {
        positiveLocation = new List<string>();
        positiveLocation.Add("Cafe");
        positiveLocation.Add("Park");
        positiveLocation.Add("Mall");
        positiveLocation.Add("Park");
        positiveLocation.Add("Cafe");
        positiveLocation.Add("Park");
        positiveLocation.Add("Mall");
        positiveLocation.Add("Cafe");
        positiveLocation.Add("Mall");
    }

    void BuildNegative()
    {
        negativeLocation = new List<string>();
        negativeLocation.Add("Mall");
    }
}
