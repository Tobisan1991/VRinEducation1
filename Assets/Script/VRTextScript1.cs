using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class VRTextScript1 : MonoBehaviour
{

    //Variable for the Text Gui
    public GameObject Box1;
    //  public Image BackgroundText;
    //  public Image BackgroundFull;
    //  public Image BackgroundEmpty;

    void Start()
    {
        
        Box1.gameObject.SetActive(false);
    }

    public void PointerIn()
    {
        Box1.gameObject.SetActive(true);
    }
    //if out show again a empty InfoBox
    public void PointerOut()
    {

        Box1.gameObject.SetActive(false);
    }


}

