using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] Transform playerCamera = null;
    [SerializeField] Rigidbody rb;
    [SerializeField] float mouseSensitivity = 3.5f;
    [SerializeField] float walkSpeed = 5.0f;
    [SerializeField] float gravity = -13.0f;
    [SerializeField] [Range(0.0f, 0.5f)] float moveSmoothTime = 0.3f;
    [SerializeField] [Range(0.0f, 0.5f)] float mouseSmoothTime = 0.03f;
    [SerializeField] GameObject inventoryObj;
    [SerializeField] GameObject pauseObj;
    public static int gameScreen = 0;
    [SerializeField] bool lockCursor = true;
    float cameraPitch = 0.0f;
    float velocityY = 0.0f;
    CharacterController controller = null;
    Vector2 currentDir = Vector2.zero;
    Vector2 currentDirVelocity = Vector2.zero;
    Vector2 currentMouseDelta = Vector2.zero;
    Vector2 currentMouseDeltaVelocity = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        //locks cursor to the middle of the screen and remove the icon
        if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (!inventoryObj.activeSelf && !pauseObj.activeSelf)
        {
            UpdateMouseLook();
            Time.timeScale = 1;
        }
        else Time.timeScale = 0;
        UpdateMovement();
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (inventoryObj.activeSelf == false && gameScreen == 0)
            {
                inventoryObj.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                gameScreen = 1;
            }
            else if (gameScreen == 1)
            {
                inventoryObj.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                gameScreen = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (pauseObj.activeSelf == false && gameScreen == 0)
            {
                pauseObj.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                gameScreen = 2;
            }
            else if (gameScreen == 2)
            {
                pauseObj.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                gameScreen = 0;
            }
        }
    }

    //Camera movements
    void UpdateMouseLook()
    {
        Vector2 targetmouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        currentMouseDelta = Vector2.SmoothDamp(currentMouseDelta, targetmouseDelta, ref currentMouseDeltaVelocity, mouseSmoothTime);
        cameraPitch -= currentMouseDelta.y * mouseSensitivity;
        cameraPitch = Mathf.Clamp(cameraPitch, -90.0f, 90.0f);
        playerCamera.localEulerAngles = Vector3.right * cameraPitch;
        transform.Rotate(Vector3.up * currentMouseDelta.x * mouseSensitivity);
    }
    //Character Movement
    void UpdateMovement()
    {
        Vector2 targetDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        targetDir.Normalize();
        currentDir = Vector2.SmoothDamp(currentDir, targetDir, ref currentDirVelocity, moveSmoothTime);
        //adds falling to the character
        if (controller.isGrounded)
        {
            velocityY = 0.0f;
        }
        velocityY += gravity * Time.deltaTime;
        Vector3 velocity = (transform.forward * currentDir.y + transform.right * currentDir.x) * walkSpeed + Vector3.up * velocityY;
        controller.Move(velocity * Time.deltaTime);
        //   if(Input.GetKeyDown(KeyCode.Space))
        //  {
        //      walkSpeed = 12;
        //  }

    }


}
