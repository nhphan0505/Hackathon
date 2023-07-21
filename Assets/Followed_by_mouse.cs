using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.PlayerSettings;

public class Followed_by_mouse : MonoBehaviour
{

    Vector3 pos;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.mousePosition.x);
        Debug.Log(Input.mousePosition.y);
        Debug.Log(Input.mousePosition.z);   
        pos = Input.mousePosition;
        pos.z = 0.989f;
        transform.position = Camera.main.ScreenToWorldPoint(pos);
    }
}
