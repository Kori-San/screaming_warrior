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
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            actualPos.y += 1;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            actualPos.y -= 1;
        }
        transform.position = actualPos;
    }
}
