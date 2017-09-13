using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Public float for speed
    public float speed;

    //----------------------------------------------------
    // Function to be called every frame
    // Checks for input on the horizontal input or vertical
    // Updates the movement vector3 by the input
    // Adds force to the objects rigidbody by the new Vector3
    //----------------------------------------------------
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // checks for horizontal input
        float moveVertical = Input.GetAxis("Vertical"); // Checks vertical input

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); // Creates new vector3 for movement

        gameObject.GetComponent<Rigidbody>().AddForce(movement * speed); // Adds force to the rigid body by the new vector3
    }

    //----------------------------------------------------
    // function called when object collides with another
    // checks what it collides with and loads scene according to that
    // Parameters:
    //      Collision other: the object that this one is colliding with
    //
    //----------------------------------------------------
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Portal") // checks if the tag is portal
        {
            SceneManager.LoadScene("Leaderboard"); // loads leaderboard scene
        }
        if (other.gameObject.name == "DeathZone") // Checks if name is deathZone
        {
            SceneManager.LoadScene("Game"); // Loads Game scene
        }
    }

    //----------------------------------------------------
    // Function to be called when object collides with a trigger object
    // Parameters:
    //      Collider other: The trigger the object collides with
    //----------------------------------------------------
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Coin") // Checks if name is coin
        {
            Destroy(other.gameObject); // destroys other gameObject
            GM.coinTotal += 1; // Adds to the coin total on the GM script
        }
    }

}
