using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleControl : MonoBehaviour
{
    [SerializeField] GameObject DoorBlocker01;
    [SerializeField] GameObject DoorBlocker02;

   public static bool scaleOne = false;
   public static bool scaleTwo = false;
   public static bool wonScale = false;

    void Start()
    {
        
    }


    void Update()
    {
        if (scaleOne && scaleTwo)
        {
            wonScale = true;
            Destroy(DoorBlocker01);
            Destroy(DoorBlocker02);
        }
    }
}
