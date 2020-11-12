using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class creategrass : MonoBehaviour {

    // Use this for initialization

    public Material mater;
    public GameObject prefab;
    GameObject[,] CubeArray = new GameObject[50, 50];

    void Start () {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                CubeArray[i, j] = (GameObject)Instantiate(prefab, new Vector2(i - 0.5f, j - 0.5f), transform.rotation);
                CubeArray[i, j].tag = "grass";
                //CubeArray[i, j].transform.localPosition.x = 10;
                CubeArray[i, j].GetComponent<BoxCollider>().isTrigger = true;

                CubeArray[i, j].GetComponent<Renderer>().material = mater;

                CubeArray[i, j].transform.localScale = new Vector2(1f, 1f);


            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
