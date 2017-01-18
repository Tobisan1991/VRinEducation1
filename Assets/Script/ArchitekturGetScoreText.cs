using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ArchitekturGetScoreText : MonoBehaviour{
    string ausgabeText;
    public Text TextInButton;

    // Use this for initialization
    void Start()
    {
		//Ausgabe Score des Quiz nach 3 Fragen
        ausgabeText = ("Score: " + RichtigZaehlerArchitektur.number + "/3");
        TextInButton.text = ausgabeText;
    }

    // Update is called once per frame
    void Update()
    {

    }

}