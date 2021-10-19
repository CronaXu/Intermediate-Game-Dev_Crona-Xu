using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{
    [Header("UI")]
    public Text textLabel;
    public Image faceImage;

    [Header("Text")]
    public TextAsset textFile;
    public int index;
    public TextAsset dialog1;
    public TextAsset dialog2;
    public TextAsset dialog3;
    public TextAsset dialog4;
    public TextAsset dialog5;
    public TextAsset dialog6;
    public TextAsset dialog7;
    public GameObject EndScreen;


    List<string> textList = new List<string>();

    // Start is called before the first frame update

    void Awake()
    {
        GetTextFromFile(textFile);
    }

    private void OnEnable()
    {
        if (Globals.diaNum == 1)
        {
            this.textFile = dialog1;
        }
        else if (Globals.diaNum == 2)
        {
            this.textFile = dialog2;
        }
        else if (Globals.diaNum == 3)
        {
            this.textFile = dialog3;
        }
        else if (Globals.diaNum == 4)
        {
            this.textFile = dialog4;
        }
        else if (Globals.diaNum == 5)
        {
            this.textFile = dialog5;
        }
        else if (Globals.diaNum == 6)
        {
            this.textFile = dialog6;
        }
        else if (Globals.diaNum == 7)
        {
            this.textFile = dialog7;
        }
        GetTextFromFile(textFile);
        textLabel.text = textList[index];
        index++;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && index == textList.Count)
        {
            if (textFile == dialog7)
            {
                EndScreen.SetActive(true);
                gameObject.SetActive(false);
                index = 0;
                return;
            }
            else
            {
                gameObject.SetActive(false);
                index = 0;
                return;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            textLabel.text = textList[index];
            index++;
        }
        
    }

    void GetTextFromFile(TextAsset file)
    {
        textList.Clear();
        index = 0;

        


        var lineData = file.text.Split('\n');

        foreach (var line in lineData)
        {
            textList.Add(line);
        }
    }
}
public static class Globals
{
    public static int diaNum;
}
