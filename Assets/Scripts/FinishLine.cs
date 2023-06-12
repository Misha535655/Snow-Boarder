using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float timeToReset = 1f;
    [SerializeField] ParticleSystem effect;



    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player"){
            effect.Play();
            Invoke("RestartScene", timeToReset);
            GetComponent<AudioSource>().Play();
        }
    }
    void RestartScene(){
        SceneManager.LoadScene(0);
    }
}
