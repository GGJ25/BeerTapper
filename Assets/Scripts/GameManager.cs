using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject endScreenUI;
    [SerializeField] private GameObject[] gameplayObjects;

// Score
    private int score;
    public void AddScore(int scr){
        score += scr;
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

    public void StartGame(){
        score = 0;
        timer = timeLimit;
        timerActive = true;
    }

    void EndGame(){
        timerActive = false;
        foreach (GameObject obj in gameplayObjects){
            obj.SetActive(false);
        }
        endScreenUI.SetActive(true);
        endScreenUI.GetComponent<TextMeshProUGUI>().text = $"You score {score}";
    }


    void Update(){

        if(timerActive){
            if(timer <= 0) EndGame();
            timer -= 1 * Time.deltaTime;
        }
    }

}
