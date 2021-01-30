using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerController : MonoBehaviour
{
    public Transform drawer;

    private float drawerLenght = 0;
    public float animLenght = .75f;
    private float animTime = 0;
    private bool isAnimPlaying = false;

    private bool isClosed;
    
    void Update()
    {
        
        if(isAnimPlaying)
        {
            if (!isClosed)
                animTime += Time.deltaTime;
            else
                animTime -= Time.deltaTime;

            float percent = animTime / animLenght;
            if (percent < 0 && isClosed)
            {
                percent = 0;
                isAnimPlaying = false;
            }
            if(percent> 1 && !isClosed)
            {
                percent = 1;
                isAnimPlaying = false;
            }

            drawer.localPosition = new Vector3( drawerLenght * percent, 0, 0);
        }

    }

    public void PlayerInteract(Vector3 position)
    {
        if (isAnimPlaying) return;

        isClosed = !isClosed;
        isAnimPlaying = true;

        Vector3 disToPlayer = position - transform.position;
        disToPlayer = disToPlayer.normalized;

        if (isClosed) animTime = animLenght;
        else animTime = 0;
    }
}
