using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resumeButton : MonoBehaviour {

    // Use this for initialization
    public GameObject pauseMenuUI;

   
	
	// Update is called once per frame
	void FixedUpdate () {

        Time.timeScale = 1f;
        pauseMenuUI.GetComponent<Canvas>().targetDisplay = 1;
    }

    

    
}
