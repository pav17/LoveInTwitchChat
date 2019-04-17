using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogSorter : MonoBehaviour
{

    public static DialogSorter dialog;

    Queue<Queue<string>> Positive;
    Queue<Queue<string>> PositiveResponse;
    Queue<Queue<string>> Negative;
    Queue<Queue<string>> NegativeResponse;

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
        Positive = BuildPositive();
        PositiveResponse = BuildPositiveResponse();
        Negative = BuildNegative();
        NegativeResponse = BuildNegativeResponse();
    }
    
    /*
    To create a new conversation follow the following template

    In BuildCharacter() insert the following:

        Queue<string> Character# = new Queue<string>();
        Character#.Enqueue("Character: This is an example.");
        Character#.Enqueue("END");
        CharacterConvo.Enqueue(Character#);

    Now in BuildCharacterResponse:

        Queue<string> Character#Response = new Queue<string>();
        Character#Response.Enqueue("The first three enqueue commands are the players options");
        Character#Response.Enqueue("The first three enqueue commands are the players options");
        Character#Response.Enqueue("The first three enqueue commands are the players options");
        Character#Response.Enqueue("Good chat option");
        Character#Response.Enqueue("Middle chat Option");
        Character#Response.Enqueue("Bad chat option");
        Character#Response.Enqueue("The sixth command is the chracters name");
        Character#Response.Enqueue("END");
        CharacterConvoResponse.Enqueue(Character#Response);

    */
    Queue<Queue<string>> BuildPositive()
    {
        Queue<Queue<string>> PositiveConvo = new Queue<Queue<string>>();
        
        Queue<string> Positive1 = new Queue<string>();
        Positive1.Enqueue("You walk into the cafe and get in line to order at the counter, when you notice Positive at the head of the line doing " +
            "their best to try to motivate the barista who, apparently, looked a little demotivated.");
        Positive1.Enqueue("Positive: Hey, no need to look so down, you’re doing a great job!");
        Positive1.Enqueue("Barista: Oh, thanks. I was getting pretty worn out, but your positivity has helped me feel better!");
        Positive1.Enqueue("Positive: That’s the spirit!");
        Positive1.Enqueue("Me: (Thinks: Wow, I guess a bit of positivity really can go a long way!)");
        Positive1.Enqueue("END");
        PositiveConvo.Enqueue(Positive1);

        Queue<string> Positive2 = new Queue<string>();
        Positive2.Enqueue("You wander your way into the park for a relaxing stroll by the pond when you spot Positive there feeding some ducks.");
        Positive2.Enqueue("Positive: Look at all you lovely little ducks! Aren’t you just the cutest?");
        Positive2.Enqueue("The ducks are not cute, they look angry and ready to attack. What should you do?");
        Positive2.Enqueue("END");
        PositiveConvo.Enqueue(Positive2);

        return (PositiveConvo);
    }

    Queue<Queue<string>> BuildPositiveResponse()
    {
        Queue<Queue<string>> PositiveConvoResponse = new Queue<Queue<string>>();

        Queue<string> Positive1Response = new Queue<string>();
        Positive1Response.Enqueue("Hey, good on you Positive, you cheered that invisible barista right up!");
        Positive1Response.Enqueue("Hey, now that is positively great, now can I get some coffee?");
        Positive1Response.Enqueue("Fuck off with all this positivity, now get me some of that sweet sweet bean juice");
        Positive1Response.Enqueue("Hey, thanks, those words really tickled my audio receptors!");
        Positive1Response.Enqueue("Wow, those words are really harshing my whole vibe.");
        Positive1Response.Enqueue("Hey, fuck you and your words!");
        Positive1Response.Enqueue("Positive: ");
        Positive1Response.Enqueue("END");
        PositiveConvoResponse.Enqueue(Positive1Response);

        Queue<string> Positive2Response = new Queue<string>();
        Positive2Response.Enqueue("Look out, those ducks are deadly! *Chucks grenade into the middle of the ducks*");
        Positive2Response.Enqueue("Wow, these ducks sure are cute! *Let them chew on your hand*");
        Positive2Response.Enqueue("*Walk away while positive is mauled by ducks*");
        Positive2Response.Enqueue("Ha Ha, this is so fun!");
        Positive2Response.Enqueue("You certainly can cater to my programming!");
        Positive2Response.Enqueue("Duck off!");
        Positive2Response.Enqueue("Positive: ");
        Positive2Response.Enqueue("END");
        PositiveConvoResponse.Enqueue(Positive2Response);

        return (PositiveConvoResponse);
    }

    Queue<Queue<string>> BuildNegative()
    {
        Queue<Queue<string>> NegativeConvo = new Queue<Queue<string>>();

        Queue<string> Negative1Response = new Queue<string>();
        
        return (NegativeConvo);
    }

    Queue<Queue<string>> BuildNegativeResponse()
    {
        Queue<Queue<string>> NegativeConvoResponse = new Queue<Queue<string>>();

        Queue<string> Negative1Response = new Queue<string>();

        return (NegativeConvoResponse);
    }

    public Queue<string> PullPositive()
    {
        Queue<string> conversation = Positive.Dequeue();
        return (conversation);
    }

    public Queue<string> PullPositiveResponse()
    {
        Queue<string> response = PositiveResponse.Dequeue();
        return (response);
    }

    public Queue<string> PullNegative()
    {
        Queue<string> conversation = Negative.Dequeue();
        return (conversation);
    }

    public Queue<string> PullNegativeResponse()
    {
        Queue<string> response = NegativeResponse.Dequeue();
        return (response);
    }
}
