using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextboxController : MonoBehaviour
{

    Text sceneDialog;
    Queue<string> sceneText;

    void Start()
    {
        sceneDialog = GetComponent<Text>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
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
    }

    public void CreateConversation(Queue<string> newConversation)
    {
        sceneText = newConversation;
        sceneDialog.text = sceneText.Dequeue();
    }
}
