using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private EndScreen _endScreen;
    [SerializeField] private StartScreen _startScreen;
    [SerializeField] private GroundPlacer _groundPlacer;
    [SerializeField] private Sphere _sphere;

    private void OnEnable()
    {
        _sphere.GameOver += OnGameOver;
        _endScreen.RestartButtonClick += OnRestartButtonClick;
        _startScreen.StartButtonClick += OnPlayButtonClick;
    }

    private void OnDisable()
    {
        _sphere.GameOver -= OnGameOver;
        _endScreen.RestartButtonClick -= OnRestartButtonClick;
        _startScreen.StartButtonClick -= OnPlayButtonClick;
    }

    private void Start()
    {
        _startScreen.Open();
        Time.timeScale = 0;
    }

    private void OnPlayButtonClick()
    {
        _startScreen.Close();
        StartGame();
    }

    private void OnRestartButtonClick()
    {
        _endScreen.Close();
        _groundPlacer.Restart();
        StartGame();
    }

    private void StartGame()
    {
        _sphere.ResetStats();
        Time.timeScale = 1;
    }

    private void OnGameOver()
    {
        Time.timeScale = 0;
        _endScreen.Open();
    }
}
