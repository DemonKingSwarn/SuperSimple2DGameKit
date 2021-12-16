using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject pauseMenuObj;
    public GameObject mainMenuObj;
    public GameObject gameOverObj;
    public TextMeshProUGUI finalScore;
    [SerializeField] private bool isPlaying = true;
    [SerializeField] private Health health;
    [SerializeField] private Coin coin;

    private void Awake() 
    {
        Application.targetFrameRate = 60;
        Application.runInBackground = false;
    }


    private void Update()
    {
        if(health.isDead == true) 
        {
            gameOverObj.SetActive(true);
            Time.timeScale = 0f;
            finalScore.text = "Your Score: " + coin.score;
        }

        if(isPlaying == true) 
        {
            mainMenuObj.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Play() 
    {
        mainMenuObj.SetActive(false);
        isPlaying = false;
        Time.timeScale = 1f;
    }
 
    public void Pause()
    {
        pauseMenuObj.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenuObj.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Menu()
    {
        Debug.Log("Menu loading...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void QuitButton()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Retry() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        mainMenuObj.SetActive(false);
        isPlaying = false;
        Time.timeScale = 1f;
        
        
    }

}
