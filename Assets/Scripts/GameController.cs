using BoardGames;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TicTacToe TicTacToeGame;
    public void GetInput (int col, int row)
    {
        TicTacToeGame.Move(col, row);
    }
    // Start is called before the first frame update
    void Start()
    {
        TicTacToeGame = new TicTacToe();
    }

}
