using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextboxController : MonoBehaviour
{

    //UI
    Text sceneDialog;
    GameObject PlayerChoice1;
    GameObject PlayerChoice2;
    GameObject PlayerChoice3;
    GameObject PollInstructions;
    GameObject PollResponse1;
    GameObject PollResponse2;
    GameObject PollResponse3;
    GameObject ExitButton;
    GameObject Cafe;
    GameObject Mall;
    GameObject Park;
    GameObject PollBackground;
    GameObject Background;

    //Buttons
    Button PlayerButton1;
    Button PlayerButton2;
    Button PlayerButton3;

    //Text Queues
    Queue<string> sceneText;
    Queue<string> responseText;

    //flags
    bool continueFlag;
    bool exitFlag;
    bool pollFlag;

    //Timers
    float pollTimer;

    void Awake()
    {
        sceneDialog = GetComponent<Text>();

        PlayerChoice1 = GameObject.Find("PlayerChoice1");
        PlayerChoice2 = GameObject.Find("PlayerChoice2");
        PlayerChoice3 = GameObject.Find("PlayerChoice3");

        PlayerButton1 = PlayerChoice1.GetComponent<Button>();
        PlayerButton2 = PlayerChoice2.GetComponent<Button>();
        PlayerButton3 = PlayerChoice3.GetComponent<Button>();

        PlayerButton1.onClick.AddListener(Poll1);
        PlayerButton2.onClick.AddListener(Poll2);
        PlayerButton3.onClick.AddListener(Poll3);

        PlayerChoice1.SetActive(false);
        PlayerChoice2.SetActive(false);
        PlayerChoice3.SetActive(false);

        PollInstructions = GameObject.Find("PollInstructions");
        PollResponse1 = GameObject.Find("PollResponse1");
        PollResponse2 = GameObject.Find("PollResponse2");
        PollResponse3 = GameObject.Find("PollResponse3");

        PollInstructions.SetActive(false);
        PollResponse1.SetActive(false);
        PollResponse2.SetActive(false);
        PollResponse3.SetActive(false);

        ExitButton = GameObject.Find("Exit");
        ExitButton.SetActive(false);

        PollBackground = GameObject.Find("PollBackground");
        PollBackground.SetActive(false);
        pollTimer = Global.global.pollTimer;

        Background = GameObject.Find("TempBackground");
    }

    void Update()
    {
        if (continueFlag)
        {
            continueFlag = false;
            string currentText = sceneText.Dequeue();
            if (currentText != "END")
            {
                sceneDialog.text = currentText;
                //Debug.Log(currentText);
            }
            else
            {
                PlayerChoice1.SetActive(true);
                PlayerChoice2.SetActive(true);
                PlayerChoice3.SetActive(true);
                //spawn player response
                PlayerChoice1.GetComponentInChildren<Text>().text = responseText.Dequeue();
                PlayerChoice2.GetComponentInChildren<Text>().text = responseText.Dequeue();
                PlayerChoice3.GetComponentInChildren<Text>().text = responseText.Dequeue();
            }
        }

        if (exitFlag)
        {
            GameObject.Find("PlaceholderBackground(Clone)").GetComponentInChildren<BackgroundController>().MapOn();
            Destroy(GameObject.Find("PlaceholderBackground(Clone)"));
            Destroy(GameObject.FindGameObjectWithTag("Dialog"));
        }

        if (pollFlag)
        {
            pollTimer = pollTimer - Time.deltaTime;
            if(pollTimer <= 0)
            {
                Global.global.pollStatus = false;
                string speaker = responseText.Dequeue();
                if(Global.global.pollChoice1 > Global.global.pollChoice2 && Global.global.pollChoice1 > Global.global.pollChoice3)
                {
                    sceneDialog.text = speaker + PollResponse1.GetComponent<Text>().text.TrimStart('!','1',':',' ');
                    Background.GetComponent<BackgroundController>().OpinionSwitchboard(speaker, 1);
                }
                else if (Global.global.pollChoice2 > Global.global.pollChoice1 && Global.global.pollChoice2 > Global.global.pollChoice3)
                {
                    sceneDialog.text = speaker + PollResponse2.GetComponent<Text>().text.TrimStart('!', '2', ':', ' ');
                    Background.GetComponent<BackgroundController>().OpinionSwitchboard(speaker, 2);
                }
                else if (Global.global.pollChoice3 > Global.global.pollChoice1 && Global.global.pollChoice3 > Global.global.pollChoice1)
                {
                    sceneDialog.text = speaker + PollResponse3.GetComponent<Text>().text.TrimStart('!', '3', ':', ' ');
                    Background.GetComponent<BackgroundController>().OpinionSwitchboard(speaker, 3);
                }
                else
                {
                    sceneDialog.text = "It was a tie, I'll figure that out later! -Per";
                }
                Global.global.pollChoice1 = 0;
                Global.global.pollChoice2 = 0;
                Global.global.pollChoice3 = 0;
                pollFlag = false;
                ExitButton.SetActive(true);
            }
        }
    }

    void StartPoll(string playerChoice)
    {
        PlayerChoice1.SetActive(false);
        PlayerChoice2.SetActive(false);
        PlayerChoice3.SetActive(false);
        PollInstructions.SetActive(true);
        PollResponse1.SetActive(true);
        PollResponse2.SetActive(true);
        PollResponse3.SetActive(true);
        PollBackground.SetActive(true);
        sceneDialog.text = "Me: " + playerChoice;
        //start the poll
        Global.global.pollStatus = true;
        pollFlag = true;
        PollResponse1.GetComponent<Text>().text = "!1: " + responseText.Dequeue();
        PollResponse2.GetComponent<Text>().text = "!2: " + responseText.Dequeue();
        PollResponse3.GetComponent<Text>().text = "!3: " + responseText.Dequeue();
    }

    void Poll1()
    {
        string playerChoice = PlayerChoice1.GetComponentInChildren<Text>().text;
        StartPoll(playerChoice);
    }

    void Poll2()
    {
        string playerChoice = PlayerChoice2.GetComponentInChildren<Text>().text;
        StartPoll(playerChoice);
    }

    void Poll3()
    {
        string playerChoice = PlayerChoice3.GetComponentInChildren<Text>().text;
        StartPoll(playerChoice);
    }

    public void CreateConversation(Queue<string> newConversation, Queue<string> newResponses)
    {
        sceneText = newConversation;
        sceneDialog.text = sceneText.Dequeue();
        responseText = newResponses;
    }

    public void Continue()
    {
        continueFlag = true;
    }

    public void Exit()
    {
        exitFlag = true;
    }

    
}
