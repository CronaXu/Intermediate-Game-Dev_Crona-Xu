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
    public Animator Player;
    

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
            Player.SetBool("IsMoving", false);
        }
        else
        {
            myBody.constraints = RigidbodyConstraints2D.None;
            myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        if (EndScreen.activeSelf == true)
        {
            myBody.constraints = RigidbodyConstraints2D.FreezeAll;
            Player.SetBool("IsMoving", false);
            Player.SetBool("IsJumping", false);
        }
    }

    void CheckKeys()
    {
        if (Input.GetKey(KeyCode.D))
        {
            myRenderer.flipX = false;
            HandleLRMovement(speed);
            Player.SetBool("IsMoving", true);
            Player.SetBool("StandStill", false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            myRenderer.flipX = true;
            HandleLRMovement(-speed);
            Player.SetBool("IsMoving", true);
            Player.SetBool("StandStill", false);
        }
        else
        {
            Player.SetBool("IsMoving", false);
            Player.SetBool("StandStill", true);
        }

        if (Input.GetKey(KeyCode.W) && onFloor)
        {
            myBody.velocity = new Vector3(myBody.velocity.x, jumpHeight);
            Player.SetBool("IsJumping", true);
            Player.SetBool("StandStill", false);
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

        if (collision.gameObject.tag == "floor" || collision.gameObject.tag == "path")
        {
            onFloor = true;
            Player.SetBool("IsJumping", false);
            Player.SetBool("IsMoving", true);
            
            myBody.velocity = new Vector3(myBody.velocity.x, 0);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.name == "Dialog1" && Globals.dia1Viewed == false)
        {
            Globals.diaNum = 1;
            talkUI.SetActive(true);

            Player.SetBool("IsMoving", false);

        }
        if (collision.gameObject.name == "Dialog2" && Globals.dia2Viewed == false)
        {
            Globals.diaNum = 2;
            talkUI.SetActive(true);


            Player.SetBool("IsMoving", false);
        }
        if (collision.gameObject.name == "Dialog3" && Globals.dia3Viewed == false)
        {
            Globals.diaNum = 3;
            talkUI.SetActive(true);

            Player.SetBool("IsMoving", false);

        }
        if (collision.gameObject.name == "Dialog4" && Globals.dia4Viewed == false)
        {
            Globals.diaNum = 4;
            talkUI.SetActive(true);

            Player.SetBool("IsMoving", false);

        }
        if (collision.gameObject.name == "Dialog5" && Globals.dia5Viewed == false)
        {
            Globals.diaNum = 5;
            talkUI.SetActive(true);

            Player.SetBool("IsMoving", false);

        }
        if (collision.gameObject.name == "Dialog6" && Globals.dia6Viewed == false)
        {
            Globals.diaNum = 6;
            talkUI.SetActive(true);

            Player.SetBool("IsMoving", false);

        }
        if (collision.gameObject.name == "Dialog7" && Globals.dia7Viewed == false)
        {
            Globals.diaNum = 7;
            talkUI.SetActive(true);

            Player.SetBool("IsMoving", false);

        }
        if (collision.gameObject.name == "Dialog8" && Globals.dia8Viewed == false)
        {
            Globals.diaNum = 8;
            talkUI.SetActive(true);

            Player.SetBool("IsMoving", false);

        }
        if (collision.gameObject.name == "Dialog9" && Globals.dia9Viewed == false)
        {
            Globals.diaNum = 9;
            talkUI.SetActive(true);


            Player.SetBool("IsMoving", false);
        }
        if (collision.gameObject.name == "Dialog10" && Globals.dia10Viewed == false)
        {
            Globals.diaNum = 10;
            talkUI.SetActive(true);

            Player.SetBool("IsMoving", false);

        }
        if (collision.gameObject.name == "Dialog11" && Globals.dia11Viewed == false)
        {
            Globals.diaNum = 11;
            talkUI.SetActive(true);

            Player.SetBool("IsMoving", false);

        }
        if (collision.gameObject.name == "Dialog12" && Globals.dia12Viewed == false)
        {
            Globals.diaNum = 12;
            talkUI.SetActive(true);

            Player.SetBool("IsMoving", false);

        }
        if (collision.gameObject.name == "Dialog13" && Globals.dia13Viewed == false && Globals.dia15Viewed == false)
        {
            Globals.diaNum = 13;
            talkUI.SetActive(true);

            Player.SetBool("IsMoving", false);

        }
        if (collision.gameObject.name == "Dialog14" && Globals.dia14Viewed == false)
        {
            Globals.diaNum = 14;
            talkUI.SetActive(true);

            Player.SetBool("IsMoving", false);

        }
        if (collision.gameObject.name == "Dialog15" && Globals.dia15Viewed == false)
        {
            Globals.diaNum = 15;
            talkUI.SetActive(true);

            Player.SetBool("IsMoving", false);

        }
        if (collision.gameObject.name == "Dialog16" && Globals.dia16Viewed == false && Globals.dia15Viewed == true)
        {
            Globals.diaNum = 16;
            talkUI.SetActive(true);

            Player.SetBool("IsMoving", false);

        }
    }
}

