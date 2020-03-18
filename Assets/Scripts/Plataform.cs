using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform : MonoBehaviour{

    public float speed;

    // Start is called before the first frame update
    void Start(){

        speed = 2;
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update(){
        
        // X Scale behaviour 
        transform.localScale = new Vector2(Mathf.PingPong(Time.time, 1.2f), transform.localScale.y);

        // y Moviment behaviour 
        transform.Translate(new Vector2(0f, -(speed * Time.deltaTime)));
    }
}