using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera7 : MonoBehaviour
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
        if (collision.gameObject.name == "CamPos8") ;
        {
            Vector3 newCamPos = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, -10); ;
            Camera.main.transform.position = newCamPos;
        }
        if (collision.gameObject.name == "CamPos9") ;
        {
            Vector3 newCamPos = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, -10); ;
            Camera.main.transform.position = newCamPos;
        }
        if (collision.gameObject.name == "CamPos10") ;
        {
            Vector3 newCamPos = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, -10); ;
            Camera.main.transform.position = newCamPos;
        }
        if (collision.gameObject.name == "CamPos11") ;
        {
            Vector3 newCamPos = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, -10); ;
            Camera.main.transform.position = newCamPos;
        }
        if (collision.gameObject.name == "CamPos12") ;
        {
            Vector3 newCamPos = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, -10); ;
            Camera.main.transform.position = newCamPos;
        }
    }
}
