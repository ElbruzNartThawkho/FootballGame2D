using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerPlayer : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 move;
    void Start()
    {
        
    }
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        rb.MovePosition(rb.position + move * 5f * Time.fixedDeltaTime);

    }
}
