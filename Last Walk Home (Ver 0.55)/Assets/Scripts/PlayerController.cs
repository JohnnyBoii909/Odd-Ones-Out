using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    //how fast
    public float jumpForce;
    //how high
    private float moveInput;
    //Check if a key is pressed to move the player
    public Direction direction = Direction.FirstLoad;

    public static PlayerController inst;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        if(inst == null)
        {
            inst = this;
        }
        else if(inst !=this)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }
}

public enum Direction
{
    Left, Right, FirstLoad
}
