using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class getScoreText : MonoBehaviour {
    string ausgabeText;
    public Text blaText;

    //public string scoreText1;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        PanelSwitch ps = new PanelSwitch();
        blaText = ps.name;
     //   blaText = ausgabeText;
    }


    

}
