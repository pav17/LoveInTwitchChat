using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{

    GameObject dialog;
    GameObject background;

    // Start is called before the first frame update
    void Start()
    {
        dialog = Resources.Load("Prefabs/DialogRoot") as GameObject;
        background = Resources.Load("Prefabs/PlaceholderBackground") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartCafeConversation()
    {
        GameObject newBackground = Instantiate(background);
        GameObject newDialog = Instantiate(dialog);
        Queue<string> newDialogQueue = DialogSorter.dialog.PullCafe();
        Queue<string> newResponseQueue = DialogSorter.dialog.PullCafeResponse();
        newDialog.GetComponentInChildren<TextboxController>().CreateConversation(newDialogQueue, newResponseQueue);
    }
}
