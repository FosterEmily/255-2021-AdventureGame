using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLocation : MonoBehaviour
{
    private Vector3 startingLoc;
    private Vector3 startingRot;
    // Start is called before the first frame update
    public void Start()
    {
        startingLoc = this.transform.position;
        startingRot = this.transform.eulerAngles;
    }

    // Update is called once per frame
    public void Update()
    {
        if ((this.transform.position.y < 0 || this.transform.position.y > 12) && this.transform.parent == null)
        {
            print("worked");
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            this.transform.position = startingLoc;
            this.transform.eulerAngles = startingRot;
        }
    }
}
