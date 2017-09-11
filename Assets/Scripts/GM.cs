using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour {

    public static int coinTotal = 0;
    public static float timeTotal = 0.0f;


    // Use this for initialization
    void Start ()
    {
        timeTotal = 0.0f;
        coinTotal = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        timeTotal += Time.deltaTime;
    }
}
