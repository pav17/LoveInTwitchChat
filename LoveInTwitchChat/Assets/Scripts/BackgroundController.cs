using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    GameObject dialog;
    GameObject positive;
    GameObject negative;
    

    void Awake()
    {
        dialog = Resources.Load("Prefabs/DialogRoot") as GameObject;
        positive = GameObject.Find("Positive");
        negative = GameObject.Find("Negative");
        positive.SetActive(false);
        negative.SetActive(false);
    }

    public void Initialize(string location)
    {
        string positiveLocation = CharacterMonitor.cm.GetPositiveLocation(Global.global.positiveInteractions);
        string negativeLocation = CharacterMonitor.cm.GetNegativeLocation(Global.global.negativeInteractions);

        if (location == positiveLocation)
        {
            positive.SetActive(true);
        }
        
        if (location == negativeLocation)
        {
            negative.SetActive(true);
        }
    }

    void characterSelect()
    {

    }

    void startCafeConversation()
    {
        GameObject newDialog = Instantiate(dialog);
        Queue<string> newDialogQueue = DialogSorter.dialog.PullCafe();
        Queue<string> newResponseQueue = DialogSorter.dialog.PullCafeResponse();
        newDialog.GetComponentInChildren<TextboxController>().CreateConversation(newDialogQueue, newResponseQueue);
    }

}
