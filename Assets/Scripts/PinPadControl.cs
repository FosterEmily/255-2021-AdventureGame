using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinPadControl : MonoBehaviour
{
    public static string pinNum = null;
    [SerializeField] Text pinText;
    public static bool wonPin = false; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pinText.text = pinNum;
        if (pinNum != null)
        {
            if (pinNum.Length >= 4)
            {
                if (pinNum == "1127")
                {
                    wonPin = true;
                    
                    
                }
                pinNum = null;
            }
        }
        // print(wonPin);
    }
}
