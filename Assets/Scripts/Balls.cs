using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour{
    
    public RotateBalls controlador;

    //Collider
    void OnCollisionEnter2D(Collision2D collision){

        if(collision.gameObject.tag == "PointBar"){
             
            Destroy(collision.gameObject);
            controlador.AttScore(); 
        }   

        if(collision.gameObject.tag == "Plataform"){
            controlador.CallGameOver();
        }
    }
}