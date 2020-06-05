using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour {

    //Note you can define several variables of the same type on one line
    public GameObject blueBall, greenBall, redBall, orangeBall;
    private bool isGameOver = false;
    private float elapsedTime = 0;
    private bool isRunning = false;

    private void StartGame()
    {
        elapsedTime = 0;
        isRunning = true;



    }




	void Start () {
        StartGame();
	}
	





	void Update () {
        //if all four ball are nt existent the game is over
        isGameOver = !blueBall && !greenBall && !redBall && !orangeBall;
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
        }
    }
    void OnGUI()
    {
        if (isGameOver)
        {
            string message;
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 5, 200, 27);

           
           Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 600, 50);
            GUI.Box(rect2, "Good Job Saky baki USTASO STO MARUSKA KAZE");
        }
        if(isRunning)
        {
            GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height - 115, 130, 40), "Your Time Is");
            GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height - 100, 20, 30), ((int)elapsedTime).ToString());
        }
       
    }
}
