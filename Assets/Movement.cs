using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour{

    private Rigidbody2D body;
    float hMove; //Horizontal Movement
    public float moveSpeed = 10f;
    public float height = 10f;
    public bool isJumping = false;
    private float counter = 0;

    // Start is called before the first frame update
    void Start() {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
        hMove = Input.GetAxisRaw("Horizontal");
        body.velocity = new Vector2(hMove * moveSpeed, body.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping) {
            body.velocity = new Vector2(body.velocity.x, height);
            if (counter == 1) {
                isJumping = true;
            }
            counter++;
            Debug.Log("Counter: " + counter);
        }
    }

    void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.tag == "ground") {
            isJumping = false;
            counter = 0;
        }
    }
}
