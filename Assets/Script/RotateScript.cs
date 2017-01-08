using UnityEngine;

public class RotateScript : MonoBehaviour
{
  public GameObject objekt;
    
    public void PointerDrin()
    {
        objekt.transform.Rotate(new Vector3(0,Time.deltaTime,0));
    }
    
}

