using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score;
    public void AddScore(int scr){
        score = scr;
    }
    public void ResetScore(){
        score = 0;
    }
    public int GetScore(){
        return score;
    }

// Timer
    [SerializeField] private int timeLimit;
    private float timer;
    private bool timerActive;
    public void ResetTimer(){
        timer = timeLimit;
    }
    public void StartCountDown(){
        timerActive = true;
    }
    public int GetSecondsLeft(){
        return (int)timer; // This should floor it.
    }


    void Update(){
        if(timerActive){
            if(timer <= 0) timerActive = false;
            timer -= 1 * Time.deltaTime;
        }
    }

}
