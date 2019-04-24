using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundController : MonoBehaviour
{
    GameObject dialog;
    GameObject positive;
    GameObject negative;
    GameObject ExitButton;
    GameObject Cafe;
    GameObject Mall;
    GameObject Park;
    GameObject Opinion;
    GameObject OpinionBackground;
    public Sprite CafeImage;
    public Sprite MallImage;
    public Sprite ParkImage;
    string locationGlobal;
    public AudioClip cafeBackgroundAudio;
    public AudioClip mallBackgroundAudio;
    public AudioClip parkBackgroundAudio;
    AudioSource backgroundSource;
    Text OpinionText;

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
        Opinion = GameObject.Find("Opinion");
        OpinionBackground = GameObject.Find("OpinionBackground");
        OpinionText = Opinion.GetComponent<Text>();
        Opinion.SetActive(false);
        OpinionBackground.SetActive(false);
        backgroundSource = gameObject.GetComponent<AudioSource>();

    }

    void Update()
    {
        if (backgroundSource.isPlaying == false)
        {
            if (locationGlobal == "Cafe")
            {
                backgroundSource.volume = 0.25f;
                AudioManager.audioManager.PlayAudio(cafeBackgroundAudio, backgroundSource);
            }
            else if (locationGlobal == "Mall")
            {
                backgroundSource.volume = 0.25f;
                AudioManager.audioManager.PlayAudio(mallBackgroundAudio, backgroundSource);
            }
            else if (locationGlobal == "Park")
            {
                backgroundSource.volume = 0.40f;
                AudioManager.audioManager.PlayAudio(parkBackgroundAudio, backgroundSource);
            }
        }
    }

    public void Initialize(string location)
    {
        locationGlobal = location;
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

        if (location == "Cafe")
        {
            gameObject.GetComponent<Image>().sprite = CafeImage;
        }
        else if (location == "Mall")
        {
            gameObject.GetComponent<Image>().sprite = MallImage;
        }
        else if (location == "Park")
        {
            gameObject.GetComponent<Image>().sprite = ParkImage;
        }
        else
        {
            Debug.Log(location);
        }


    }

    public void startPositiveConversation()
    {
        ExitButton.SetActive(false);
        GameObject newDialog = Instantiate(dialog);
        Queue<string> newDialogQueue = DialogSorter.dialog.PullPositive();
        Queue<string> newResponseQueue = DialogSorter.dialog.PullPositiveResponse();
        newDialog.GetComponentInChildren<TextboxController>().CreateConversation(newDialogQueue, newResponseQueue);
        Opinion.SetActive(true);
        OpinionBackground.SetActive(true);
        OpinionText.text = "Positives opinion: " + Global.global.positiveOpinion.ToString();
        Global.global.positiveInteractions++;
    }

    public void startNegativeConversation()
    {
        ExitButton.SetActive(false);
        GameObject newDialog = Instantiate(dialog);
        Queue<string> newDialogQueue = DialogSorter.dialog.PullNegative();
        Queue<string> newResponseQueue = DialogSorter.dialog.PullNegativeResponse();
        newDialog.GetComponentInChildren<TextboxController>().CreateConversation(newDialogQueue, newResponseQueue);
        Opinion.SetActive(true);
        OpinionBackground.SetActive(true);
        OpinionText.text = "Negatives opinion: " + Global.global.negativeOpinion.ToString();
        Global.global.negativeInteractions++;
    }

    public void OpinionSwitchboard(string speaker, int result)
    {
        if (speaker == "Positive: ")
        {
            CharacterMonitor.cm.PositiveOpinionChange(result);
            OpinionText.text = "Positives opinion: " + Global.global.positiveOpinion.ToString();
        }
        else if (speaker == "Negative: ")
        {
            CharacterMonitor.cm.NegativeOpinionChange(result);
            OpinionText.text = "Negatives opinion: " + Global.global.negativeOpinion.ToString();
        }
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
