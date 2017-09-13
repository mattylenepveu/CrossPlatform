using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour {


    //----------------------------------------------------
    // Function to be called every frame of the program
    // Rotates the coins every frame on the X-axis
    //----------------------------------------------------
    void Update ()
    {
        if (gameObject.name == "Coin") //Only effects objects with the name "Coin"
        {
            transform.Rotate(3, 0, 0); // Rotates on the X-axis
        }
    }
}
