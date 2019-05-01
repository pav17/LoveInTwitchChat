using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public Text usernamePlaceholder;
    public Text username;
    public Text pollTimer;
    public Text pollPlaceholder;

    void Start()
    {
        pollPlaceholder.text = Global.global.pollTimer.ToString();
    }
    void Update()
    {
        if (Global.global.twitchName != "")
        {
            usernamePlaceholder.text = Global.global.twitchName;
        }
        else
        {
            usernamePlaceholder.text = "Twitch Username";
        }
    }

    public void OnUsernameChange()
    {
        if (username.text != "")
        {
            Global.global.twitchName = username.text;
        }
        if (pollTimer.text != "")
        {
            Global.global.pollTimer = float.Parse(pollTimer.text);
        }
    }
}
