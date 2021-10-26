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
    public TextAsset dialog8;
    public TextAsset dialog9;
    public TextAsset dialog10;
    public TextAsset dialog11;
    public TextAsset dialog12;
    public TextAsset dialog13;
    public TextAsset dialog14;
    public TextAsset dialog15;
    public TextAsset dialog16;
    public GameObject EndScreen;
    public AudioSource hit;
    public AudioSource door;
    public GameObject Block;



    List<string> textList = new List<string>();

    // Start is called before the first frame update


    void Start()
    {
        hit = gameObject.GetComponent<AudioSource>();
        door = gameObject.GetComponent<AudioSource>();
    }

    void Awake()
    {
        GetTextFromFile(textFile);
    }

    private void OnEnable()
    {
        if (Globals.diaNum == 1)
        {
            this.textFile = dialog1;
            Globals.dia1Viewed = true;
        }
        else if (Globals.diaNum == 2)
        {
            this.textFile = dialog2;
            Globals.dia2Viewed = true;
        }
        else if (Globals.diaNum == 3)
        {
            this.textFile = dialog3;
            Globals.dia3Viewed = true;
        }
        else if (Globals.diaNum == 4)
        {
            this.textFile = dialog4;
            Globals.dia4Viewed = true;
        }
        else if (Globals.diaNum == 5)
        {
            this.textFile = dialog5;
            Globals.dia5Viewed = true;
        }
        else if (Globals.diaNum == 6)
        {
            this.textFile = dialog6;
            Globals.dia6Viewed = true;
        }
        else if (Globals.diaNum == 7)
        {
            this.textFile = dialog7;
            Globals.dia7Viewed = true;
        }
        if (Globals.diaNum == 8)
        {
            this.textFile = dialog8;
            Globals.dia8Viewed = true;
        }
        else if (Globals.diaNum == 9)
        {
            this.textFile = dialog9;
            Globals.dia9Viewed = true;
        }
        else if (Globals.diaNum == 10)
        {
            this.textFile = dialog10;
            Globals.dia10Viewed = true;
        }
        else if (Globals.diaNum == 11)
        {
            this.textFile = dialog11;
            Globals.dia11Viewed = true;
        }
        else if (Globals.diaNum == 12)
        {
            this.textFile = dialog12;
            Globals.dia12Viewed = true;
        }
        else if (Globals.diaNum == 13)
        {
            this.textFile = dialog13;
            Globals.dia13Viewed = true;
        }
        else if (Globals.diaNum == 14)
        {
            this.textFile = dialog14;
            Globals.dia14Viewed = true;
        }
        else if (Globals.diaNum == 15)
        {
            this.textFile = dialog15;
            Globals.dia15Viewed = true;
        }
        else if (Globals.diaNum == 16)
        {
            this.textFile = dialog16;
            Globals.dia16Viewed = true;
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
                hit.Play();
                EndScreen.SetActive(true);
                gameObject.SetActive(false);
                index = 0;
                return;
            }else if(textFile == dialog16)
            {
                Destroy(Block);
                door.Play();
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
    public static bool dia1Viewed = false;
    public static bool dia2Viewed = false;
    public static bool dia3Viewed = false;
    public static bool dia4Viewed = false;
    public static bool dia5Viewed = false;
    public static bool dia6Viewed = false;
    public static bool dia7Viewed = false;
    public static bool dia8Viewed = false;
    public static bool dia9Viewed = false;
    public static bool dia10Viewed = false;
    public static bool dia11Viewed = false;
    public static bool dia12Viewed = false;
    public static bool dia13Viewed = false;
    public static bool dia14Viewed = false;
    public static bool dia15Viewed = false;
    public static bool dia16Viewed = false;
}
