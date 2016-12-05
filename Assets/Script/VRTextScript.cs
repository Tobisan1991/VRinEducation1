using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class VRTextScript : MonoBehaviour
{
    
    private bool gazedAt;
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
        gazedAt = true;
        InfoBox.text = winBox.text;

    }
    public void PointerOut()
    {
        gazedAt = false;

        InfoBox.text = "";

    }


       
}

