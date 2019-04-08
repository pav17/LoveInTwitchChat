using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    public static Global global;

    void Awake()
    {
        if (global == null)
        {
            DontDestroyOnLoad(gameObject); //makes global persist across scenes
            global = this;
        }
        else if (global != this)
        {
            Destroy(gameObject); //deletes copies of global which do not need to exist, so right version is used to get info from
        }
    }

    public int playTime;               //The number of cycles the player has to woo their date.
    public int currentDay;             //The current cycle the player is on.

    public bool pollStatus;
    public float pollTimer;
    public int pollChoice1;
    public int pollChoice2;
    public int pollChoice3;

    public int parkVisits;
    public int cafeVisits;
    public int mallVisits;

    public int positiveOpinion;
    public int negativeOpinion;

    public int positiveInteractions = 0;
    public int negativeInteractions = 0;

    public string twitchName = "Cruiser_Ooi";
}
