
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MoveCamera : MonoBehaviour
{
    float timeLeft = 300.0f;
    //  bool isLooking = false;
    public float countdown = 50f;

  public void update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            //            Application.LoadLevel("gameOver");
            SceneManager.LoadScene("szene2");
        }
    }

 


 /*   public void TeleportSzene2()
    {

        if (isLooking)
        {
            countdown -= Time.deltaTime;
        }

        //Teleport if countdown reaches zero
        if (countdown <= 0)
            SceneManager.LoadScene("szene2");
    }
    public void TeleportSzene1()
    {
          countdown -= Time.deltaTime;
        
        if (countdown <= 0)
            SceneManager.LoadScene("szene1");
    }

   */ public void AbortScene()
    {
        countdown = 5;
    }
   

}
