using UnityEngine;
using UnityEngine.UI;

public class VRTextScript : MonoBehaviour
{
    
    public Text InfoBox;
    public Text winBox;
    
    // Use this for initialization
    void Start()
    {
        InfoBox.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PointerIn()
    {
        InfoBox.text = winBox.text;

    }
    public void PointerOut()
    {

        InfoBox.text = "";

    }


       
}

