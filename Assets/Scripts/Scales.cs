using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scales : MonoBehaviour
{
    private float weightOnScale = 0f;
    private float targetWeight = 11f;
   
    public int scaleWon = 0;
  

 

    void Start()
    {
        
    }

   
    void Update()
    {
        print(scaleWon);
       // print(doOnce);

        if (weightOnScale == targetWeight)
        {
            if (this.tag == "ScaleOne") ScaleControl.scaleOne = true;
            if (this.tag == "ScaleTwo") ScaleControl.scaleTwo = true;

        }

       

           // print(weightOnScale);
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
