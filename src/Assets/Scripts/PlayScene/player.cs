using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float speed = 1F;
    private Rigidbody2D rb;
    private Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Vector3.zero;
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        if (move != Vector3.zero)
        {
            MoveCharacter();
        }
    }
    
    void MoveCharacter()
    {
        rb.MovePosition(
            transform.position + (move * 25) * speed * Time.deltaTime
        );
    }
}