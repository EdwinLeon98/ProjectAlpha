using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private bool open = false;
    public GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (open != false) {
            wall.SetActive(false);
            gameObject.SetActive(false);
        }
    }
    
    void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.tag == "Player") {
            Debug.Log("Player");
            open = true;
        }
    }
}
