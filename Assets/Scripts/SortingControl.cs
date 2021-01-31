using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingControl : MonoBehaviour
{
    // Start is called before the first frame update
    public static int numInDonate = 0;
    public static int numInKeep = 0;
    public static bool isTeddyIn = false;
    public static bool isTruckIn = false;
    public static bool isDinoIn = false;
    public static bool hasWonSort = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDinoIn && isTeddyIn && isTruckIn && numInKeep == 3 && numInDonate == 7)
            print("didIT");
    }

}
