using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Donate") SortingControl.numInDonate++;
        if (other.tag == "Keep") SortingControl.numInKeep++;
        //print("donate " + SortingControl.numInDonate + "keep " + SortingControl.numInKeep + "teddy " + SortingControl.isTeddyIn + " truck " + SortingControl.isTruckIn + " dino " + SortingControl.isDinoIn);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Donate") SortingControl.numInDonate--;
        if (other.tag == "Keep")
        {
            SortingControl.numInKeep--;
            if (this.tag == "Teddy") SortingControl.isTeddyIn = false;
            if (this.tag == "Truck") SortingControl.isTruckIn = false;
            if (this.tag == "Dino") SortingControl.isDinoIn = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Keep" && this.tag == "Teddy") SortingControl.isTeddyIn = true;
        if (other.tag == "Keep" && this.tag == "Truck") SortingControl.isTruckIn = true;
        if (other.tag == "Keep" && this.tag == "Dino") SortingControl.isDinoIn = true;
    }

}
