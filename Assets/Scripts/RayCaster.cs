using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //did the user click on this game tick?
        if (cam != null && Input.GetButtonDown("Fire1"))
        {
            //shoot a ray into the scene

            Ray ray = new Ray(cam.transform.position, cam.transform.forward);
            RaycastHit hit;

            //????
            //draw ray
            //   Debug.DrawRay(ray.origin, ray.direction, Color.black, .5f);

            if (Physics.Raycast(ray, out hit))
            {
                //raycast hit controller in scene

                DoorController door = hit.transform.GetComponentInParent<DoorController>();
                if (door != null) door.PlayerInteract(transform.parent.position);

                ItemPickup pickup = hit.transform.GetComponent<ItemPickup>();
                if (pickup != null) pickup.PlayerInteract();

                ItemGrab grab = hit.transform.GetComponent<ItemGrab>();
                if (pickup != null) pickup.PlayerInteract();



            }

        }
    }
}
