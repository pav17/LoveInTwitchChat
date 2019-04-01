using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextboxController : MonoBehaviour
{

    Text sceneDialog;
    Queue<string> sceneText;
    bool continueFlag;
    bool exitFlag;

    void Awake()
    {
        sceneDialog = GetComponent<Text>();
    }

    void Update()
    {
        //if (Input.GetKeyUp(KeyCode.Return))
        if (continueFlag)
        {
            continueFlag = false;
            string currentText = sceneText.Dequeue();
            if (currentText != "END")
            {
                sceneDialog.text = currentText;
                Debug.Log(currentText);
            }
            else
            {
                sceneDialog.text = "";
                //spawn player response
            }
        }

        if (exitFlag)
        {
            Destroy(GameObject.Find("PlaceholderBackground(Clone)"));
            Destroy(GameObject.FindGameObjectWithTag("Dialog"));
        }
    }

    public void CreateConversation(Queue<string> newConversation)
    {
        sceneText = newConversation;
        sceneDialog.text = sceneText.Dequeue();
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
