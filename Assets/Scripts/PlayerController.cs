using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float torqueAmount = 1f, boostSpeed = 30f, baseSpeed = 20f;




    void Start()
    {
         rb2d = GetComponent<Rigidbody2D>();
         surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    void RespondToBoost(){
        if(Input.GetKey(KeyCode.Space)){
            surfaceEffector2D.speed = boostSpeed;
        } else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    void RotatePlayer(){
        if(Input.GetKey(KeyCode.LeftArrow)){
            rb2d.AddTorque(torqueAmount);  
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            rb2d.AddTorque(-torqueAmount);  
        }
    }
}
