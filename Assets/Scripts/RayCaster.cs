using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    private Camera cam;
    [SerializeField] Animator crosshairAnim;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //did the user click on this game tick?
        if (cam != null)
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
                DrawerController drawer = hit.transform.GetComponentInParent<DrawerController>();
                ItemPickup pickup = hit.transform.GetComponent<ItemPickup>();
                ItemGrab grab = hit.transform.GetComponent<ItemGrab>();
                DrawerOpen open = hit.transform.GetComponent<DrawerOpen>();
                if (open != null || grab != null || pickup != null || drawer != null || door != null) crosshairAnim.SetBool("isHighlight", true);
                else crosshairAnim.SetBool("isHighlight", false);
                if (Input.GetButtonDown("Fire1"))
                {
                    if (open != null) open.DrawerControl();
                    if (grab != null) grab.PlayerInteract();
                    if (pickup != null) pickup.PlayerInteract();
                    if (drawer != null) drawer.PlayerInteract(transform.parent.position);
                    if (door != null) door.PlayerInteract(transform.parent.position);
                }
            }

        }
    }
}
