using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileData : MonoBehaviour
{
    public int gridX;
    public int gridY;
    public bool revealed;

    private void OnMouseDown()
    {
        Debug.Log(gridX + "," + gridY);
    }
}
