using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "CamPos2") ;
        {
            Vector3 newCamPos = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, -10); ;
            Camera.main.transform.position = newCamPos;
        }
        if (collision.gameObject.name == "CamPos3") ;
        {
            Vector3 newCamPos = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, -10); ;
            Camera.main.transform.position = newCamPos;
        }

    }
}
