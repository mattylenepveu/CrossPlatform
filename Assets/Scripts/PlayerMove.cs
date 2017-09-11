﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;

    void Start()
    {
     
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        gameObject.GetComponent<Rigidbody>().AddForce(movement * speed);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Portal")
        {
            SceneManager.LoadScene("Leaderboard");
        }
        if (other.gameObject.name == "DeathZone")
        {
            SceneManager.LoadScene("Game");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Coin")
        {
            Destroy(other.gameObject);
            GM.coinTotal += 1;
        }
    }

}
