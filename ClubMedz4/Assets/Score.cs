using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour { 


    public float hungerScore;
    public float energyScore;
    public int timeScore;
    private GameObject player;

    public static float timer;
    private int minutes;
    private int seconds;

    public int pastAte;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("ActivePlayer");

        energyScore = 100.0f;
        hungerScore = 100.0f;

        pastAte = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetTime();
        GetEnergy();
        GetHunger();
        GetCountdown();
        if (timeScore <= 0)
        {
            SceneManager.LoadScene("WinScene", LoadSceneMode.Single);
        }
    }



    void GetEnergy()
    {
        bool sleeping = GameObject.Find("Player01").GetComponent<Sleep>().inHouse;
        if (sleeping)
        {
            energyScore = 100.0f;
        }
        else {
            if (seconds % 3 == 0 && seconds > 3)
                energyScore -= 0.03f;
        }

        if (player.transform.position.y <= -11)
            energyScore -= 0.1f;
    }

    void GetHunger()
    {
        int player01Eaten = GameObject.Find("Player01").GetComponent<Eat>().foodEaten;
        int player02Eaten = GameObject.Find("Player02").GetComponent<Eat>().foodEaten;
        int player03Eaten = GameObject.Find("Player03").GetComponent<Eat>().foodEaten;
        int currentAte = player01Eaten + player02Eaten + player03Eaten;

        if (seconds % 3 == 0 && seconds > 3)
            hungerScore -= 0.03f;
        hungerScore += currentAte - pastAte;

        if (hungerScore >= 100.0f)
            hungerScore = 100.0f;

        pastAte = currentAte;
    }

    void GetCountdown()
    {
        timeScore = 5 - minutes;
    }


    void GetTime()
    {
        timer += Time.deltaTime;
        //print(timer);
        minutes = Mathf.FloorToInt(timer / 60F);
        seconds = Mathf.FloorToInt(timer - minutes * 60);
    }

}

