using UnityEngine;

public class Space : MonoBehaviour
{
    public int col, row;
    public Sprite[] DisplayImage;
    public SpriteRenderer DisplayRenderer;
    public GameController Controller;


    // Update is called once per frame
    public void Update()
    {
        int Current = (int) Controller.TicTacToeGame.Board[col, row];
        DisplayRenderer.sprite = DisplayImage[Current];
    }
    public void OnMouseUpAsButton()
    {
        Controller.GetInput(col, row);
    }
}
