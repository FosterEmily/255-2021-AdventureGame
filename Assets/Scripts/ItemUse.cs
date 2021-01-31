using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUse : MonoBehaviour
{
    public static string itemHand = " ";
    [SerializeField] GameObject imgHand;
    [SerializeField] Sprite photo1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PickPhoto1()
    {
        imgHand.GetComponent<Image>().sprite = photo1;
        imgHand.SetActive(true);
    }


}
