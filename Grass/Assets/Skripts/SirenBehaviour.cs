using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SirenBehaviour : MonoBehaviour
{

    public GameObject cutter;
    public Light Siren;
    public bool needSiren;
    public bool goOn;
    public bool IsPlaying;
    public AudioSource audio;
    

    void Start()
    {
        goOn = true;
        needSiren = false;
        cutter = GameObject.FindGameObjectWithTag("cutter");
        audio.Stop();
        IsPlaying = false;
        InvokeRepeating("DoSiren", 0, 0.05f);

    }

    void Update()
    {
        if (cutter.GetComponent<navigation>().needSiren)
        {
            needSiren = true;
            //audio.Play();
        }
        else
        {
            needSiren = false;
            //audio.Stop();
        }
    }
    public void DoSiren()
    {
        if (needSiren)
        {
            if (!IsPlaying)
            {
                audio.Play();
                IsPlaying = true;
            }
             

            
            if (goOn)
            {
                if (Siren.range < 3f) Siren.range += 0.2f;
                else goOn = false;
                //audio.Play();

            }
            else
            {
                if (Siren.range > 0) Siren.range -= 0.2f;
                else goOn = true;
                //audio.Play();

            }
        }
        else
        {
            Siren.range = 0;
            //audio.Stop();
        }

    }
}
