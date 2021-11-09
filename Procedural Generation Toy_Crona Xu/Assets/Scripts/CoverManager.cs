using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoverManager : MonoBehaviour
{
    public GameObject coverPrefab;

    GameObject[,] gridCovers;

    public int gridWidth;
    public int gridHeight;
    public AudioSource myAudioSource;
    public AudioClip appleSound;
    public AudioClip snakeSound;

    // Start is called before the first frame update
    void Start()
    {
        gridCovers = new GameObject[gridWidth, gridHeight];
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                MakeCover(x, y);
            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.playApple)
        {
            myAudioSource.clip = appleSound;
            myAudioSource.Play();
            Globals.playApple = false;
        }
        if (Globals.playSnake)
        {
            myAudioSource.clip = snakeSound;
            myAudioSource.Play();
            Globals.playSnake = false;
        }
    }


    void MakeCover(int xPos, int yPos)
    {
        GameObject newCover = Instantiate(coverPrefab);
        CoverData myData = newCover.GetComponent<CoverData>();
        newCover.transform.position = new Vector3(transform.position.x + xPos, transform.position.y + yPos, 0);
        gridCovers[xPos, yPos] = newCover;
        myData.coverX = xPos;
        myData.coverY = yPos;
        //Debug.Log(myData.coverX + "," + myData.coverY);
    }
}
