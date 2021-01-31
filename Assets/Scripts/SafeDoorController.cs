using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeDoorController : MonoBehaviour
{ 
    public Transform safeHindge;

//summary
private float doorAngle = 0;
public float animLength = .5f;
private float animTime = 0;
private bool isAnimPlaying = false;

private bool isClosed = true;


void Update()
{
    //playing anim
    if (isAnimPlaying)
    {
        if (!isClosed)
            animTime += Time.deltaTime;
        else
            animTime -= Time.deltaTime;

        float percent = animTime / animLength;
        if (percent < 0 && isClosed)
        {
            percent = 0;
            isAnimPlaying = false;

        }
        if (percent > 1 && !isClosed)
        {
            percent = 1;
            isAnimPlaying = false;
        }

            safeHindge.localRotation = Quaternion.Euler(0, doorAngle * percent, 0);
    }

}

public void PlayerInteract(Vector3 position)
{
        print("IS COLLING");
    if (isAnimPlaying) return; // does nothing


        if (!PinPadControl.wonPin) return;


        isClosed = !isClosed; // toggles state

    if (!isClosed)
    {
        doorAngle = -90;
       
    }


    isAnimPlaying = true;

    if (isClosed) animTime = animLength;
    else animTime = 0;


}

}
