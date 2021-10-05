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

    List<string> textList = new List<string>();

    // Start is called before the first frame update

    void Awake()
    {
        GetTextFromFile(textFile);
    }

    private void OnEnable()
    {
        textLabel.text = textList[index];
        index++;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && index == textList.Count)
        {
            gameObject.SetActive(false);
            index = 0;
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            textLabel.text = textList[index];
            index++;
        }
        if (Globals.diaNum == 1){
            textFile = Resources.Load("Dialog1") as TextAsset;
        }
        if (Globals.diaNum == 2)
        {
            textFile = Resources.Load("Dialog2") as TextAsset;
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
