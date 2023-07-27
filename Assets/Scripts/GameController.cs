using BoardGames;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TicTacToe TicTacToeGame;
    public TextMeshPro P1WinCount;
    public TextMeshPro P2WinCount;
    private int P1Wins, P2Wins;
    public void GetInput (int col, int row)
    {
        if (TicTacToeGame.CurrentState != GameState.Playing)
        {
            TicTacToeGame = new TicTacToe();
            return;
        }

        TicTacToeGame.Move(col, row);
        if (TicTacToeGame.CurrentState == GameState.Player1Win)
        {
            P1Wins++;
        }
        if (TicTacToeGame.CurrentState == GameState.Player2Win)
        {
            P2Wins++;
        }
        P1WinCount.text = "Player 1 Win Count:\n" + P1Wins.ToString();
        P2WinCount.text = "Player 2 Win Count:\n" + P2Wins.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        TicTacToeGame = new TicTacToe();
    }

}
