using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointBar : MonoBehaviour{
    
    public GameObject pointBarPrevab;

    float timer;
    float timerTot;

    public float maxTime;
    public float minTime;

    // Start is called before the first frame update
    void Start(){
        timerTot = Random.Range(minTime,maxTime);
    }

    // Update is called once per frame
    void Update(){

        timer += Time.deltaTime;

        if(timer >= timerTot){
        
            //Instanciação dos Prevabs
            Instantiate(pointBarPrevab, transform.position, transform.rotation);

            //Setando timers
            timerTot = Random.Range(minTime,maxTime);
            timer = 0f;
        }
    }
}