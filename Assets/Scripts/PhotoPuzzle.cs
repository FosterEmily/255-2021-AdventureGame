using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoPuzzle : MonoBehaviour
{
    [SerializeField] GameObject DoorBlocker03;
    public static bool hasPhotos;
    // Update is called once per frame
    public void Update()
    {
        if (Inventory.main.hasPhoto01 && Inventory.main.hasPhoto02 && Inventory.main.hasPhoto03)
        {
            hasPhotos = true;
            Destroy(DoorBlocker03);
        }
    }
}
