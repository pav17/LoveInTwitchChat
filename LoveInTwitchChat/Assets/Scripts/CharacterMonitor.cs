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
            DontDestroyOnLoad(gameObject); //makes global persist across scenes
            cm = this;
        }
        else if (cm != this)
        {
            Destroy(gameObject); //deletes copies of global which do not need to exist, so right version is used to get info from
        }
    }

    void Start()
    {
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
        positiveLocation.Add("Park");
        positiveLocation.Add("Mall");
    }

    void BuildNegative()
    {
        negativeLocation = new List<string>();
        negativeLocation.Add("Mall");
    }
}
