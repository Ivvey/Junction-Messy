using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public InputField IPF;
    //public Text Out;
    [HideInInspector]
    public string InputTxt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Text()
    {
        InputTxt = IPF.text;
        Debug.Log(InputTxt);
    }
}
