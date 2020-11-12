using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMenu : MonoBehaviour {

    // Use this for initialization

    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject Cutter;
    public AudioSource audio;
    public GameObject cutter;

    private void Start()
    {
        pauseMenuUI.GetComponent<Canvas>().targetDisplay = 1;
    }

    // Update is called once per frame
    void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameIsPaused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
	}

    public void resume()
    {
        // pauseMenuUI.SetActive(false);

        //pauseMenuUI.transform.localScale=new Vector3(0,0,0);
        //Cutter.GetComponent<navigation>().enabled = true;
       
        gameIsPaused = false;
        Time.timeScale = 1f;
        pauseMenuUI.GetComponent<Canvas>().targetDisplay = 1;
        if (cutter.GetComponent<navigation>().needSiren)
        {
            audio.Play();
        }
        Cutter.GetComponent<navigation>().enabled = true;

    }

    public void pause()
    { 
        Cutter.GetComponent<Rigidbody>().velocity = Vector3.zero;
        Cutter.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        Cutter.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        Cutter.GetComponent<navigation>().enabled = false;
        Time.timeScale = 0f;
        //pauseMenuUI.SetActive(true);

        pauseMenuUI.GetComponent<Canvas>().targetDisplay = 0;
        //pauseMenuUI.transform.localScale = new Vector3(1,1, 1);
        gameIsPaused = true;

        if (cutter.GetComponent<navigation>().needSiren)
        {
            audio.Pause();
        }

    }

    

}
