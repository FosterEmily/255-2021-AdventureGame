using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGrab : MonoBehaviour
{

    //private Vector3 offset;
    //private float mouseZLocation;

    float throwForce = 600;
    Vector3 objectPos;
    float distance;

    public bool canHold = true;
    public GameObject item;
    public GameObject tempParent;
    public bool isHolding = false;

    // Update is called once per frame
    public void Update()
    {

        distance = Vector3.Distance(item.transform.position, tempParent.transform.position);
        //Check if isholding
        if (isHolding == true)
        {
            item.GetComponent<Rigidbody>().velocity = Vector3.zero;
            item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            item.transform.SetParent(tempParent.transform);
            item.GetComponent<Rigidbody>().detectCollisions = true;
            if (Input.GetMouseButtonDown(1))
            {
                
                item.GetComponent<Rigidbody>().AddForce(tempParent.transform.forward * throwForce);
                print(tempParent.transform.forward * throwForce);
                isHolding = false;

            }
            if (Input.GetMouseButtonUp(0)) isHolding = false;
        }
        else
        {
            objectPos = item.transform.position;
            item.transform.SetParent(null);
            item.GetComponent<Rigidbody>().useGravity = true;
            item.GetComponent<Rigidbody>().isKinematic = false;
            item.transform.position = objectPos;
        }

    }

    public void OnMouseDown()
    {

    }
    public void OnMouseUp()
    {
        isHolding = false;
    }
public void PlayerInteract()
    {
        isHolding = true;
        item.GetComponent<Rigidbody>().useGravity = false;
        item.GetComponent<Rigidbody>().isKinematic = true;
        item.GetComponent<Rigidbody>().detectCollisions = true;
        //mouseZLocation = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        //offset = gameObject.transform.position - GetMouseWorldPos();

        //transform.position = GetMouseWorldPos() + offset;

    }
    //private Vector3 GetMouseWorldPos()
    //{
        //get location of mouse
        //Vector3 mousePoint = Input.mousePosition;
        //mousePoint.z = mouseZLocation;
        //return Camera.main.ScreenToWorldPoint(mousePoint);
    //}

}
