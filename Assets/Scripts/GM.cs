using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour {
    
    // Public variable for coins collected
    public static int coinTotal = 0;
    // Public variable for Time spent
    public static float timeTotal = 0.0f;

    //----------------------------------------------------
    // Function to be called on the start of the program
    // Sets the time and coins values to 0 at start of level
    //----------------------------------------------------
    void Start ()
    {
        timeTotal = 0.0f;
        coinTotal = 0;
	}

    //----------------------------------------------------
    // Function to be called every frame
    // Increases time by 1 every second
    //----------------------------------------------------
    void Update ()
    {
        timeTotal += Time.deltaTime; // increases value every second
    }
}
