using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        }
    }
}
