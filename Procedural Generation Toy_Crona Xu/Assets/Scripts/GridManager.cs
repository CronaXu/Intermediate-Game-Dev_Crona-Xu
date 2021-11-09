using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public GameObject tilePrefab;

    public Sprite[] tileSprites;

    GameObject[,] gridTiles;

    public int gridWidth;
    public int gridHeight;

    // Start is called before the first frame update
    void Start()
    {
        gridTiles = new GameObject[gridWidth, gridHeight];
        Globals.appleNum = 225;
        Globals.snakeTotal = 0;
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                MakeTile(x, y);
            }

        }

        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                if (gridTiles[x, y].GetComponent<SpriteRenderer>().sprite != tileSprites[9])
                {
                    ChangeTile(x, y);
                }
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void MakeTile(int xPos, int yPos)
    {
        GameObject newTile = Instantiate(tilePrefab);
        int randTile = Random.Range(0, 5);
        
        newTile.transform.position = new Vector3(transform.position.x + xPos, transform.position.y + yPos, 1);
        TileData myData = newTile.GetComponent<TileData>();
        if (randTile == 4)
        {
            newTile.GetComponent<SpriteRenderer>().sprite = tileSprites[9];
            Globals.appleNum -= 1;
            Globals.snakeTotal += 1;
        }
        
        myData.gridX = xPos;
        myData.gridY = yPos;
        gridTiles[xPos, yPos] = newTile;

    }


    void ChangeTile(int xPos, int yPos)
    {
        int snakeNum = 0;
        if (xPos - 1 >= 0 && xPos - 1 <= 14 && yPos - 1 >= 0 && yPos - 1 <= 14)
        {
            if (gridTiles[xPos - 1, yPos - 1].GetComponent<SpriteRenderer>().sprite == tileSprites[9])
            {
                snakeNum += 1;
            }
        }

        if (xPos - 1 >= 0 && xPos - 1 <= 14 && yPos >= 0 && yPos <= 14)
        {
            if (gridTiles[xPos - 1, yPos].GetComponent<SpriteRenderer>().sprite == tileSprites[9])
            {
                snakeNum += 1;
            }
        }

        if (xPos - 1 >= 0 && xPos - 1 <= 14 && yPos + 1 >= 0 && yPos + 1 <= 14)
        {
            if (gridTiles[xPos - 1, yPos + 1].GetComponent<SpriteRenderer>().sprite == tileSprites[9])
            {
                snakeNum += 1;
            }
        }

        if (xPos >= 0 && xPos <= 14 && yPos - 1 >= 0 && yPos - 1 <= 14)
        {
            if (gridTiles[xPos, yPos - 1].GetComponent<SpriteRenderer>().sprite == tileSprites[9])
            {
                snakeNum += 1;
            }
        }

        if (xPos >= 0 && xPos <= 14 && yPos + 1 >= 0 && yPos + 1 <= 14)
        {
            if (gridTiles[xPos, yPos + 1].GetComponent<SpriteRenderer>().sprite == tileSprites[9])
            {
                snakeNum += 1;
            }
        }

        if (xPos + 1 >= 0 && xPos + 1 <= 14 && yPos - 1 >= 0 && yPos - 1 <= 14)
        {
            if (gridTiles[xPos + 1, yPos - 1].GetComponent<SpriteRenderer>().sprite == tileSprites[9])
            {
                snakeNum += 1;
            }
        }

        if (xPos + 1 >= 0 && xPos + 1 <= 14 && yPos >= 0 && yPos <= 14)
        {
            if (gridTiles[xPos + 1, yPos].GetComponent<SpriteRenderer>().sprite == tileSprites[9])
            {
                snakeNum += 1;
            }
        }

        if (xPos + 1 >= 0 && xPos + 1 <= 14 && yPos + 1 >= 0 && yPos + 1 <= 14)
        {
            if (gridTiles[xPos + 1, yPos + 1].GetComponent<SpriteRenderer>().sprite == tileSprites[9])
            {
                snakeNum += 1;
            }
        }

        gridTiles[xPos, yPos].GetComponent<SpriteRenderer>().sprite = tileSprites[snakeNum];
    }
}

public static class Globals
{
    public static int appleNum;
    public static int snakeTotal;

}
