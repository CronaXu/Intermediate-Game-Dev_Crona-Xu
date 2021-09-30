using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    public float gravityMultiplier;
    bool onFloor;
    public Animator Player;

    Rigidbody2D myBody;

    SpriteRenderer myRenderer;
    // Start is called before the first frame update
    void Start()
    {
        myBody = gameObject.GetComponent<Rigidbody2D>();
        myRenderer = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

        if (onFloor && myBody.velocity.y > 0.1)
        {
            onFloor = false;
        }
        CheckKeys();
        JumpPhysics();
    }

    void CheckKeys()
    {
        if (Input.GetKey(KeyCode.D))
        {
            myRenderer.flipX = false;
            Player.SetBool("IsMoving", true);
            Player.SetBool("StandStill", false);
            HandleLRMovement(speed);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            myRenderer.flipX = true;
            Player.SetBool("IsMoving", true);
            Player.SetBool("StandStill", false);
            HandleLRMovement(-speed);
        }
        else
        {
            Player.SetBool("IsMoving", false);
            Player.SetBool("StandStill", true);
        }
        if (Input.GetKey(KeyCode.W) && onFloor)
        {
            Player.SetBool("IsJumping", true);
            Player.SetBool("StandStill", false);
            myBody.velocity = new Vector3(myBody.velocity.x, jumpHeight);

        }
        else if (!Input.GetKey(KeyCode.W) && !onFloor)
        {
            myBody.velocity += Vector2.up * Physics2D.gravity * (jumpHeight - 1f) * Time.deltaTime;
        }

    }
    void JumpPhysics()
    {
        if (myBody.velocity.y < 0)
        {
            myBody.velocity += Vector2.up * Physics2D.gravity.y * (gravityMultiplier - 1f) * Time.deltaTime;
        }
    }

    void HandleLRMovement(float dir)
    {
        myBody.velocity = new Vector3(dir, myBody.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "floor")
        {
            onFloor = true;
            Player.SetBool("IsJumping", false);
            myBody.velocity = new Vector3(myBody.velocity.x, 0);
        }
        if (collision.gameObject.tag == "enemy")
        {
            myBody.position = new Vector3(21.73f, -6.31f, -825f);
        }
    }
}