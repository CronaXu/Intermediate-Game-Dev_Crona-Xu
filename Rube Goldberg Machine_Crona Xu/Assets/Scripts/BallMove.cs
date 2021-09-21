using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public Rigidbody2D myBody;
    public float power1;
    public float power2;
    private bool start = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && start)
        {
            myBody.AddForce(Vector2.right * power1);
            myBody.AddForce(Vector2.down  * power2);
            start = false;
        }
    }
}
