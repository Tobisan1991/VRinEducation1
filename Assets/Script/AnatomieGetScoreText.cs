using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnatomieGetScoreText : MonoBehaviour
{
	//Variablen für die Ausgabe im Quiz
    string ausgabeText;
    public Text TextInButton;

    // Use this for initialization
    void Start()
    {
		//Ausgabe die am Ende im Objekt erscheint - Ende ist in diesem Fall nach 3 Fragen
        ausgabeText = ("Score: " + RichtigZaehlerAnatomie.number + "/3");
        TextInButton.text = ausgabeText;
        if (RichtigZaehlerAnatomie.number > 0){
            RichtigZaehlerAnatomie.number = 0;
        }


    }
	
	// Update is called once per frame
	void Update () {

    }
   
}
