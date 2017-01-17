using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MaschinenbauGetScoreText : MonoBehaviour
{
    string ausgabeText;
    public Text TextInButton;

    // Use this for initialization
    void Start()
    {
		//Ausgabe des Scores vom Quiz nach 3 Fragen
        ausgabeText = ("Score: " + RichtigZaehlerMaschinenbau.number + "/3");
        TextInButton.text = ausgabeText;
    }

    // Update is called once per frame
    void Update()
    {

    }

}
