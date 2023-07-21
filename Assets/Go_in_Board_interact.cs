using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Go_in_Board_interact : MonoBehaviour
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
                intText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    intText.SetActive(false);
                    Player_cam.SetActive(false);
                    Board_cam.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    Marker.SetActive(true);
                }
            }
            else
            {
                intText.SetActive(false);
            }
        }
    }
}
