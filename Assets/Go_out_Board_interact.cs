using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Go_out_Board_interact : MonoBehaviour
{

    public float interactionDistance;

    public GameObject intText;

    public GameObject Player_cam;
    public GameObject Board_cam;
    public GameObject Marker;


    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactionDistance))
        {
            if (hit.collider.gameObject.tag == "Whiteboard")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    intText.SetActive(true);
                    Player_cam.SetActive(true);
                    Board_cam.SetActive(false);
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    Marker.SetActive(false);
                }
            }
            else
            {
                intText.SetActive(false);
            }
        }
    }
}
