using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scales : MonoBehaviour
{
    private float weightOnScale = 0f;
    private float targetWeight = 11f;
   
    public int scaleWon = 0;
    public Text scaleText; 

 

    void Start()
    {
        
    }

   
    void Update()
    {
        scaleText.text = weightOnScale.ToString() + ".0";
        if (weightOnScale == targetWeight)
        {
            if (this.tag == "ScaleOne") ScaleControl.scaleOne = true;
            if (this.tag == "ScaleTwo") ScaleControl.scaleTwo = true;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("BoxWeight3") )
        {
            weightOnScale += other.gameObject.GetComponent<WeightedBoxes>().boxWeight;
           

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("BoxWeight3"))
        {
            weightOnScale -= other.gameObject.GetComponent<WeightedBoxes>().boxWeight;
        }
    }
}
