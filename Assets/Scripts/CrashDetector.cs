using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float timeToReset = 0.3f;
    [SerializeField] ParticleSystem effect;
    [SerializeField] AudioClip crashSFX;


    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground"){
            effect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("RestartScene", timeToReset);
        }   
    }
    void RestartScene(){
        SceneManager.LoadScene(0);
    }
}
