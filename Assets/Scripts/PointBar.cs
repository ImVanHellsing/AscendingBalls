using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointBar : MonoBehaviour{

    public float speed;
    // Start is called before the first frame update
    void Start(){
        speed = 2;
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update(){
        transform.Translate( new Vector2(0f, -(speed * Time.deltaTime)));
    }
}