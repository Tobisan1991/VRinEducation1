using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

[RequireComponent(typeof(Selectable))]

public class PanelSwitch : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    private int scoreRichtige = 0;
    private int scoreFalsche = 0;
    private int score = 0;
    private string scoreText;
    public int richtige = 0;
    public int falsche = 0;
    public GameObject QuizPanel;
    public GameObject HauptPanel;
    public bool isEntered = false;
    public Selectable _selectable;
    public float GazeActivationTime = 3;
    sendText text1 = new sendText();

    BaseInputModule input;

    float timeElapsed;


    void Start()
    {

        
        input = FindObjectOfType<BaseInputModule>();
        _selectable = GetComponent<Selectable>();
        HauptPanel.SetActive(true);
        QuizPanel.SetActive(false);

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

    public class sendText
    {
        private string scoreText2;

        public  string Name
        {
            get
            {
                return scoreText2;
            }
            set
            {
                scoreText2 = value;
            }
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
        scoreRichtige += richtige;
        scoreFalsche += falsche;
        score = scoreFalsche + scoreRichtige;
        scoreText = "Insg.: " + score + ", " + scoreRichtige + " Richtige, " + scoreFalsche + " Falsche";
        text1.Name = scoreText;
        HauptPanel.SetActive(false);
        QuizPanel.SetActive(true);
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

