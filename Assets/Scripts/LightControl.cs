using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    private bool isOn;
    [SerializeField] GameObject light;
    public void TurnLight()
    {
        if (light.activeSelf == false) light.SetActive(true);
        else light.SetActive(false);
    }
}
