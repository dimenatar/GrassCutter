using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerp : MonoBehaviour {

    public Vector2 startpos;
    public Vector2 endpos;

    public float step;
    private float progress;


    // Use this for initialization
    void Start()
    {

    }
    public GameObject cube;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.Lerp(startpos, endpos, progress);
        progress += step;

    }

    private void Update()
    {
        
        if (cube.transform.position.x == 5)
        {
           // startpos.y = 4;
            endpos.y = 2;
            
        }
        if (cube.transform.position.y == 2)
        {
           // startpos.x = 5;
            endpos.x = -5;
            
        }
        /*if (cube.transform.position.x == 5)
        {
            startpos.y = 2;
            endpos.y = 0;
        }
        if (cube.transform.position.y == 0)
        {
            startpos.x = 5;
            endpos.x = -5;
        }
        if (cube.transform.position.x == 5)
        {
            startpos.x = 0;
            endpos.x = -2;
        }*/
    }


}
