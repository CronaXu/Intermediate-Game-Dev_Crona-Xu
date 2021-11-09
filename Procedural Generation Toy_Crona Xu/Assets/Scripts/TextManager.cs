using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{

    public Text ApplesLeft;
    public Text SnakeLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ApplesLeft.text = Globals.appleNum.ToString();
        SnakeLeft.text = Globals.snakeTotal.ToString();
    }
}
