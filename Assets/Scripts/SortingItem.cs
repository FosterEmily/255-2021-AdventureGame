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
        print(SortingControl.numInDonate);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Donate") SortingControl.numInDonate--;
    }

}
