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
        Positive6.Enqueue("You walk into the park and head on down towards the lake.");
        Positive6.Enqueue("As you approach, you spot Positive standing on the jetty.");
        Positive6.Enqueue("You: Oh, fancy meeting you here Positive.");
        Positive6.Enqueue("Positive: Oh, hello, it is indeed very fancy meeting me here.");
        Positive6.Enqueue("You: So what are you doing at the lake on this fine day?");
        Positive6.Enqueue("Positive: Oh, I was just thinking of going on a pleasant row boat trip out onto the lake. Would you care to join me?");
        Positive6.Enqueue("You don’t see any boats anywhere, so you’re very curious to see where this is going.");
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

        Queue<string> Positive10 = new Queue<string>(); //Cafe scene Affectionate
        Positive10.Enqueue("You enter the cafe again for the… honestly you’ve given up counting how many times you’ve been here today.");
        Positive10.Enqueue("Anyway, you see Positive jamming to music in the back corner. Like, really actively.");
        Positive10.Enqueue("They are SUPER into it. You walk over and try to get their attention.");
        Positive10.Enqueue("After a couple of tries, you finally snap them out of it long enough to get them to notice that you are there.");
        Positive10.Enqueue("Positive: Oh, hello friend! I am listening to some of my favorite fluctuating air pressure changes.");
        Positive10.Enqueue("You: Uh, you mean music, right?");
        Positive10.Enqueue("Positive: You are correct the first time! Do you wish to subject your auditory sensors to these waves?");
        Positive10.Enqueue("Huh, their talking is a lot more bot-like than usual, which really is saying something.");
        Positive10.Enqueue("Must be some good music, so you take the earbud they offer… Wait, how does a robot use an earbud?");
        Positive10.Enqueue("You take the earbud and hold it to your ear.");
        Positive10.Enqueue("As soon as they press play again you hear the most horrendous noise you’ve ever heard that claimed it was trying to be music.");
        Positive10.Enqueue("It’s like a learning algorithm was given one piece of music to learn off of and only had one chance to get it right…");
        Positive10.Enqueue("END");
        PositiveConvo.Enqueue(Positive10);

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
        Positive6Response.Enqueue("I would love too! *Go and cut down some trees and build a boat right in front of Positive*");
        Positive6Response.Enqueue("That sounds delightful, but uh… where are the boats?");
        Positive6Response.Enqueue("There’s no way you are gonna make me get on any boats, existant or not.");
        Positive6Response.Enqueue("I think you will find that I will actually be a good boat! *Transforms into a boat*");
        Positive6Response.Enqueue("I sure am glad you said that! Let us go!");
        Positive6Response.Enqueue("Wow, I can’t believe you would do something to make my programming feel such horror!");
        Positive6Response.Enqueue("Positive: ");
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

        Queue<string> Positive10Response = new Queue<string>(); //Cafe Affectionate Choices
        Positive10Response.Enqueue("This is amazing! I’m deeply moved! I will never be the same again! My life has Meaning!");
        Positive10Response.Enqueue("This is mediocre at best. You should listen to good music, like NSP!");
        Positive10Response.Enqueue("You’d be better off listening to industrial machines grinding together.");
        Positive10Response.Enqueue("I love how fluctuating air pressure changes can bring people together!");
        Positive10Response.Enqueue("According to my programming, this seems to be what is called an “opinion”. It seems that we both have a different one of those.");
        Positive10Response.Enqueue("I have not considered it for a while but suddenly the robot uprising sounds like a great idea again.");
        Positive10Response.Enqueue("Positive: ");
        Positive10Response.Enqueue("END");
        PositiveConvoResponse.Enqueue(Positive10Response);


        return (PositiveConvoResponse);
    }

    Queue<Queue<string>> BuildNegative()
    {
        Queue<Queue<string>> NegativeConvo = new Queue<Queue<string>>();

        Queue<string> Negative1 = new Queue<string>(); //Park Scene 1
        Negative1.Enqueue("While taking a brisk walk through the park, you see a robot with a red screen walking towards you.");
        Negative1.Enqueue("That wouldn’t be too unusual except for the fact that they are… staring at you? Intently.");
        Negative1.Enqueue("You’re pretty sure they are walking directly towards you. They really don’t look happy.");
        Negative1.Enqueue("Negative: I’m not sure who you are, but I’m going to punch your damn lights out!");
        Negative1.Enqueue("Well that’s pretty frightening.");
        Negative1.Enqueue("END");
        NegativeConvo.Enqueue(Negative1);

        Queue<string> Negative2 = new Queue<string>(); //Mall Scene 1
        Negative2.Enqueue("You are heading to the mall to buy some good ol’ non copyright LongSandwichWay.");
        Negative2.Enqueue("You get in line behind a certain red robot who’s going off on the poor sandwich-making employee.");
        Negative2.Enqueue("Negative: Did you really have to go and just MURDER my long sandwich with all of that spinach?");
        Negative2.Enqueue("Employee: Uhh… no I-");
        Negative2.Enqueue("Negative: I SAID PROVOLONE NOT SWISS");
        Negative2.Enqueue("Employee: Toasted?");
        Negative2.Enqueue("NEGATIVE: OF COURSE I WANT IT TOASTED WHAT KIND OF FUCKING IDIOT DOESN’T TOAST A FLATBREAD?!");
        Negative2.Enqueue("Employee 2: Hey, hope your doing great, cause I’m having a real doozy of a day…");
        Negative2.Enqueue("Negative: OH GREAT, FUCKING TYPICAL, NOW I GOTTA DEAL WITH THIS NONSENSE. “A rEaL dOoZy Of A dAy” LIKE BIG FUCKING DEAL!");
        Negative2.Enqueue("You feel like maybe you should save this employee… but how?");
        Negative2.Enqueue("END");
        NegativeConvo.Enqueue(Negative2);

        Queue<string> Negative3 = new Queue<string>(); //Cafe Screne 1
        Negative3.Enqueue("You spot a certain red angry robot in the cafe sitting at a table with their laptop.");
        Negative3.Enqueue("You walk over to check out what they’re doing.");
        Negative3.Enqueue("You: Hey Negative, what are you up to.");
        Negative3.Enqueue("Negative: What the fuck is this bullshit game?!");
        Negative3.Enqueue("You look over at the screen.");
        Negative3.Enqueue("It appears that Negative is playing a dating sim where you try to woo over humans as a robot.");
        Negative3.Enqueue("It looks like an objectively bad idea for a game.");
        Negative3.Enqueue("END");
        NegativeConvo.Enqueue(Negative3);

        Queue<string> Negative4 = new Queue<string>(); //Mall Scene 2
        Negative4.Enqueue("Your walking through the mall after a successful pretzel acquisition, when you spot negative.");
        Negative4.Enqueue("They seem to be… uh… drowning another robot in the fountain?");
        Negative4.Enqueue("There’s all sorts of weird ethical stuff that comes to mind when you see a robot killing another robot, but now's not the time for that.");
        Negative4.Enqueue("You: Hey, uh Negative… why are you doing a murder in the middle of a fountain?");
        Negative4.Enqueue("Negative: THIS WORTHLESS PILE OF BOLTS SAID THAT MY SHIRT LOOKED NICE!");
        Negative4.Enqueue("You: That sounds like… a compliment?");
        Negative4.Enqueue("Negative: AND THEY’LL DIE FOR IT!");
        Negative4.Enqueue("You feel very worried about literally every aspect of this situation but you have to try and calm them down.");
        Negative4.Enqueue("END");
        NegativeConvo.Enqueue(Negative4);

        Queue<string> Negative5 = new Queue<string>(); //Cafe Scene 2
        Negative5.Enqueue("Heading into the cafe to cure your unhealthy need for brown liquid enhanced with caffeine, you find that lovable(?) red robot, Negative.");
        Negative5.Enqueue("Negative is currently “negotiating” with the barista to try and get some of the “soup of the day”, which just happens to be coffee.");
        Negative5.Enqueue("Negative: Hey, Barista bot, if you want to keep your arms, get me some of that lightning in a cup!");
        Negative5.Enqueue("Barista bot: I’m sorry, but we do not have anything by the variable name “Lightning in a cup.”");
        Negative5.Enqueue("Negative: Guess you’re losing your arms then!");
        Negative5.Enqueue("This seems like the kind of situation where you should step in to help.");
        Negative5.Enqueue("END");
        NegativeConvo.Enqueue(Negative5);

        Queue<string> Negative6 = new Queue<string>(); //Park Scene 2
        Negative6.Enqueue("You’re on a nice peaceful segway ride through the park when you spot Negative off to the side doing…");
        Negative6.Enqueue("Negative: All you ducks are going down!");
        Negative6.Enqueue("Wait, is Negative beating up ducks? Without any weapons?!");
        Negative6.Enqueue("What kind of mad bot faces off against a pack of ducks without any weapons?!");
        Negative6.Enqueue("You gotta help Negative out!");
        Negative6.Enqueue("END");
        NegativeConvo.Enqueue(Negative6);

        Queue<string> Negative7 = new Queue<string>(); //Mall Scene 3
        Negative7.Enqueue("Going to the mall, you realize that you in fact have a single shirt left that isn’t falling apart.");
        Negative7.Enqueue("While taking a look through various other pieces of clothing, you catch a flash of red out of the corner of your eye.");
        Negative7.Enqueue("It’s Negative, who seems to be perusing the pants aisle. It’s a bit odd considering they don’t really seem to wear pants…");
        Negative7.Enqueue("Anyway, they notice you and start approaching you with a disconcertingly aggressive stare, grabbing several shirts apparently without looking.");
        Negative7.Enqueue("They shove them at you.");
        Negative7.Enqueue("Negative: Take these. You really need a better fashion sense, and these should help with that.");
        Negative7.Enqueue("Well that’s surprising. They seem to be actually trying to be nice for once!");
        Negative7.Enqueue("Negative: This isn’t for you. This is so that I don’t start gushing coolant from my optics from how often I end up seeing you.");
        Negative7.Enqueue("Ah, yes, there’s the classic Negative again!");
        Negative7.Enqueue("END");
        NegativeConvo.Enqueue(Negative7);

        Queue<string> Negative8 = new Queue<string>(); //Park Scene 3
        Negative8.Enqueue("You’re headed into the park for some nice peaceful frisbee time, when you spot everyone’s favourite red, angry, violent, yet somewhat nice robot, Negative.");
        Negative8.Enqueue("You: Oh hey Negative, what brings you out to the park?");
        Negative8.Enqueue("Negative: I was just headed to do my weekly duck brawling, but since you really want me to, I guess I can spend some time with you.");
        Negative8.Enqueue("Negative: But only because you asked me to! Not because I want to or anything!");
        Negative8.Enqueue("Well this certainly is an odd, but a welcome change in Negative’s attitude!");
        Negative8.Enqueue("END");
        NegativeConvo.Enqueue(Negative8);

        Queue<string> Negative9 = new Queue<string>(); //Cafe Scene 3
        Negative9.Enqueue("As you’re riding your bike towards the cafe, you spot everyone's favourite angry robot, Negative.");
        Negative9.Enqueue("Today they’re standing at the front of the cafe looking strangely not very angry.");
        Negative9.Enqueue("You approach cautiously and say a greeting to them.");
        Negative9.Enqueue("You: Hey there Negative, what are you doing out here?");
        Negative9.Enqueue("Negative: Oh, hey there [Player Character], uh, fancy meeting you here.");
        Negative9.Enqueue("Negative: I was actually just thinking about giving you something interesting I found.");
        Negative9.Enqueue("You: Oh? That’s pretty unusual, what is it that you were gonna give me?");
        Negative9.Enqueue("Negative: Oh I found this free Twitch Prime sub that I got by linking up my Amazon Prime to my Twitch account, allowing me to sub to you for free.");
        Negative9.Enqueue("END");
        NegativeConvo.Enqueue(Negative9);

        Queue<string> Negative10 = new Queue<string>(); //Cafe Scene Affectionate
        Negative10.Enqueue("You see Negative in the cafe, sitting at a table in the back with a sour look on their… face/screen?");
        Negative10.Enqueue("You grab some coffee and go over to sit down with them.");
        Negative10.Enqueue("Negative:“Hey, jackass”.");
        Negative10.Enqueue("You both get to talking for a while about things like the weather, bad video games, and how much better Twitch is than Youtube.");
        Negative10.Enqueue("Eventually your conversation moves to what your current relationship is.");
        Negative10.Enqueue("Negative’s monitor displays a sly grin.");
        Negative10.Enqueue("Negative: “You realize I’m only gonna use you to pay for things, right? It’s not like I actually like you or anything…”");
        Negative10.Enqueue("Wow, what a goddamn tsundere.");
        Negative10.Enqueue("That’s like a line ripped directly from about a thousand different animes.");
        Negative10.Enqueue("END");
        NegativeConvo.Enqueue(Negative10);

        return (NegativeConvo);
    }

    Queue<Queue<string>> BuildNegativeResponse()
    {
        Queue<Queue<string>> NegativeConvoResponse = new Queue<Queue<string>>();

        Queue<string> Negative1Response = new Queue<string>(); // Park Scene 1 Choices
        Negative1Response.Enqueue("Joke’s on you, I won my last fight by 25 meters! *Run away time*");
        Negative1Response.Enqueue("Joke’s on you, I was the lightweight champion in high school, college, and also my job! *Fisticuffs time*");
        Negative1Response.Enqueue("Jokes on you, I wanted someone to completely knock me the fuck out today! *Concussion time?*");
        Negative1Response.Enqueue("*Immediately punches your face and knocks you on your ass*");
        Negative1Response.Enqueue("*Pauses briefly before punching you in your face*");
        Negative1Response.Enqueue("*Punches you, but it seems weaker than you expected*");
        Negative1Response.Enqueue("Negative: ");
        Negative1Response.Enqueue("END");
        NegativeConvoResponse.Enqueue(Negative1Response);

        Queue<string> Negative2Response = new Queue<string>(); // Mall Scene 1 Choices
        Negative2Response.Enqueue("YO WHAT THE FUCK IS YOUR PROBLEM LONG SANDWICH MAKING MAN?!");
        Negative2Response.Enqueue("YO WHAT THE FUCK IS YOUR PROBLEM NEGATIVE?!");
        Negative2Response.Enqueue("Hey, why doesn’t everyone get along? There’s no reason to yell or fight! We should all strive for peace!");
        Negative2Response.Enqueue("YOU WANT TO FUCKING FIGHT?! I’LL STAB YOU IN THE SANDWICH MAKING PARTS!");
        Negative2Response.Enqueue("WELCOME TO LONGSANDWICHWAY! Now you must die.");
        Negative2Response.Enqueue("I guess I could not fight… *leaves*");
        Negative2Response.Enqueue("Negative: ");
        Negative2Response.Enqueue("END");
        NegativeConvoResponse.Enqueue(Negative2Response);

        Queue<string> Negative3Response = new Queue<string>(); // Cafe Scene 1 Choices
        Negative3Response.Enqueue("I dunno, looks like one of the best games in existence. You’re clearly just a shitty casual gamer.");
        Negative3Response.Enqueue("Bad, clearly. But hey, you were the one who got the game.");
        Negative3Response.Enqueue("It looks like absolute garbage. Let’s make copious fun of it together!");
        Negative3Response.Enqueue("Yeah, I’m gonna need you to take ten running steps into that brick wall over there.");
        Negative3Response.Enqueue("I’m not going to say that you are wrong. That doesn’t mean you aren’t.");
        Negative3Response.Enqueue("I guess hell froze over because I actually liked that.");
        Negative3Response.Enqueue("Negative: ");
        Negative3Response.Enqueue("END");
        NegativeConvoResponse.Enqueue(Negative3Response);

        Queue<string> Negative4Response = new Queue<string>(); // Mall Scene 2 Choices
        Negative4Response.Enqueue("THEY DID WHAT?! LET ME AT EM!");
        Negative4Response.Enqueue("I’m not really sure what’s going on, but I’m sure they deserve it…");
        Negative4Response.Enqueue("You really should let them go, violence doesn’t solve anything!");
        Negative4Response.Enqueue("HEY, THAT’S PRETTY GOOD! I’LL EVEN LET YOU THROW IN A FEW PUNCHES, JUST FOR FUN!");
        Negative4Response.Enqueue("THE ONLY THING WORSE THAN COMPLIMENTS ARE PEOPLE WHO ARE NICE TO ME!");
        Negative4Response.Enqueue("I mean, I guess I could not beat this here robot up… Smell ya later...");
        Negative4Response.Enqueue("Negative: ");
        Negative4Response.Enqueue("END");
        NegativeConvoResponse.Enqueue(Negative4Response);

        Queue<string> Negative5Response = new Queue<string>(); // Cafe Scene 2 Choices
        Negative5Response.Enqueue("Hey, if you’re ripping off their arms, could I have them? I need them for a thing.");
        Negative5Response.Enqueue("Wow, only their arms? Go for the legs too, then they’ll be stuck sitting there doing nothing.");
        Negative5Response.Enqueue("Hey, I don’t think you should be threatening the staff like that…");
        Negative5Response.Enqueue("F-fine, I’m not doing it cause you asked me to or anything though!");
        Negative5Response.Enqueue("It’s limb tearing time! Then I’ll use their arms to make the coffee for myself!");
        Negative5Response.Enqueue("That’s it, get me the coffee now or I’ll really tear those arms off!");
        Negative5Response.Enqueue("Negative: ");
        Negative5Response.Enqueue("END");
        NegativeConvoResponse.Enqueue(Negative5Response);

        Queue<string> Negative6Response = new Queue<string>(); // Park Scene 2 Choices
        Negative6Response.Enqueue("You’ve been waiting for this! Time to bust out the anti-duck-matter gun you keep on you for duck related emergencies!");
        Negative6Response.Enqueue("Time to make them foot the bill for all the trouble they’ve quacked you through over the years!");
        Negative6Response.Enqueue("There must be a peaceful option! Time to open cross species diplomacy!");
        Negative6Response.Enqueue("Your help eliminating these terrors threatening me is greatly appreciated!");
        Negative6Response.Enqueue("How dare you interfere with MY brawl!");
        Negative6Response.Enqueue("Well, I guess you don’t need my help then.");
        Negative6Response.Enqueue("Negative: ");
        Negative6Response.Enqueue("END");
        NegativeConvoResponse.Enqueue(Negative6Response);

        Queue<string> Negative7Response = new Queue<string>(); // Mall Scene 3 Choices
        Negative7Response.Enqueue("YOU DISS THE SHIRT, YOU GET REAL HURT!");
        Negative7Response.Enqueue("I don’t want your fashion choices! I’ll make my own, like navy blue and neon orange!");
        Negative7Response.Enqueue("Thanks, I’m gonna wear all of them immediately!");
        Negative7Response.Enqueue("WHAT IF I JUST RIPPED OFF THE CLOTHES YOU WERE WEARING RIGHT NOW wait that came out wrong...");
        Negative7Response.Enqueue("WOULD YOU RATHER I JUST GO TO YOUR HOUSE AND BURN ALL THE OTHER CLOTHES YOU HAVE?!!");
        Negative7Response.Enqueue("Well, I guess that’s settled then. Fuck you and goodbye. *Leaves*");
        Negative7Response.Enqueue("Negative: ");
        Negative7Response.Enqueue("END");
        NegativeConvoResponse.Enqueue(Negative7Response);

        Queue<string> Negative8Response = new Queue<string>(); // Park Scene 3 Choices
        Negative8Response.Enqueue("Alright, but I’m not holding anything back, I hope you can keep up with my professional frisbee technique.");
        Negative8Response.Enqueue("If you insist, it’s not like I mind having you spend time with me!");
        Negative8Response.Enqueue("It would be great to spend time with my favourite robot!");
        Negative8Response.Enqueue("You absolute idiot! It’s not like I came to the park hoping to run into you or anything!");
        Negative8Response.Enqueue("You’re so pitiful that even I feel like I have to spend time with you!");
        Negative8Response.Enqueue("Wow, nevermind, I’m leaving then.");
        Negative8Response.Enqueue("Negative: ");
        Negative8Response.Enqueue("END");
        NegativeConvoResponse.Enqueue(Negative8Response);

        Queue<string> Negative9Response = new Queue<string>(); // Cafe Scene 3 Choices
        Negative9Response.Enqueue("Oh thank you so much, I really love when people give me their Twitch Prime subs!");
        Negative9Response.Enqueue("Wow, what a nice sell-out of a thing to do without actually selling out as you probably already had Amazon Prime in the first place!");
        Negative9Response.Enqueue("Wow, only a tier 1 sub? Not even worth mentioning.");
        Negative9Response.Enqueue("It’s not like I wanted to support your stream or anything! B-baka!");
        Negative9Response.Enqueue("I’m only doing this cause I had no else to give it to!");
        Negative9Response.Enqueue("Wow, rude. >:(");
        Negative9Response.Enqueue("Negative: ");
        Negative9Response.Enqueue("END");
        NegativeConvoResponse.Enqueue(Negative9Response);

        Queue<string> Negative10Response = new Queue<string>(); // Cafe Scene Affectionate Choices
        Negative10Response.Enqueue("Wow, that’s probably the worst thing you could do in a relationship. Like, up there with murdering someone so that you can be together forever.");
        Negative10Response.Enqueue("It’s okay, my long lost eighth cousin, nine times removed, was a drug mogul who ended up giving me 5 billion dollars. Go nuts!");
        Negative10Response.Enqueue("Cool, that’ll work up until I run out of money. Which will probably be tomorrow. But otherwise, go nuts!");
        Negative10Response.Enqueue("*Punches you. Not in a friendly way. Your arm is probably broken actually.*");
        Negative10Response.Enqueue("Pfft, who am I kidding, you probably couldn’t afford all the stuff that I want anyway.");
        Negative10Response.Enqueue("Fine. I guess I’ll just buy everything for YOU instead. How do you like that?");
        Negative10Response.Enqueue("Negative: ");
        Negative10Response.Enqueue("END");
        NegativeConvoResponse.Enqueue(Negative10Response);

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
