using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccePlayer2 : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 move;
    void Start()
    {

    }
    void Update()
    {
        move.x = Input.GetAxisRaw("Mouse X");
        move.y = Input.GetAxisRaw("Mouse Y");
        rb.MovePosition(rb.position + move * 5f * Time.fixedDeltaTime);

    }
}
