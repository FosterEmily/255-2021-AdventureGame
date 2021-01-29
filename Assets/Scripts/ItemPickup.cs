using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public void PlayerInteract()
    {
       if(this.tag == "Key") Inventory.main.hasKey = true;
       if(this.tag == "Photo01") Inventory.main.hasPhoto01 = true;
       if(this.tag == "Photo02") Inventory.main.hasPhoto02 = true;
       if(this.tag == "Photo03") Inventory.main.hasPhoto03 = true;
       if(this.tag == "Calendar") Inventory.main.hasCalendar = true;
        //remeber we picked up the object
        print("Picked Up" + this.tag);
        Destroy(gameObject);
    }

}
