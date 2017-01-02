using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class VRTextScript : MonoBehaviour
{
    
	//Variable for the Text Gui
    public Text InfoBox1;
    public Text InfoBox2;
    public Text winBox;
    public Image panel1;
    public Image panel2;
  //  public Image BackgroundText;
  //  public Image BackgroundFull;
  //  public Image BackgroundEmpty;
  
    void Start()
    {
        InfoBox1.text = "";
        InfoBox2.text = "";
        panel1.gameObject.SetActive(false);
        panel2.gameObject.SetActive(false);
    }

    public void PointerIn()
    {
        InfoBox1.text = winBox.text;
        InfoBox2.text = winBox.text;
        panel1.gameObject.SetActive(true);
        panel2.gameObject.SetActive(true);
    }
    //if out show again a empty InfoBox
    public void PointerOut()
    {
        InfoBox1.text = "";
        InfoBox2.text = "";
        panel1.gameObject.SetActive(false);
        panel2.gameObject.SetActive(false);
    }


}

