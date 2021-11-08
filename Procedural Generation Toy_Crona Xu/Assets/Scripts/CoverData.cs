using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoverData : MonoBehaviour
{
    public int coverX;
    public int coverY;

    private void OnMouseDown()
    {
        Debug.Log(coverX + "," + coverY);
    }

}
