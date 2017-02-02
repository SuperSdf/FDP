using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed = 1; // speed in meters per second
    public float thrust = 10; 
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 moveDir = Vector3.zero;
        moveDir.x = Input.GetAxis("Horizontal"); // get result of AD keys in X
        moveDir.z = Input.GetAxis("Vertical"); // get result of WS keys in Z
                                               // move this object at frame rate independent speed:
        transform.position += moveDir * speed * Time.deltaTime;

        if (Input.GetKeyDown("space"))
        {
            Jump();
        }

    }

    void Jump()
    {
        rb.AddForce(0, thrust, 0);
    }
}
