using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoPuzzle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject DoorBlocker03;
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (Inventory.main.hasPhoto01 && Inventory.main.hasPhoto02 && Inventory.main.hasPhoto03)
        {
            Destroy(DoorBlocker03);
        }
    }
}
