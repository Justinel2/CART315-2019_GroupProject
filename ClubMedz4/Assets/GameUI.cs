using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    GameObject statsPanel;
    GameObject menuPanel;
    //GameObject restart;

    // Use this for initialization
    void Start()
    {
        menuPanel = GameObject.FindGameObjectWithTag("Menu");
        statsPanel = GameObject.FindGameObjectWithTag("Stats");

        Time.timeScale = 0;
        menuPanel.SetActive(true);
        statsPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            PauseGame();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            StartGame();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        menuPanel.SetActive(true);
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        menuPanel.SetActive(false);
        statsPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }
}