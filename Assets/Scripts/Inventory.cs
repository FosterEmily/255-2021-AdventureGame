using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    //singleton design pattern
    private static Inventory _main = new Inventory();
    public static Inventory main
    {
        get { return _main; }
    }

    public bool hasKey = false;
    public bool hasPhoto01 = false;
    public bool hasPhoto02 = false;
    public bool hasPhoto03 = false;
    public bool hasCalendar = false;
   // public bool 


    private void Start()
    {
        if (_main == null)
        {
            _main = this;
            DontDestroyOnLoad(gameObject);
            //dont destroy this object when loading a new scenes

        }
        else
        {
            Destroy(gameObject); //destroy extra inventory sytem
        }
    }

}
