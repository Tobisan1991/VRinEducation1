using UnityEngine;
using System.Collections;

public class ObjectColliderScript : MonoBehaviour {
    public GameObject enstehendesObjekt;

	// Use this for initialization
	void Start () {
        enstehendesObjekt.SetActive(false);
	
	}
    void OnCollisionEnter(Collision col)
    {
        Debug.Log(gameObject.name + "has collided" + col.gameObject.name);
        if (col.gameObject.name.Equals("Atom1"))
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            enstehendesObjekt.SetActive(true);

        }
        //Destroy (col.gameObject);

    }
}
