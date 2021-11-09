using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TileData : MonoBehaviour
{
    public int gridX;
    public int gridY;
    public bool revealed;
    public Sprite snake;
    

    private void OnMouseEnter()
    {
        if (!revealed && gameObject.GetComponent<SpriteRenderer>().sprite != snake)
        {
            Globals.appleNum -= 1;
            this.revealed = true;
            Globals.playApple = true;
        }

        if (gameObject.GetComponent<SpriteRenderer>().sprite == snake)
        {
            Globals.playSnake = true;
            Invoke("ChangeScene", 1);
        }

        
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(2);
    }
    
}
