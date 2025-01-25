using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
// Score
    private int score = 0;
    void AddScore(int scr){
        score = scr;
    }
    void ResetScore(){
        score = 0;
    }

// Timer
    [SerializeField] private int timeLimit;
    private float timer;
    private bool timerActive;
    void ResetTimer(){
        timer = timeLimit;
    }
    void StartCountDown(){
        timerActive = true;
    }
    int GetSecondsLeft(){
        return (int)timer; // This should floor it.
    }


    void Update(){
        if(timerActive){
            if(timer <= 0) timerActive = false;
            timer -= 1 * Time.deltaTime;
        }
    }

}
