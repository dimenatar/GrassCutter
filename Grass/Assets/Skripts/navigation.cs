using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class navigation : MonoBehaviour {

    public GameObject mainCube;
    public GameObject cube;
    public Vector2 kord_shvabri;
    public float CoordX;
    public float CoordY;
    public float CoordZ;

    public GameObject cutter;
    public Button clr;
    public Button b1;
    public Button b2;
    public Button b3;

    public AudioSource audio;
    public Light light;


    public bool needSiren;

    public bool left_to_right = true;
    public bool right_to_left = false;
    public bool Top_To_Down = false;

    public bool left_to_right2 = false;
    public bool Top_To_Down2 = true;
    public bool  Down_To_Top2 = false;

    public bool left_to_right3 = true;
    public bool top_to_down3 = true;
    public bool TopRight_To_DownLeft3 = false;
    public bool DownLeft_To_TopRight3 = false;

    public bool DoFirstRoad = true;
    public bool DoSecondRoad = false;
    public bool DoThirdRoad = false;    

    public int counter = 0;
    public int secCounter = 0;

    public double grass_counter;

    public void onclick1()
    {
        DoFirstRoad = true;
        DoSecondRoad = false;
        DoThirdRoad = false;
    }

    public void onclick2()
    {
        DoFirstRoad = false;
        DoSecondRoad = true;
        DoThirdRoad = false;
    }

    public void onclick3()
    {
        DoFirstRoad = false;
        DoSecondRoad = false;
        DoThirdRoad = true;
    }

    public void road1()
    {
        Debug.Log(Time.timeScale);
        if (DoFirstRoad)
        {
            if (GameObject.FindWithTag("grass") == null)
            {
                DoFirstRoad = false;
                needSiren = true;
            }
            else needSiren = false;
                kord_shvabri = cube.transform.position;
            CoordX = cube.transform.position.x;
            CoordY = cube.transform.position.y;
            CoordZ = cube.transform.position.z;
            if (CoordX < 43f || CoordY > -37f)
            {
                if (left_to_right)
                {
                    secCounter = 0;
                    counter = 0;
                    if (CoordX < 45)
                    {
                        CoordX +=2.5f;
                        //grass_counter -= 24;
                        cube.transform.position = new Vector2(CoordX, CoordY);
                        
                    }
                    else
                    {
                        left_to_right = false;
                       /* if(CoordY < 0 )
                        Top_To_Down = false;
                        else*/
                        Top_To_Down = true;
                    }
                }
                else if (Top_To_Down)
                {
                    
                        if (counter < 2 )
                        {
                            CoordY -= 3f;
                            //grass_counter -= 24;
                            cube.transform.position = new Vector2(CoordX, CoordY);
                            counter++;
                        }
                        else
                        {
                            Top_To_Down = false;
                            if (secCounter == 0)
                                right_to_left = true;
                            else
                            {
                                left_to_right = true;
                            }
                            //counter = 0;
                        }
                    
                }
                else if (right_to_left)
                {
                    secCounter = 1;
                    counter = 0;
                    if (CoordX > -32.5f)
                    {
                        CoordX -= 2.5f;
                        //grass_counter -= 24;
                        cube.transform.position = new Vector2(CoordX, CoordY);
                    }
                    else
                    {
                        right_to_left = false;
                        Top_To_Down = true;
                    }
                }
                
            }
            else
            {
                left_to_right = true;
                right_to_left = false;
                Top_To_Down = false;
                cube.transform.position = new Vector2(-34.5f, 42f );
                if (GameObject.FindWithTag("grass") == null)
                {
                    DoFirstRoad = false;
                    needSiren = true;
                    //TODO



                }
                else needSiren = false; 
            }
        }
        else if(DoSecondRoad)
        {
            if (GameObject.FindWithTag("grass") == null)
            {
                DoSecondRoad = false;
                needSiren = true;
            }
            kord_shvabri = cube.transform.position;
            CoordX = cube.transform.position.x;
            CoordY = cube.transform.position.y;
            CoordZ = cube.transform.position.z;
            if (CoordX < 46 || CoordY > -31)
            {
                if (Top_To_Down2)
                {
                    secCounter = 0;
                    counter = 0;
                    if (CoordY > -31)
                    {
                        CoordY -= 2.5f;
                        cube.transform.position = new Vector2(CoordX, CoordY);
                    }
                    else
                    {
                        Top_To_Down2 = false;
                        left_to_right2 = true;
                    }
                }
                else if (left_to_right2)
                {

                    if (counter < 2)
                    {
                        CoordX += 2.5f;
                        cube.transform.position = new Vector2(CoordX, CoordY);
                        counter++;
                    }
                    else
                    {
                        left_to_right2 = false;
                        Top_To_Down = false;
                        if (secCounter == 0)
                            Down_To_Top2 = true;
                        else
                        {
                            Top_To_Down2 = true;
                        }
                        //counter = 0;
                    }

                }
                else if (Down_To_Top2)
                {
                    secCounter = 1;
                    counter = 0;
                    if (CoordY < 40)
                    {
                        CoordY += 2.5f;
                        cube.transform.position = new Vector2(CoordX, CoordY);
                    }
                    else
                    {
                        Down_To_Top2 = false;
                        left_to_right2 = true;

                    }
                }

            }
            else
            {
                cube.transform.position = new Vector2(-36.5f, 42f);
                if (GameObject.FindWithTag("grass") == null)
                {
                    DoSecondRoad = false;
                    needSiren = true;
                    //TODO

                }
                else needSiren = false;
            }
        }
        if(DoThirdRoad)
        {
            if (GameObject.FindWithTag("grass") == null)
            {
                DoThirdRoad = false;
                needSiren = true;
            }
            else needSiren = false;
            kord_shvabri = cube.transform.position;
            CoordX = cube.transform.position.x;
            CoordY = cube.transform.position.y;
            CoordZ = cube.transform.position.z;



            if (CoordX < 40.8f || CoordY > -31f)
            {
                if (left_to_right3)
                {
                    if (counter < 2)
                    {
                        CoordX +=  1f;
                        cube.transform.position = new Vector2(CoordX, CoordY);
                        counter++;
                    }
                    else
                    {
                        left_to_right3 = false;

                        if (secCounter == 0)
                            TopRight_To_DownLeft3 = true;
                        else
                        {
                            DownLeft_To_TopRight3 = true;
                        }
                        counter = 0;
                    }
                }

                else if (TopRight_To_DownLeft3)
                {
                    secCounter = 0;
                    counter = 0;
                    if (CoordY > -31 && CoordX > -31)
                    {
                        CoordY -= 2.5f;
                        CoordX -= 2.5f;
                        cube.transform.position = new Vector2(CoordX, CoordY);
                    }
                    else
                    {
                        TopRight_To_DownLeft3 = false;
                        DownLeft_To_TopRight3 = true;
                        top_to_down3 = true;
                    }
                }
                else if(top_to_down3)
                {
                    if (counter < 2)
                    {
                        CoordY -= 1f;
                        cube.transform.position = new Vector2(CoordX, CoordY);
                        counter++;
                    }
                    else
                    {
                        top_to_down3 = false;

                        if (secCounter == 0)
                            DownLeft_To_TopRight3  = true;
                        else
                        {
                             TopRight_To_DownLeft3 = true;
                        }
                        counter = 0;
                    }
                }
                else if (DownLeft_To_TopRight3)
                {
                    secCounter = 0;
                    counter = 0;
                    if (CoordY < 39.5 && CoordX < 39.85)
                    {
                        CoordY += 2.5f;
                        CoordX += 2.5f;
                        cube.transform.position = new Vector2(CoordX, CoordY);
                    }
                    else
                    {
                        TopRight_To_DownLeft3 = false;
                        DownLeft_To_TopRight3 = false;
                        left_to_right3 = true;
                    }
                }
            }
            else
            {
                cube.transform.position = new Vector2(-34.5f, 42f);
                if (GameObject.FindWithTag("grass") == null)
                {
                    DoThirdRoad = false;
                    needSiren = true;
                    //TODO

                }
                else
                {
                    needSiren = false;
                    left_to_right3 = true;
                    DownLeft_To_TopRight3 = false;
                    TopRight_To_DownLeft3 = false;
                }
            }
        }

    }

    // Use this for initialization
    public Material mater;
    public  GameObject prefab;
    GameObject[,] CubeArray = new GameObject[80, 80];
	void Start ()
    {
        mainCube = GameObject.FindWithTag("MainPole");
        Time.timeScale = 1f;
        for (int i =0; i < 80; i ++)
        {
            for (int j =0; j < 80; j ++)
            {
                CubeArray[i, j] = (GameObject)Instantiate(prefab, new Vector2(i-35.5f, j-35.5f ), transform.rotation);
                CubeArray[i, j].tag = "grass";
                //CubeArray[i, j].transform.localPosition.x = 10;
                CubeArray[i, j].GetComponent<BoxCollider>().isTrigger = true;           
                CubeArray[i, j].transform.localScale = new Vector2(1f,1f);
                CubeArray[i, j].GetComponent<Renderer>().sharedMaterial = mater;
                //grass_counter++;
                CubeArray[i, j].AddComponent<ObjectColor>();
                CubeArray[i, j].transform.parent = mainCube.transform;

            }
        }
        InvokeRepeating("road1", 0, 0.1f);
        InvokeRepeating("PlsHelpThisComp", 0, 0.01f);
	}
    public GameObject CubeColor;
    public bool needUpdate = false;
    void PlsHelpThisComp()
    {
        if (needUpdate)
        {
            for (int i =0; i < 80; i ++)
            {
                for (int j = 0; j < 80; j++)
                {
                    if (CubeArray[i,j] != null)
                    {
                        CubeArray[i,j].GetComponent<Renderer>().sharedMaterial = CubeColor.GetComponent<Renderer>().sharedMaterial;
                    }
                }
            }
            needUpdate = false;
        }
    }
    // Update is called once per frame
    void Update () {
        if (cutter.GetComponent<CutterEnter>().grass_counter >3300)
        {
             DoFirstRoad = false;
             DoSecondRoad = false;
             DoThirdRoad = false;

            needSiren = true;

            clr.GetComponent<Transform>().localScale = new Vector2(1, 1) ;

            b1.GetComponent<Transform>().localScale = new Vector2(0, 0);
            b2.GetComponent<Transform>().localScale = new Vector2(0, 0);
            b3.GetComponent<Transform>().localScale = new Vector2(0, 0);

            //grass_counter = 0;
            
        }
	}

    public void clear()
    {
        DoFirstRoad = false;
        DoSecondRoad = false;
        DoThirdRoad = false;

        cutter.GetComponent<CutterEnter>().grass_counter = 0;

        clr.GetComponent<Transform>().localScale = new Vector2(0, 0);

        b1.GetComponent<Transform>().localScale = new Vector2(1, 1);
        b2.GetComponent<Transform>().localScale = new Vector2(1, 1);
        b3.GetComponent<Transform>().localScale = new Vector2(1, 1);

        needSiren = false;

        light.GetComponent<SirenBehaviour>().audio.Stop();
    }
}