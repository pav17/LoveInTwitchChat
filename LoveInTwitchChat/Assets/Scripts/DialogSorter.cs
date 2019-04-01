using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogSorter : MonoBehaviour
{

    public static DialogSorter dialog;

    Queue<Queue<string>> Cafe;
    Queue<Queue<string>> CafeResponse;

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
        CafeResponse = BuildCafeResponse();
        //Queue<Queue<string>> Park = new Queue<Queue>();
        //Queue<Queue<string>> Mall = new Queue<Queue>();

    }

    Queue<Queue<string>> BuildCafe()
    {
        Queue<Queue<string>> CafeConvo = new Queue<Queue<string>>();
        
        Queue<string> Cafe1 = new Queue<string>();
        Cafe1.Enqueue("You walk into the cafe and get in line to order at the counter, when you notice Positive at the head of the line doing " +
            "their best to try to motivate the barista who, apparently, looked a little demotivated.");
        Cafe1.Enqueue("Positive: Hey, no need to look so down, you’re doing a great job!");
        Cafe1.Enqueue("Barista: Oh, thanks. I was getting pretty worn out, but your positivity has helped me feel better!");
        Cafe1.Enqueue("Positive: That’s the spirit!");
        Cafe1.Enqueue("Me: (Thinks: Wow, I guess a bit of positivity really can go a long way!)");
        Cafe1.Enqueue("END");
        CafeConvo.Enqueue(Cafe1);

        Queue<string> Cafe2 = new Queue<string>();
        Cafe2.Enqueue("This is a test sentance.");
        Cafe2.Enqueue("END");
        CafeConvo.Enqueue(Cafe2);

        return (CafeConvo);
    }

    Queue<Queue<string>> BuildCafeResponse()
    {
        Queue<Queue<string>> CafeConvoResponse = new Queue<Queue<string>>();

        Queue<string> Cafe1Response = new Queue<string>();
        Cafe1Response.Enqueue("Hey, good on you Positive, you cheered that invisible barista right up!");
        Cafe1Response.Enqueue("Hey, now that is positively great, now can I get some coffee?");
        Cafe1Response.Enqueue("Fuck off with all this positivity, now get me some of that sweet sweet bean juice");
        Cafe1Response.Enqueue("Hey, thanks, those words really tickled my audio receptors!");
        Cafe1Response.Enqueue("Wow, those words are really harshing my whole vibe.");
        Cafe1Response.Enqueue("Hey, fuck you and your words!");
        Cafe1Response.Enqueue("Positive: ");
        Cafe1Response.Enqueue("END");
        CafeConvoResponse.Enqueue(Cafe1Response);

        return (CafeConvoResponse);
    }

    public Queue<string> PullCafe()
    {
        Queue<string> conversation = Cafe.Dequeue();
        return (conversation);
    }

    public Queue<string> PullCafeResponse()
    {
        Queue<string> response = CafeResponse.Dequeue();
        return (response);
    }

}
