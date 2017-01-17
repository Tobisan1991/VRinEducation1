using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MoviePlayer : MonoBehaviour {

    public MovieTexture movie;
    private new AudioSource audio;
   
    

// Use this for initialization
void Start () {
        GetComponent<RawImage>().texture = movie as MovieTexture;
        audio = GetComponent<AudioSource>();
         audio.clip = movie.audioClip;
        
        movie.Play();
        audio.Play();


        
        // Constructors
        


}
}
