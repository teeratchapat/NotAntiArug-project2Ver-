using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpossumBehavior : MonoBehaviour
{
    private Rigidbody2D opossumRigidbody2d;
    private float lastxPosition = 0;

    private float moveHorizontal = -1;
    private float runSpeed = 5;
    

    // Start is called before the first frame update
    void Start()
    {
        opossumRigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        opossumRigidbody2d.velocity = new Vector2(moveHorizontal*runSpeed, opossumRigidbody2d.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(this.name + " onCollisionEnter2D");
    }
}
