using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    [SerializeField] Text goalText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Inventory.main.hasShoe) goalText.text = ("Time to leave.");
        else if (Inventory.main.hasKey) goalText.text = ("Almost forgot my shoes.");
        else if (PinPadControl.wonPin) goalText.text = ("...I just need my key.");
        else if (SortingControl.hasWonSort) goalText.text = ("What was the PIN again?");
        else if (PhotoPuzzle.hasPhotos) goalText.text = ("Theres not much room at the new house so we are only keeping Mitsuo's 3 favourite toys and donating the rest. I need to sort them.");
        else if (ScaleControl.wonScale) goalText.text = ("I need to grab my three pictures of Mitsuo");
        else if (!ScaleControl.wonScale) goalText.text = ("I should stack these boxes on those two scales. Each stack should weigh the same.");
    }
}
