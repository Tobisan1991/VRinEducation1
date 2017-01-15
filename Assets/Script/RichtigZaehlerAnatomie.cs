using UnityEngine;
using System.Collections;

public class RichtigZaehlerAnatomie : MonoBehaviour {

    public GameObject panel;
    public static int number;
    
	// Use this for initialization
	void Start () {
        counterMethod();
    }

    public void counterMethod()
    {
        if (panel.activeSelf)
        {
            number = number + 1;
            print("Number of Activated Panels= "+number);
        }

        /*
        if (gameObject.tag.Equals("RichtigPanelAnatomie1"))
        {
            number = number + 1;
            print("Punkte : " + number);
        }
        else if (gameObject.tag.Equals("RichtigPanelAnatomie2"))
        {
            number = number + 1;
            print("Punkte : " + number);
        }
        else if (gameObject.tag.Equals("RichtigPanelAnatomie3"))
        {
            number = number + 1;
            print("Punkte : " + number);
        }
        */
   
    }
}
