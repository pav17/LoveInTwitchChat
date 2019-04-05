using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{

    GameObject background;

    // Start is called before the first frame update
    void Start()
    {
        background = Resources.Load("Prefabs/PlaceholderBackground") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnterCafe()
    {
        GameObject newBackground = Instantiate(background);
        newBackground.GetComponentInChildren<BackgroundController>().Initialize("Cafe");
    }

    public void EnterMall()
    {
        GameObject newBackground = Instantiate(background);
        newBackground.GetComponentInChildren<BackgroundController>().Initialize("Mall");
    }

    public void EnterPark()
    {
        GameObject newBackground = Instantiate(background);
        newBackground.GetComponentInChildren<BackgroundController>().Initialize("Park");
    }
}
