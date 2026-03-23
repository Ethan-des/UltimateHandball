using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball b;

    //P1 is the script that handles the paddle and its properties
    public P1 playerPaddle;
    public P1 computerPaddle;

    public Text playerScoreText;

    public Text highScoreText; //Find a tutorial on highscore systems

    private int _playerScore;

    private int _highScore;

    void Start()
    {
        b = FindObjectOfType<Ball>(); // <- You can't reference other scripts without this
        Debug.Log(b.speed);
    }

    public void PlayerScores()
    {
        _playerScore++;

        //To update the player score text of the current value of player's score
        this.playerScoreText.text = _playerScore.ToString();

        if(_playerScore % 5 == 0)
        {
            this.b.speed += 200.0f;
        }

        //Debug.Log("Ball Bounced on player paddle");
    }

    public void ComputerScores()
    {
        _highScore++;
        this.b.ResetPosition();
        this.b.AddStartingForce();
    }

    
}
