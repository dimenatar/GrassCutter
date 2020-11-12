using UnityEngine;
using System.Collections;

public class ObjectColor : MonoBehaviour {

    public GameObject grasscutter;
	void OnSetColor(Color color)
	{
		Material mt = new Material(GetComponent<Renderer>().sharedMaterial);
		mt.color = color;
		GetComponent<Renderer>().material = mt;
        grasscutter.GetComponent<navigation>().needUpdate = true;
	}

	void OnGetColor(ColorPicker picker)
	{
		picker.NotifyColor(GetComponent<Renderer>().material.color);
	}
    private void Start()
    {
        grasscutter = GameObject.FindWithTag("cutter");
    }
}
