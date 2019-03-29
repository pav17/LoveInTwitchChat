using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{

    GameObject dialog;

    // Start is called before the first frame update
    void Start()
    {
        dialog = Resources.Load("Prefabs/DialogRoot") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartConversation()
    {
        GameObject newQuestion = Instantiate(dialog);
        newQuestion.transform.position = new Vector3(0, 0, 0);
        newQuestion.GetComponent<DialogController>().Create();
        
    }
}
