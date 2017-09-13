using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour {
    
    // Float value for the speed of the elevator
    private float m_fSpeed = 1;

    // Float for the timer
    private float m_fTimer;

    //----------------------------------------------------
    // Function to be called at every frame
    // updates timer
    // Transforms elevators position
    //----------------------------------------------------
    void Update ()
    {
        // Updates the timer every frame
        m_fTimer += Time.deltaTime;

        if(m_fTimer < 2) // If timer is less then 0
            transform.position += transform.up * m_fSpeed * Time.deltaTime; //Transforms platforms position up by its speed

        if (m_fTimer > 2 && m_fTimer < 4)  // is timer is between 2 and 4
            transform.position -= transform.up * m_fSpeed * Time.deltaTime; // Transforms platforms position down by the speed

        if (m_fTimer > 6) // at 6 seconds reset the timer
            m_fTimer = 0;
    }
}
