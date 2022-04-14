using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    Rigidbody playerboat;
    Vector3 onward;
    Vector3 backward;
    Vector3 turnRight;
    Vector3 turnLeft;
    int movementSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        playerboat = GetComponent<Rigidbody>();
        onward = new Vector3(0,0,+1);
        backward = new Vector3(0, 0, -1);

    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }
        else
        {
            playerboat.drag = 5;
        }
        
       if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -2, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, +2, 0);
        }
    }
}
