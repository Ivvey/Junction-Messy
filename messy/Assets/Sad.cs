using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sad : MonoBehaviour
{
    public Messy mess;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void sad()
    {
        mess.Output.text = "I am sorry that you feel " + mess.F_input + ". \n\n Have you tried going for a walk today?";
        //Invoke("WaitforSeconds", 5);
        //Output.text = "Have you tried going for a walk today?";
        if (mess.F_input.Contains("Yes") || mess.F_input.Contains("jup") || mess.F_input.Contains("ja") || mess.F_input.Contains("mhmh") || mess.F_input.Contains("yes"))
        {
            mess.Output.text = "And you still don't feel better?";

            if (mess.F_input.Contains("no") || mess.F_input.Contains("nope") || mess.F_input.Contains("nah"))
            {
                mess.Output.text = "Sure that you have been drinking water and eating today? Nutrition is important.";

                if (mess.F_input.Contains("Yes") || mess.F_input.Contains("jup") || mess.F_input.Contains("ja") || mess.F_input.Contains("mhmh"))
                {
                    mess.Output.text = "Maybe you should talk to a friend? I can text them for you!";
                    Application.OpenURL(string.Format("sms:/open?addresses=069911383999&body=Hello, this is MeSSy, your friend might need your help, please call back!"));
                }
                else if (mess.F_input.Contains("no") || mess.F_input.Contains("nope") || mess.F_input.Contains("nah"))
                {
                    mess.Output.text = "Please drink some water and get some food friend! And talk to me soon~";
                }
            }
            else if (mess.F_input.Contains("Yes") || mess.F_input.Contains("jup") || mess.F_input.Contains("ja") || mess.F_input.Contains("mhmh"))
            {
                mess.Output.text = "Let us go outside more often! Why don't we go just now?";
            }
        }
        else if (mess.F_input.Contains("no") || mess.F_input.Contains("nope") || mess.F_input.Contains("nah"))
        {
            mess.Output.text = "Maybe you should go outside then and get some sunlight! Let's have some fun in the sun!";
        }
    }
}
