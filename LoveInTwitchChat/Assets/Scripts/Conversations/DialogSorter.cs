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
    
    Include as many of the above line as necessary, each line will appear as its own block of text.
        
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

    //Create the text that shows up before the player dialog choice
    Queue<Queue<string>> BuildPositive()
    {
        Queue<Queue<string>> PositiveConvo = new Queue<Queue<string>>();
        
        Queue<string> Positive1 = new Queue<string>(); //Cafe scene 1
        Positive1.Enqueue("You walk into the cafe and get in line to order at the counter, when you notice Positive at the head of the line doing " +
            "their best to try to motivate the barista who, apparently, looked a little demotivated.");
        Positive1.Enqueue("Positive: Hey, no need to look so down, you’re doing a great job!");
        Positive1.Enqueue("Barista: Oh, thanks. I was getting pretty worn out, but your positivity has helped me feel better!");
        Positive1.Enqueue("Positive: That’s the spirit!");
        Positive1.Enqueue("Me: (Thinks: Wow, I guess a bit of positivity really can go a long way!)");
        Positive1.Enqueue("END");
        PositiveConvo.Enqueue(Positive1);

        Queue<string> Positive2 = new Queue<string>(); //Park scene 1
        Positive2.Enqueue("You wander your way into the park for a relaxing stroll by the pond when you spot Positive there feeding some ducks.");
        Positive2.Enqueue("Positive: Look at all you lovely little ducks! Aren’t you just the cutest?");
        Positive2.Enqueue("The ducks are not cute, they look angry and ready to attack. What should you do?");
        Positive2.Enqueue("END");
        PositiveConvo.Enqueue(Positive2);

        Queue<string> Positive3 = new Queue<string>(); //Mall scene 1
        Positive3.Enqueue("You enter the mall and walk around to a few stores, picking up a few things that you’ve been needing for a while before going by the game store.");
        Positive3.Enqueue("When you get there you happen to see Positive looking at a game called… Herding Chats? It doesn’t seem like it’s a very good game…");
        Positive3.Enqueue("They look up and see you.");
        Positive3.Enqueue("Positive: Oh hey! This looks like a great game, doesn’t it? I heard that the developers made it as a school project!");
        Positive3.Enqueue("END");
        PositiveConvo.Enqueue(Positive3);

        Queue<string> Positive4 = new Queue<string>(); //Park scene 2
        Positive4.Enqueue("You’re on a pleasant walk through the park when you see positive standing and staring at the clouds.");
        Positive4.Enqueue("You: Oh hey Positive, what are you doing out here?");
        Positive4.Enqueue("Positive: I was looking at the aerosol consisting of a visible mass of minute liquid droplets up in the sky.");
        Positive4.Enqueue("You: Do you mean…. The clouds?");
        Positive4.Enqueue("Positive: Ah, yes, that is indeed what they are called. Are they not pretty?");
        Positive4.Enqueue("END");
        PositiveConvo.Enqueue(Positive4);

        Queue<string> Positive5 = new Queue<string>(); //Cafe scene 2
        Positive5.Enqueue("You find yourself heading into the cafe for your tenth coffee today, when you spot Positive sitting at a table sipping(?) some tea.");
        Positive5.Enqueue("You walk up with your coffee jittering in your hand and say:");
        Positive5.Enqueue("You: Hey Positive what’s shaking?");
        Positive5.Enqueue("Positive: From the look of things, it would appear you are what is shaking.");
        Positive5.Enqueue("END");
        PositiveConvo.Enqueue(Positive5);

        Queue<string> Positive6 = new Queue<string>(); //Park scene 3
        Positive6.Enqueue("Character: This is an example.");
        Positive6.Enqueue("Character: This is an example.");
        Positive6.Enqueue("Character: This is an example.");
        Positive6.Enqueue("Character: This is an example.");
        Positive6.Enqueue("Character: This is an example.");
        Positive6.Enqueue("END");
        PositiveConvo.Enqueue(Positive6);

        Queue<string> Positive7 = new Queue<string>(); //Mall scene 2
        Positive7.Enqueue("You find yourself at the mall taking a leisurely stroll when you see positive buying a pretzel, the greatest snack of all time.");
        Positive7.Enqueue("You decide to walk up and buy one yourself, cause who wouldn’t want one of those delicious twisted delicacies.");
        Positive7.Enqueue("But when you walk up to the counter the employee tells you:");
        Positive7.Enqueue("Employee: Sorry, we just sold the last pretzel in existance to that Positive fellow over there and will now be closing forever.");
        Positive7.Enqueue("You need that pretzel more than life itself, you will have it for yourself. Why does a robot even need a pretzel?");
        Positive7.Enqueue("END");
        PositiveConvo.Enqueue(Positive7);

        Queue<string> Positive8 = new Queue<string>(); //Cafe scene 3
        Positive8.Enqueue("You’re on your way back to the cafe for some more of that sweet brew dew, when you spot Positive petting a dog on the side of the road.");
        Positive8.Enqueue("You: Oh hey Positive what are you doing out here?");
        Positive8.Enqueue("Positive: I am petting this small hair covered quadrupedal that I am told is very cute.");
        Positive8.Enqueue("You: Ah, look at how cute he is! Who’s a good doggy?");
        Positive8.Enqueue("Positive: Oh boy! I hope it is I!");
        Positive8.Enqueue("END");
        PositiveConvo.Enqueue(Positive8);

        Queue<string> Positive9 = new Queue<string>(); //Mall scene 3
        Positive9.Enqueue("You go to the mall with the intent of going to the arcade that happens to be there.");
        Positive9.Enqueue("Deciding to have fun and get exercise at the same time, you go and get yourself set up for laser tag.");
        Positive9.Enqueue("It’s real fancy stuff, with super accurate laser guns and… haptic vests?");
        Positive9.Enqueue("Holy crap, what kind of budget does this mall have?");
        Positive9.Enqueue("You go in to a team battle, but your time keeps getting completely wiped out.");
        Positive9.Enqueue("Midway through the game, you see why.");
        Positive9.Enqueue("There’s someone standing on a raised obstacle who is somehow able to snap their gun immediately to anyone they can see.");
        Positive9.Enqueue("They are… literally aiming like a bot.");
        Positive9.Enqueue("Suddenly you feel the haptics in your vest go off and see that they are looking at you with a grin on their face/monitor.");
        Positive9.Enqueue("Positive: Ha! I got you! This is so much fun!");
        Positive9.Enqueue("END");
        PositiveConvo.Enqueue(Positive9);

        return (PositiveConvo);
    }

    //create the dialog choices for the player and the chat
    Queue<Queue<string>> BuildPositiveResponse()
    {
        Queue<Queue<string>> PositiveConvoResponse = new Queue<Queue<string>>();

        Queue<string> Positive1Response = new Queue<string>(); //Cafe choices 1
        Positive1Response.Enqueue("Hey, good on you Positive, you cheered that invisible barista right up!");
        Positive1Response.Enqueue("Hey, now that is positively great, now can I get some coffee?");
        Positive1Response.Enqueue("Fuck off with all this positivity, now get me some of that sweet sweet bean juice");
        Positive1Response.Enqueue("Hey, thanks, those words really tickled my audio receptors!");
        Positive1Response.Enqueue("Wow, those words are really harshing my whole vibe.");
        Positive1Response.Enqueue("Hey, fuck you and your words!");
        Positive1Response.Enqueue("Positive: ");
        Positive1Response.Enqueue("END");
        PositiveConvoResponse.Enqueue(Positive1Response);

        Queue<string> Positive2Response = new Queue<string>(); //Park choices 1
        Positive2Response.Enqueue("Look out, those ducks are deadly! *Chucks grenade into the middle of the ducks*");
        Positive2Response.Enqueue("Wow, these ducks sure are cute! *Let them chew on your hand*");
        Positive2Response.Enqueue("*Walk away while positive is mauled by ducks*");
        Positive2Response.Enqueue("Ha Ha, this is so fun!");
        Positive2Response.Enqueue("You certainly can cater to my programming!");
        Positive2Response.Enqueue("Duck off!");
        Positive2Response.Enqueue("Positive: ");
        Positive2Response.Enqueue("END");
        PositiveConvoResponse.Enqueue(Positive2Response);

        Queue<string> Positive3Response = new Queue<string>(); //Mall choices 1
        Positive3Response.Enqueue("Really? That’s amazing! I think I’m gonna buy that right now!");
        Positive3Response.Enqueue("Well it certainly sounds… Interesting? Not really my thing though…");
        Positive3Response.Enqueue("Why would you ever want something that looks as bad as that? That game should be in the landfill with ET.");
        Positive3Response.Enqueue("My programming agrees with this statement you have made. I find you to be completely correct!");
        Positive3Response.Enqueue("Well, if you insist. I’m definitely going to buy it though. 20,000$ seems like a good deal!");
        Positive3Response.Enqueue("My programming says that is incorrect. My programming also suggests that you are an “asshole”. I will now call you an asshole: You are an asshole.");
        Positive3Response.Enqueue("Positive: ");
        Positive3Response.Enqueue("END");
        PositiveConvoResponse.Enqueue(Positive3Response);

        Queue<string> Positive4Response = new Queue<string>(); //Park choices 2
        Positive4Response.Enqueue("Yes those are some truly beautiful cumulus clouds on this beautiful summer day…");
        Positive4Response.Enqueue("Is that a rain cloud headed our way? I hate rain…");
        Positive4Response.Enqueue("No, they are not pretty. You are also not pretty. Also I’m leaving.");
        Positive4Response.Enqueue("You certainly know how to say the correct words to make my relationship with you improve.");
        Positive4Response.Enqueue("I feel like you could have handled that response in a slightly better way, however I still feel a little bit happier with you.");
        Positive4Response.Enqueue("Wow, because of that answer I feel obligated to say: Fuck you!");
        Positive4Response.Enqueue("Positive: ");
        Positive4Response.Enqueue("END");
        PositiveConvoResponse.Enqueue(Positive4Response);

        Queue<string> Positive5Response = new Queue<string>(); //Cafe choices 2
        Positive5Response.Enqueue("Ha ha, Positive, you’re so funny! I have a serious problem! :)");
        Positive5Response.Enqueue("Yes I sure am, and I’m going to drink 10-more cups of go go juice today.");
        Positive5Response.Enqueue("How dare you imply I have a caffeine problem. *Chugs coffee* Now excuse me, I have to go order another coffee.");
        Positive5Response.Enqueue("Ha ha! I’m glad my joke allowed me to get relationship points with you!");
        Positive5Response.Enqueue("Well, I hope you have a (insert positive word here) day!");
        Positive5Response.Enqueue("You have a serious problem and I think you need to take a long hard look at that cup of coffee…. And you are drinking it…");
        Positive5Response.Enqueue("Positive: ");
        Positive5Response.Enqueue("END");
        PositiveConvoResponse.Enqueue(Positive5Response);

        Queue<string> Positive6Response = new Queue<string>(); //Park choices 3
        Positive6Response.Enqueue("The first three enqueue commands are the players options");
        Positive6Response.Enqueue("The first three enqueue commands are the players options");
        Positive6Response.Enqueue("The first three enqueue commands are the players options");
        Positive6Response.Enqueue("Good chat option");
        Positive6Response.Enqueue("Middle chat Option");
        Positive6Response.Enqueue("Bad chat option");
        Positive6Response.Enqueue("The sixth command is the chracters name");
        Positive6Response.Enqueue("END");
        PositiveConvoResponse.Enqueue(Positive6Response);

        Queue<string> Positive7Response = new Queue<string>(); //Mall choices 2
        Positive7Response.Enqueue("Go up and ask Positive for the pretzel.");
        Positive7Response.Enqueue("Pull out your taser and threaten Positive for the pretzel. You need it.");
        Positive7Response.Enqueue("Offer Positive some spare circuit boards you have lying around.");
        Positive7Response.Enqueue("Hey friend, did you want this pretzel? I bought it for you!");
        Positive7Response.Enqueue("Hello friend, my programming tells me that pretzels are one of the greatest commodities of all time, and will never give this pretzel up.");
        Positive7Response.Enqueue("*Devours the pretzel in front of you… somehow*");
        Positive7Response.Enqueue("Positive: ");
        Positive7Response.Enqueue("END");
        PositiveConvoResponse.Enqueue(Positive7Response);

        Queue<string> Positive8Response = new Queue<string>(); //Cafe choices 3
        Positive8Response.Enqueue("Yes, you are a very good doggy Positive! *pat positive on the head*");
        Positive8Response.Enqueue("I was talking about the dog, but you are a good robot I guess.");
        Positive8Response.Enqueue("No Positive, you are a very bad doggy! *Spray Positive with a squirt bottle*");
        Positive8Response.Enqueue("Oh boy, I am so excited by those words you have said to me!");
        Positive8Response.Enqueue("Oh… okay…. I guess those words are all right with me.");
        Positive8Response.Enqueue("Why have you said such a mean thing to me, I hope you think about what you have said and say something nicer next time.");
        Positive8Response.Enqueue("Positive: ");
        Positive8Response.Enqueue("END");
        PositiveConvoResponse.Enqueue(Positive8Response);

        Queue<string> Positive9Response = new Queue<string>(); //Mall Choices 3
        Positive9Response.Enqueue("Yep, sure is! In fact, I probably am having so much fun that everything else will be completely boring by comparison!");
        Positive9Response.Enqueue("Well, I’m glad someone is having fun. I think I’ll go have a good cry after this game myself.");
        Positive9Response.Enqueue("Well, that’s nice, because literally NO ONE ELSE IS HAVING FUN!");
        Positive9Response.Enqueue("What a wonderful interaction! I find you a joy to talk to!");
        Positive9Response.Enqueue("Well, I suppose you are correct…");
        Positive9Response.Enqueue("I disagree fully. Go back to your spawn so I may destroy you again when you return.");
        Positive9Response.Enqueue("Positive: ");
        Positive9Response.Enqueue("END");
        PositiveConvoResponse.Enqueue(Positive9Response);


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
    //get the full conversation for positive
    public Queue<string> PullPositive()
    {
        Queue<string> conversation = Positive.Dequeue();
        return (conversation);
    }
    //get the responses to match the conversation for positive
    public Queue<string> PullPositiveResponse()
    {
        Queue<string> response = PositiveResponse.Dequeue();
        return (response);
    }
    //get the full conversation for negative
    public Queue<string> PullNegative()
    {
        Queue<string> conversation = Negative.Dequeue();
        return (conversation);
    }
    //get the responses to match the conversation for negative
    public Queue<string> PullNegativeResponse()
    {
        Queue<string> response = NegativeResponse.Dequeue();
        return (response);
    }
}
