using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour{
    
    public GameObject plataformPrevab;

    float timer;
    float timerTot;

    public float maxTime;
    public float minTime;

    // Start is called before the first frame update
    void Start(){
        maxTime = 5;
        minTime = 2;
        timerTot = Random.Range(minTime,maxTime);
    }

    // Update is called once per frame
    void Update(){

        timer += Time.deltaTime;

        if(timer >= timerTot){
        
            //Instanciação dos Prevabs
            Instantiate(plataformPrevab, transform.position, transform.rotation);

            //Setando timers
            timerTot = Random.Range(minTime,maxTime);
            timer = 0f;
        }
    }
}