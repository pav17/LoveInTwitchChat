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

    public int parkVisits;
    public int cafeVisits;
    public int mallVisits;

    public string twitchName = "sulu244";
}
