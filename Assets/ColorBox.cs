using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBox : MonoBehaviour
{
    public GameObject[] button;
    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.FindGameObjectsWithTag("Button1");
    }

    // Update is called once per frame
    void Update()
    {
        button = GameObject.FindGameObjectsWithTag("Button1");

        if (button == null) {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
