using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoverDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D clicked = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (clicked.collider != null)
            {
                if (clicked.collider.gameObject == gameObject)
                {
                    Destroy(gameObject);
                }
            }
        }
    }

   
}
