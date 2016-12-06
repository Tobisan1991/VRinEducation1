using UnityEngine;
using UnityEngine.UI;

public class VRTextScript : MonoBehaviour
{
    
	//Variable for the Text Gui
    public Text InfoBox;
    public Text winBox;
    
    // Use this for initialization
	//by default there should no text be shown, so that InfoBos = ""
    void Start()
    {
        InfoBox.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

	//if the pointer shows on the Object, show the Text of winBox
    public void PointerIn()
    {
        InfoBox.text = winBox.text;

    }
	//if out show again a empty InfoBox
    public void PointerOut()
    {

        InfoBox.text = "";

    }


       
}

