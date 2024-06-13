using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    [SerializeField] float MouseSensitivity = 100;

    public Transform orientation;
    public Transform CamPos;

    public Transform HandPos;

    public GameObject Camera;

    public GameObject Hands;

    public GameObject Player;

    float YRot;
    float XRot;


    Vector3 offset = new Vector3(0, 0, 0.8f);


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

        //grab mouse Input
        float MouseX = Input.GetAxisRaw("Mouse X") * MouseSensitivity * Time.deltaTime;
        float MouseY = Input.GetAxisRaw("Mouse Y") * MouseSensitivity * Time.deltaTime;

        YRot += MouseX;

        XRot -= MouseY;
        XRot = Mathf.Clamp(XRot, -90f, 90f);

        //Rotate player CAM and orientation
        //X axis rotation
        transform.rotation = Quaternion.Euler(XRot, YRot, 0);

        //Y Axis Rotation
        orientation.rotation = Quaternion.Euler(0, YRot, 0);

        FollowCam();
    }

    void FollowCam()
    {
        Camera.transform.position = CamPos.transform.position;

        //HandPos.transform.position = Player.transform.rotation;

        Hands.transform.position = HandPos.transform.position;

        Hands.transform.rotation = Camera.transform.rotation;
    }

}
