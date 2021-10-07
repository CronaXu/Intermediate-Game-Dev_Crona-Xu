using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    public float gravityMultiplier;
    public GameObject talkUI;
    public GameObject EndScreen;

    bool onFloor;
    public int diaNum;
   

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
        if (talkUI.activeSelf == true)
        {
            myBody.constraints = RigidbodyConstraints2D.FreezePositionX;
        }
        else
        {
            myBody.constraints = RigidbodyConstraints2D.None;
            myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        if (EndScreen.activeSelf == true)
        {
            myBody.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }

    void CheckKeys()
    {
        if (Input.GetKey(KeyCode.D))
        {
            myRenderer.flipX = false;
            HandleLRMovement(speed);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            myRenderer.flipX = true;
            HandleLRMovement(-speed);
        }
        
        if (Input.GetKey(KeyCode.W) && onFloor)
        {
            myBody.velocity = new Vector3(myBody.velocity.x, jumpHeight);

        }
        else if (!Input.GetKey(KeyCode.W) && !onFloor)
        {
            //myBody.velocity += Vector2.up * Physics2D.gravity * (jumpHeight - 1f) * Time.deltaTime;
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
            myBody.velocity = new Vector3(myBody.velocity.x, 0);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Dialog1")
        {
            Globals.diaNum = 1;
            talkUI.SetActive(true);
         
            

        }
        if (collision.gameObject.name == "Dialog2")
        {
            Globals.diaNum = 2;
            talkUI.SetActive(true);
          


        }
        if (collision.gameObject.name == "Dialog3")
        {
            Globals.diaNum = 3;
            talkUI.SetActive(true);
            


        }
        if (collision.gameObject.name == "Dialog4")
        {
            Globals.diaNum = 4;
            talkUI.SetActive(true);
            


        }
        if (collision.gameObject.name == "Dialog5")
        {
            Globals.diaNum = 5;
            talkUI.SetActive(true);
         


        }
        if (collision.gameObject.name == "Dialog6")
        {
            Globals.diaNum = 6;
            talkUI.SetActive(true);
            


        }
        if (collision.gameObject.name == "Dialog7")
        {
            Globals.diaNum = 7;
            talkUI.SetActive(true);
            


        }
    }
}

