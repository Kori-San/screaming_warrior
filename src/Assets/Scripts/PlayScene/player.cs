using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float speed = 1F;
    private Rigidbody2D rb;
    private Vector3 move;

    public int maxHp = 100;
    public int hp = 0;
    public int attack = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        // Setup health
        hp = maxHp;
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
    
    // Update the health
    void UpdateHealth(int difHp)
    {
        hp += difHp;
        if (hp > maxHp)
        {
            hp = maxHp;
        }

        if (hp < 0)
        {
            hp = 0;
            Debug.Log("Player dead");
        }
    }
}