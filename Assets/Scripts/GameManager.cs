using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public Ball ball;
  public Paddle playerPaddle;
  public Paddle ComputerPaddle;
  
  public Text playerScoreText;
  public Text computerScoreText;

  private int playerScore;
  private int computerScore;

  public void PlayerScores()
  {
    playerScore++;
    this.playerScoreText.text = this.playerScore.ToString();
    ResetRound();
  }

  public void ComputerScores()
  {
    computerScore++;
    this.computerScoreText.text = this.computerScore.ToString();
    ResetRound();
  }

  private void ResetRound()
  {
    this.ball.ResetPosition();
    this.playerPaddle.ResetPosition();
    this.ComputerPaddle.ResetPosition();
  }
}
