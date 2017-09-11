using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour {

    private float m_fSpeed = 1;
    private float m_fTimer;
	// Use this for initialization
	void Awake ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        m_fTimer += Time.deltaTime;
        if(m_fTimer < 2)
            transform.position += transform.up * m_fSpeed * Time.deltaTime;
        if(m_fTimer > 2 && m_fTimer < 4)
            transform.position -= transform.up * m_fSpeed * Time.deltaTime;
        if (m_fTimer > 6)
            m_fTimer = 0;
    }
}
