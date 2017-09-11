using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scores : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (gameObject.name == "Time")
        {
            GetComponent<TextMesh>().text = "Time : " + Mathf.Round(GM.timeTotal * 100f) / 100f + "s";
        }

    }
}
