using UnityEngine;
using System.Collections;

public class RichtigZaehlerMaschinenbau : MonoBehaviour
{

    public GameObject panel;
    public static int number;

    // Use this for initialization
    void Start()
    {
        counterMethod();
    }

    public void counterMethod()
    {
        if (panel.activeSelf)
        {
            number = number + 1;
            print("Number of Activated Panels= " + number);
        }
    }
}
