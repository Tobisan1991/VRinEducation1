
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MoveCamera : MonoBehaviour
{
    float timeLeft = 300.0f;
    //  bool isLooking = false;
    public float countdown = 50f;

	//updade is called once per frame
  public void update()
    {
		//Time delta is the configured time
        timeLeft -= Time.deltaTime;
		//if time is over the new scence "szene2" should be loaded
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


   */ 
	//countdown for the timer is set to 5
	public void AbortScene()
    {
        countdown = 5;
    }
   

}
