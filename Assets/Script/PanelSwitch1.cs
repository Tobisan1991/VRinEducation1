using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

[RequireComponent(typeof(Selectable))]

public class PanelSwitch1 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public GameObject MainPanel;
    public GameObject Weg1;
    public GameObject Weg2;
    public GameObject Weg3;
    public GameObject Weg4;
    public bool isEntered = false;
    public Selectable _selectable;
    public float GazeActivationTime = 3;

    BaseInputModule input;

    float timeElapsed;


    void Start()
    {
        input = FindObjectOfType<BaseInputModule>();
        _selectable = GetComponent<Selectable>();
        MainPanel.SetActive(true);
        Weg1.SetActive(false);
        Weg2.SetActive(false);
        Weg3.SetActive(false);
        Weg4.SetActive(false);
    }

    void Update()
    {
        if (!_selectable.IsInteractable())
        {
            ReticlePointer.Instance.SetFillAmount(0);
            return;
        }
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
            Invoke("SetEnteredTrue", 2f); // start timer after 0.3 seconds of gaze. You can call SetEnteredTrue() directly.
        }
    }

    void SetEnteredTrue()
    {
        MainPanel.SetActive(true);
        Weg1.SetActive(false);
        Weg2.SetActive(false);
        Weg3.SetActive(false);
        Weg4.SetActive(false);
    }


    #endregion

    #region IPointerExitHandler implementation

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
            Debug.LogError(ex.Message);
        }
    }
    #endregion

    #region IPointerClickHandler implementation

    public void OnPointerClick(PointerEventData eventData)
    {
        isEntered = false;
        timeElapsed = 0;

    }
    #endregion

}

