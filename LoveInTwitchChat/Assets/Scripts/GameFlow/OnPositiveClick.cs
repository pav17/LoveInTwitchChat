using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPositiveClick : MonoBehaviour
{
    public void OnMouseDown()
    {
        GameObject.Find("TempBackground").GetComponent<BackgroundController>().startPositiveConversation();
    }
}
