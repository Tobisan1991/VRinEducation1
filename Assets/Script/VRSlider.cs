using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class VRSlider : MonoBehaviour
{

    public float fillTime = 2f;
    private float timer;
    private bool gazedAt;
    private Coroutine fillBarRoutine;
    public GameObject myGo;

    public Text winText;




    private Slider mySlider;

    // Use this for initialization
    void Start()
    {
        mySlider = GetComponent<Slider>();
        if (mySlider == null) Debug.Log("Please add a Slider Comp to this GO");

        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PointerEnter()
    {
        gazedAt = true;
        fillBarRoutine = StartCoroutine(FillBar());
        winText.text = "You Win!";

    }
    public void PointerExit()
    {
        gazedAt = false;
        if (fillBarRoutine != null)
        {
            StopCoroutine(fillBarRoutine);
        }

        timer = 0f;
        mySlider.value = 0f;

        winText.text = "";

    }

    private IEnumerator FillBar()
    {
        timer = 0f;
        while (timer < fillTime)
        {
            timer += Time.deltaTime;
            mySlider.value = timer / fillTime;
            yield return null;

            if (gazedAt)

                continue;

            timer = 0f;
            mySlider.value = 0f;

            yield break;


        }
        OnBarFilled();

    }
    private void OnBarFilled()
    {
        Debug.Log("Do sth amazing");
        //UnityEngine.SceneManagement.SceneManager.LoadScene("Level02");


    }
}

