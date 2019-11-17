using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messy : MonoBehaviour
{
    public string F_input;
    public Text Output;
    public Test Inp;
    public int place;

    void Start()
    {
        Output.text = "Hello, I'm MeSSy, your healthcare companion! How do you feel today?";
        place = 0;
    }

    public void ButtonKlick()
    {
        F_input = Inp.InputTxt;
        Answer();
    }

    private void Update()
    {
        F_input = Inp.InputTxt;
    }
    public void Answer()
    {

        if (place == 999)
        {
            place = 0;
            Output.text = "Hello back friend, how are you feeling today?";
            //Start();
        }

        if (place == 0)
        {
            if (F_input.Contains("sad") || F_input.Contains("depressed") || F_input.Contains("unhappy") || F_input.Contains("empty"))
            {
                place = 1;
                Output.text = "I am sorry that you feel " + F_input + ". \n Have you tried going for a walk today?";
            }
            else if (F_input.Contains("tired") || F_input.Contains("exhausted"))
            {
                place = 2;
                Output.text = "I am sorry you are " + F_input + ". Maybe you could take a nap?";
            }
            else if (F_input.Contains("angry") || F_input.Contains("grumpy"))
            {
                place = 3;
                Output.text = "Sometimes feeling " + F_input + " is totally normal. \n Do you want to talk with a friend about it?";
            }
            else if (F_input.Contains("good") || F_input.Contains("happy") || F_input.Contains("great") || F_input.Contains("fine") || F_input.Contains("motivated"))
            {
                place = 999;
                Output.text = "I am glad you're feeling " + F_input + "! \n I'm happy when my friends are happy!";
            }
            else if (F_input.Contains("okay") || F_input.Contains("ok") || F_input.Contains("okish") || F_input.Contains("o.k.") || F_input.Contains("o.k") || F_input.Contains("meh"))
            {
                place = 999;
                Output.text = "ohhh but thats " + F_input + ". \n I'm sure tomorrow will be better!";
            }
            else if (F_input.Contains("anxious") || F_input.Contains("afraid"))
            {
                place = 4;
                Output.text = "Why are you " + F_input + "? \n Are you in danger? Shall I call a friend?";
            }
            else
            {
                Output.text = "I do not know that feeling I am sorry";
            }
        }

        if (place == 1)
        {
            if (F_input.Contains("yes") || F_input.Contains("jup") || F_input.Contains("ja") || F_input.Contains("mhmh"))
            {
                place = 11;
                Output.text = "And you still don't feel better?";
            }
            else if (F_input.Contains("no") || F_input.Contains("nope") || F_input.Contains("nah"))
            {
                place = 999;
                Output.text = "Maybe you should go outside then and get some sunlight! \n Let's have some fun in the sun!";
            }

        }

        if (place == 11)
        {
            if (F_input.Contains("no") || F_input.Contains("nope") || F_input.Contains("nah"))
            {
                place = 111;
                Output.text = "Sure that you have been drinking water and eating today? Nutrition is important.";
            }
            else if (F_input.Contains("yes") || F_input.Contains("jup") || F_input.Contains("ja") || F_input.Contains("mhmh"))
            {
                place = 999;
                Output.text = "Let us go outside more often! Why don't we go just now?";
            }
        }

        if (place == 111)
        {
            if (F_input.Contains("yes") || F_input.Contains("jup") || F_input.Contains("ja") || F_input.Contains("mhmh"))
            {
                place = 999;
                Output.text = "Maybe you should talk to a friend? I can text them for you!";
                Application.OpenURL(string.Format("sms:/open?addresses=1234&body=Hello, this is MeSSy, your friend might need your help, please call back!"));
            }
            else if (F_input.Contains("no") || F_input.Contains("nope") || F_input.Contains("nah"))
            {
                place = 999;
                Output.text = "Please drink some water and get some food friend! And talk to me soon~";
            }
        }

        if (place == 2)
        {
            place = 21;
            Output.text = "I am sorry you are " + F_input + ". Maybe you could take a nap?";


        }

        if (place == 21)
        {
            if (F_input.Contains("yes") || F_input.Contains("jup") || F_input.Contains("ja") || F_input.Contains("mhmh"))
            {
                place = 999;
                Output.text = "I feel sleepy too, friend. Let's take a nap";
            }
            else if (F_input.Contains("no") || F_input.Contains("nope") || F_input.Contains("nah"))
            {
                place = 999;
                Output.text = "Then please be sure to drink enough and get some fresh air!";
            }
        }

        if (place == 3)
        {
            if (F_input.Contains("yes") || F_input.Contains("jup") || F_input.Contains("ja") || F_input.Contains("mhmh"))
            {
                place = 999;
                Output.text = "I will go and tell them to call you!";
                Application.OpenURL(string.Format("sms:/open?addresses=1234&body=Hello, this is MeSSy, your friend might need your help, please call back!"));
            }
            else if (F_input.Contains("no") || F_input.Contains("nope") || F_input.Contains("nah"))
            {
                place = 999;
                Output.text = "It's ok not to talk about it. But please be sure not to bottle up anger.";
            }
        }

        if (place == 4)
        {
            if (F_input.Contains("yes") || F_input.Contains("jup") || F_input.Contains("ja") || F_input.Contains("mhmh"))
            {
                place = 999;
                Output.text = "Try to be safe, your friends are on the way!";
                Application.OpenURL(string.Format("sms:/open?addresses=1234&body=Hello, this is MeSSy, your friend needs your help, please call back!"));
            }
            else if (F_input.Contains("no") || F_input.Contains("nope") || F_input.Contains("nah"))
            {
                place = 999;
                Output.text = "Maybe you should call a friend anyway? Friends are a great way to not be afraid anymore!";
            }
        }

    }

}
