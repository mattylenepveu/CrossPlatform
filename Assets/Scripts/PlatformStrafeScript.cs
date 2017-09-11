using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformStrafeScript : MonoBehaviour {

    private float m_fSpeed = 1;
    private float m_fTimer;
    // Use this for initialization
    void Awake () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        m_fTimer += Time.deltaTime;
        if (m_fTimer < 8)
            transform.position += transform.forward * m_fSpeed * Time.deltaTime;
        if (m_fTimer > 8 && m_fTimer < 16)
            transform.position -= transform.forward * m_fSpeed * Time.deltaTime;
        if (m_fTimer > 16)
            m_fTimer = 0;
    }
}
