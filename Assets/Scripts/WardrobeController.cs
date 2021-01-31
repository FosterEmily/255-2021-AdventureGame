using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardrobeController : MonoBehaviour
{

    public Transform doorOne;
    public Transform doorTwo;

    //summary
    private float leftDoorAngle = 0;
    private float rightDoorAngle = 0;
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

            doorOne.localRotation = Quaternion.Euler(0,leftDoorAngle * percent, 0);
            doorTwo.localRotation = Quaternion.Euler(0, rightDoorAngle * percent, 0);
        }

    }

    public void PlayerInteract(Vector3 position)
    {
        print("ISTOUCHING");

        print(isAnimPlaying);

        if (isAnimPlaying) return; // does nothing


      

        Vector3 disToPlayer = position - transform.position;
        disToPlayer = disToPlayer.normalized;

        isClosed = !isClosed; // toggles state

        if (!isClosed)
        {
            rightDoorAngle = -90;
            leftDoorAngle = 90;
            
        }


        isAnimPlaying = true;

        if (isClosed) animTime = animLength;
        else animTime = 0;


    }

}