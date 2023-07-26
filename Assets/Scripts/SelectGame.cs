using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectGame : MonoBehaviour
{
    public Sprite ButtonSprite;
    public SpriteRenderer ButtonRenderer;
    public TargetScene Target;

    private void Start()
    {
        ButtonRenderer.sprite = ButtonSprite;
    }
}

public enum TargetScene
{
    Lobby, TicTacToe, MineSweeper, Connect4, Tetris
}
