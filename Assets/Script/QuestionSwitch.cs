using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class QuestionSwitch : MonoBehaviour
{

    public Text InfoBox;
    public Text winBox;
    private object panel;

    public string ersteFrage;
    public string zweiteFrage;
    public string dritteFrage;


    // Use this for initialization
    void Start()
    {
        InfoBox.text = ersteFrage;

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void PointerIn()
    {
        if(InfoBox.text.Equals(ersteFrage))
        {
            InfoBox.text = zweiteFrage;
        } else if (InfoBox.text.Equals(zweiteFrage))
        {
            InfoBox.text = dritteFrage;
        }
        else if (InfoBox.text.Equals(dritteFrage))
        {
            InfoBox.text = "Sie sind durch";
        }

    }
    public void PointerOut()
    {

        InfoBox.text = InfoBox.text;
    }



}
