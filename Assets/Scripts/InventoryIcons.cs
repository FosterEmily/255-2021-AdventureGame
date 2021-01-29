using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryIcons : MonoBehaviour
{
    [SerializeField] GameObject keyImg;
    [SerializeField] GameObject photo1Img;
    [SerializeField] GameObject photo2Img;
    [SerializeField] GameObject photo3Img;
    [SerializeField] GameObject calendar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Inventory.main.hasKey) keyImg.SetActive(true);
        if (Inventory.main.hasPhoto01) photo1Img.SetActive(true);
        if (Inventory.main.hasPhoto02) photo2Img.SetActive(true);
        if (Inventory.main.hasPhoto03) photo3Img.SetActive(true);
        if (Inventory.main.hasCalendar) calendar.SetActive(true);
    }
}
