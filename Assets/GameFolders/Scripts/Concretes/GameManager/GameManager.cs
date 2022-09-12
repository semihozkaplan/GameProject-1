using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


public class GameManager : MonoBehaviour
{

    [SerializeField] int score;
    public static GameManager Instance { get; private set; }

    public event Action<int> OnScoreChange;
    public event Action OnSceneChange;



    private void Awake()
    {

        SingletonThisGameObject();

    }

    private void SingletonThisGameObject()
    {

        if (Instance == null)
        {

            Instance = this;
            DontDestroyOnLoad(this.gameObject);

        }

        else
        {

            Destroy(this.gameObject);

        }

    }

    public void IncreaseScore()
    {
        score += 10;
        OnScoreChange?.Invoke(score);
    }

    public void StartGame()
    {

        score = 0;
        StartCoroutine(StartGameAsync());
        Time.timeScale = 1f;

    }

    private IEnumerator StartGameAsync()
    {

        OnSceneChange?.Invoke();
        yield return SceneManager.LoadSceneAsync("Game");

    }
    
    public void StartMenuAsync()
    {

        StartCoroutine(BackMenu());

    }

     private IEnumerator BackMenu()
    {

        OnSceneChange?.Invoke();
        yield return SceneManager.LoadSceneAsync("Menu");

    }
    public void ExitGame()
    {

        Application.Quit();

    }


   


}
