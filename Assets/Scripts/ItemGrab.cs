using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGrab : MonoBehaviour
{

    private Vector3 offset;
    private float mouseZLocation;


    public void PlayerInteract()
    {
        print("grab");
        //offset = gameObject.transform.position - GetMouseWorldPos();

        ///transform.position = GetMouseWorldPos() + offset;

    }
   // private Vector3 GetMouseWorldPos()
   // {
        //get location of mouse
 //       Vector3 mousePoint = Input.mousePosition;
 //       mousePoint.z = mouseZLocation;
 //       return Camera.main.ScreenToWorldPoint(mousePoint);
//    }

}
