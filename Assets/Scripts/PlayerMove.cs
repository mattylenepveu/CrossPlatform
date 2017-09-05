﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Portal")
        {
            SceneManager.LoadScene("Leaderboard");
        }
        if (other.gameObject.name == "DeathZone")
        {
            gameObject.transform.position = new Vector3(0, 0.5f, 0);
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        }

    }

}
