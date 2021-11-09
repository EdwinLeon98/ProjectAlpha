using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBox : MonoBehaviour
{
    public GameObject button;
    public GameObject box;
    public Color newColor;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (button.activeSelf) {
            Debug.Log("Found!");
        }
        else {
            box.GetComponent<Renderer>().material.color = newColor;
            Debug.Log("Color set");
        }
    }
}
