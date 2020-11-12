using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutterEnter : MonoBehaviour
{
    public double grass_counter;
    public GameObject cutter;
    
    /*public bool DoFirstRoad = false;
    public bool DoSecondRoad = false;
    public bool DoThirdRoad = false;

    public bool needSiren;*/

    

    public void OnTriggerEnter(Collider other)
        {
            if (other.tag == "grass")
            {
            if (cutter.GetComponent<navigation>().DoFirstRoad || cutter.GetComponent<navigation>().DoSecondRoad || cutter.GetComponent<navigation>().DoThirdRoad)
            {
                Destroy(other.gameObject);
                grass_counter += 1;
            }
            }
        
            
        }
    void Start()
    {
        
    }

  /*  void Update()
    {
        if (grass_counter > 1500)
        {
            DoFirstRoad = false;
            DoSecondRoad = false;
            DoThirdRoad = false;

            needSiren = true;

            //clr.GetComponent<Transform>().localScale = new Vector2(1, 1);

            grass_counter = 0;
        }
    }*/

}
