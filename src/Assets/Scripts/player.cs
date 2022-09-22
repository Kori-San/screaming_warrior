using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 actualPos = transform.position; 
        if (Input.GetKey(KeyCode.UpArrow))
        {
            actualPos.y += .25F;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            actualPos.y -= .25F;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
             actualPos.x -= .25F;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
             actualPos.x += .25F;
        }
        transform.position = actualPos;
    }
}
