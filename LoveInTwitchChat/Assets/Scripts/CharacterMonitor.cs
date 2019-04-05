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

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        BuildPositive();
        BuildNegative();
        positiveOpinion = 0;
        negativeOpinion = 0;
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
    }

    void BuildNegative()
    {
        negativeLocation = new List<string>();
        negativeLocation.Add("Mall");
    }
}
