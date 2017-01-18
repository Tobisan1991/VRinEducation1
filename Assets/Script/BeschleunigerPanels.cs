using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

[RequireComponent(typeof(Selectable))]

public class BeschleunigerPanels : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    //Variablen atom als Game Object die durch den Raum bewegen
	public GameObject atom1;
    public GameObject atom2;
 
    public bool isEntered = false;
    public Selectable _selectable;
    public float GazeActivationTime = 3;

    BaseInputModule input;

    float timeElapsed;


    void Start()
    {
		//Anfang sollen Atome nicht angezeigt werden, Acitve = false, da erst nach start gedrückt wurde
        input = FindObjectOfType<BaseInputModule>();
        _selectable = GetComponent<Selectable>();
        atom1.SetActive(false);
        atom2.SetActive(false);
       
    }

    void Update()
    {
		
        if (!_selectable.IsInteractable())
        {
            ReticlePointer.Instance.SetFillAmount(0);
            return;
        }
		//Wenn Funktion Entered wurde soll ein timeElapse gestartet werden, der auf 0 gesetzt wird
        if (isEntered)
        {
            timeElapsed += Time.deltaTime;

            if (timeElapsed >= GazeActivationTime)
            {
                timeElapsed = 0;

                ((GazeInputModule)input).HandleTriggerManually();

                isEntered = false;
            }

            ReticlePointer.Instance.Show();

        }
        else
        {
            timeElapsed = 0;
        }
    }

    void OnDisable()
    {
        isEntered = false;
        if (ReticlePointer.Instance != null)
        {
            timeElapsed = 0;
        }
    }

    #region IPointerEnterHandler implementation

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (_selectable.IsInteractable())
        {
            Invoke("SetEnteredTrue", 2f); // start Zeit ist 0,3 Sekunden nach beginn
        }
    }

	//True setzten der Atom Objekte um diese sichtbar zu machen
    void SetEnteredTrue()
    {
        atom1.SetActive(true);
        atom2.SetActive(true);
    }


    #endregion

    #region IPointerExitHandler implementation

	//Sollte sich der Benutzer auf dem Start Button entfernen
    public void OnPointerExit(PointerEventData eventData)
    {
        if (!_selectable.IsInteractable())
            return;
        try
        {
            CancelInvoke("SetEnteredTrue");
            isEntered = false;
        }
        catch (System.Exception ex)
        {
			//Fehlermeldung auffangen bei Fehlverhalten
            Debug.LogError(ex.Message);
        }
    }
    #endregion

    #region IPointerClickHandler implementation

	//Bei Klick soll ein Event "PonterEventData" ausgeführt werden
    public void OnPointerClick(PointerEventData eventData)
    {
        isEntered = false;
        timeElapsed = 0;

    }
    #endregion

}

