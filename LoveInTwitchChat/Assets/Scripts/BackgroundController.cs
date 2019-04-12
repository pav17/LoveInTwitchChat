using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    GameObject dialog;
    GameObject positive;
    GameObject negative;
    GameObject ExitButton;
    GameObject Cafe;
    GameObject Mall;
    GameObject Park;
    

    void Awake()
    {
        dialog = Resources.Load("Prefabs/DialogRoot") as GameObject;
        positive = GameObject.Find("Positive");
        negative = GameObject.Find("Negative");
        positive.SetActive(false);
        negative.SetActive(false);
        Cafe = GameObject.Find("Cafe");
        Mall = GameObject.Find("Mall");
        Park = GameObject.Find("Park");
        Cafe.SetActive(false);
        Mall.SetActive(false);
        Park.SetActive(false);
        ExitButton = GameObject.Find("ExitButton");
    }

    public void Initialize(string location)
    {
        string positiveLocation = CharacterMonitor.cm.GetPositiveLocation(Global.global.positiveInteractions);
        Debug.Log(positiveLocation);
        string negativeLocation = CharacterMonitor.cm.GetNegativeLocation(Global.global.negativeInteractions);
        Debug.Log(negativeLocation);
        
        if (location == positiveLocation)
        {
            positive.SetActive(true);
        }
        
        if (location == negativeLocation)
        {
            negative.SetActive(true);
        }
    }

    public void startPositiveConversation()
    {
        ExitButton.SetActive(false);
        GameObject newDialog = Instantiate(dialog);
        Queue<string> newDialogQueue = DialogSorter.dialog.PullPositive();
        Queue<string> newResponseQueue = DialogSorter.dialog.PullPositiveResponse();
        newDialog.GetComponentInChildren<TextboxController>().CreateConversation(newDialogQueue, newResponseQueue);
        Global.global.positiveInteractions++;
    }

    public void MapOn()
    {
        Cafe.SetActive(true);
        Mall.SetActive(true);
        Park.SetActive(true);
    }

    public void Exit()
    {
        MapOn();
        Destroy(GameObject.Find("PlaceholderBackground(Clone)"));
    }
}
