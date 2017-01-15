using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnatomieGetScoreText : MonoBehaviour {
    string ausgabeText;
    public Text TextInButton;

    // Use this for initialization
    void Start () {
        ausgabeText = ("Score: "+RichtigZaehlerAnatomie.number+"/3");
        TextInButton.text = ausgabeText;
	}
	
	// Update is called once per frame
	void Update () {

    }
   
}
