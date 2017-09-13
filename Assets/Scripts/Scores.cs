using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scores : MonoBehaviour {


    //----------------------------------------------------
    // Function to be called every frame
    // Displays the time from the GM script in 3d text
    //----------------------------------------------------
    void Update ()
    {
        if (gameObject.name == "Time") // Checks if the 3D texts name is Time
        {
            // Gets component and adds "time:" and the current time from the GM script
            GetComponent<TextMesh>().text = "Time : " + Mathf.Round(GM.timeTotal * 100f) / 100f + " seconds"; 
        }
    }
}
