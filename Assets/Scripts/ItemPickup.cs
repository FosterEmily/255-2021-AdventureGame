using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public void PlayerInteract()
    {
       if (this.tag == "Key")
       {
           Inventory.main.hasKey = true;
           Destroy(gameObject);
       }
       if (this.tag == "Photo01")
       {
           Inventory.main.hasPhoto01 = true;
           Destroy(gameObject);
       }
       if (this.tag == "Photo02")
       {
           Inventory.main.hasPhoto02 = true;
           Destroy(gameObject);
       }
       if (this.tag == "Photo03")
       {
           Inventory.main.hasPhoto03 = true;
           Destroy(gameObject);
       }
       if (SortingControl.hasWonSort)
       {
           if (this.tag == "Truck") Inventory.main.hasTruck = true;
           if (this.tag == "Teddy") Inventory.main.hasTeddy = true;
           if (this.tag == "Dino") Inventory.main.hasDino = true;
           Destroy(gameObject);
        }
       if (this.tag == "Calendar")
       {
           Inventory.main.hasCalendar = true;
           Destroy(gameObject);
       }
        if (this.tag == "Shoe" && Inventory.main.hasKey)
        {
            Inventory.main.shoeNum++;
            if (Inventory.main.shoeNum == 2) Inventory.main.hasShoe = true;
            Destroy(gameObject);
        }
        //remeber we picked up the object
    }
}
