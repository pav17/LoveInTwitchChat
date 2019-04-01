using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogSorter : MonoBehaviour
{

    public static DialogSorter dialog;

    Queue<Queue<string>> Cafe;

    void Awake()
    {
        if (dialog == null)
        {
            DontDestroyOnLoad(gameObject); //makes dialog persist across scenes
            dialog = this;
        }
        else if (dialog != this)
        {
            Destroy(gameObject); //deletes copies of dialog which do not need to exist, so right version is used to get info from
        }
    }
    
    
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        Cafe = BuildCafe();
        //Queue<Queue<string>> Park = new Queue<Queue>();
        //Queue<Queue<string>> Mall = new Queue<Queue>();

    }

    Queue<Queue<string>> BuildCafe()
    {
        Queue<Queue<string>> CafeConvo = new Queue<Queue<string>>();

        Queue<string> Cafe1 = new Queue<string>();
        Cafe1.Enqueue("You walk into the cafe and get in line to order at the counter, when you notice Positive at the head of the line doing " +
            "their best to try to motivate the barista who, apparently, looked a little demotivated.");
        Cafe1.Enqueue("Hey, no need to look so down, you’re doing a great job!");
        Cafe1.Enqueue("Oh, thanks. I was getting pretty worn out, but your positivity has helped me feel better!");
        Cafe1.Enqueue("That’s the spirit!");
        Cafe1.Enqueue("(Thinks: Wow, I guess a bit of positivity really can go a long way!)");
        Cafe1.Enqueue("END");

        CafeConvo.Enqueue(Cafe1);
        
        return (CafeConvo);
    }

    public Queue<string> PullCafe()
    {
        Queue<string> conversation = Cafe.Dequeue();
        return (conversation);
    }



}
