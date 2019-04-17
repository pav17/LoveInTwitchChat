using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnNegativeClick : MonoBehaviour
{
    public void OnMouseDown()
    {
        GameObject.Find("TempBackground").GetComponent<BackgroundController>().startNegativeConversation();
    }
}
