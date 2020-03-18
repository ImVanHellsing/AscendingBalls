using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RotateBalls : MonoBehaviour{

    public float speed;
    public int score;

    public GameObject gameOver;
    public Text scoreText;

    // Start is called before the first frame update
    void Start(){
        speed = 200;
        score = 0;
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update(){
        
        if(Input.GetMouseButtonDown(0)){
            //right = true;
            speed *= -1;
        }

        transform.Rotate(new Vector3(0f,0f,speed * Time.deltaTime));
    }

    public void CallGameOver(){
        gameOver.SetActive(true);
    }

    public void RestartGame(){
        //SceneManager.LoadScene(0);
        Debug.Log("Teste");
    }

    public void AttScore(){
        score++;
        scoreText.text = score.ToString();
    }
}