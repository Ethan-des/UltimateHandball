using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    //P1 is the script that handles the paddle and its properties
    public P1 playerPaddle;
    public P1 computerPaddle;

    public Text playerScoreText;

    public Text highScoreText; //Find a tutorial on highscore systems

    private int _playerScore;

    private int _highScore;

    public void PlayerScores()
    {
        _playerScore++;

        //To update the player score text of the current value of player's score
        this.playerScoreText.text = _playerScore.ToString();
        //this.ball.ResetPosition();

        this.ball.AddStartingForce();
    }

    public void ComputerScores()
    {
        _highScore++;
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

    
}
