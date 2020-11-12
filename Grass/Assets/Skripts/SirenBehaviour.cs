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
    int counter = 0;

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
            /*
            if (!IsPlaying)
            {
                audio.Stop();
                audio.Play();
                IsPlaying = true;
            }*/
            if (!IsPlaying)
            {
                
                audio.Play();
                IsPlaying = true;
            }
            //else
            //{
            //    if (counter >=50)
            //    {
            //        counter = 0;
            //        IsPlaying = false;
            //    }
            //    else
            //    {
            //        counter++;
            //    }
            //}


            //audio.Play();

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
            IsPlaying = false;
            //audio.Stop();
        }

    }
}
