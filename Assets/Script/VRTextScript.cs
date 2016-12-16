using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class VRTextScript : MonoBehaviour
{
    
	//Variable for the Text Gui
    public Text InfoBox;
    public Text winBox;
    public Image panel;
  //  public Image BackgroundText;
  //  public Image BackgroundFull;
  //  public Image BackgroundEmpty;
  
    void Start()
    {
        InfoBox.text = "";
        panel.gameObject.SetActive(false);
    }

    //if the pointer shows on the Object, show the Text of winBox
    public void PointerIn()
    {
        InfoBox.text = winBox.text;
        panel.gameObject.SetActive(true);
    }
    //if out show again a empty InfoBox
    public void PointerOut()
    {
                InfoBox.text = "";
        panel.gameObject.SetActive(false);
    }
    

}

