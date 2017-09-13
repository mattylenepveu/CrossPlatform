using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    // Game objec to attach camera too
    public GameObject player;

    // Base offset from behind the selected game object
    private Vector3 offset;

    //----------------------------------------------------
    // Function to be called on the start of the program
    // Sets the offset position of the camera
    //----------------------------------------------------
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    //----------------------------------------------------
    // LateUpdate to be called after all update
    // Update dates the camera position when the player moves
    //----------------------------------------------------
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
