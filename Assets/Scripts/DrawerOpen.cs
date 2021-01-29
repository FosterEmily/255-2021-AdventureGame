using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerOpen : MonoBehaviour
{
    public Animator drawer1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DrawerControl()
    {
        print("opening");
        if (!drawer1.GetBool("isOpened")) drawer1.SetBool("isOpened", true);
        else if (drawer1.GetBool("isOpened")) drawer1.SetBool("isOpened", false);

    }
}
