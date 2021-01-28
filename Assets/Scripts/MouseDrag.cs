using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 mOffset;
    private float mzCoord;
    void OnMouseDown()
    {
        //if mouse clicks on item, move item to mouse position
        mzCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }
    private Vector3 GetMouseWorldPos()
    {
        //get location of mouse
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mzCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    void OnMouseDrag()
    {
        //set position to mouse position
        transform.position = GetMouseWorldPos() + mOffset;
    }
}
