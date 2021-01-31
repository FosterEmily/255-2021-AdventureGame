using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryIcons : MonoBehaviour
{
    [SerializeField] GameObject keyImg;
    [SerializeField] GameObject photo1Img;
    [SerializeField] GameObject photo2Img;
    [SerializeField] GameObject photo3Img;
    [SerializeField] GameObject truckImg;
    [SerializeField] GameObject teddyImg;
    [SerializeField] GameObject dinoImg;
    [SerializeField] GameObject calendar;
    [SerializeField] GameObject shoeImg;
    // Update is called once per frame
    void Update()
    {
        if (Inventory.main.hasKey) keyImg.SetActive(true);
        if (Inventory.main.hasPhoto01) photo1Img.SetActive(true);
        if (Inventory.main.hasPhoto02) photo2Img.SetActive(true);
        if (Inventory.main.hasPhoto03) photo3Img.SetActive(true);
        if (Inventory.main.hasCalendar) calendar.SetActive(true);
        if (Inventory.main.hasTruck) truckImg.SetActive(true);
        if (Inventory.main.hasTeddy) teddyImg.SetActive(true);
        if (Inventory.main.hasDino) dinoImg.SetActive(true);
        if (Inventory.main.hasShoe) shoeImg.SetActive(true);
    }
}
