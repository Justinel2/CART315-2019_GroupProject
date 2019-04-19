using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mortality : MonoBehaviour
{
    private Score myScore;
    public static float hungerScore;
    public static float energyScore;
    public static bool hitByShark;

    // Start is called before the first frame update
    void Start()
    {
        myScore = gameObject.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        IsItDyingYet();
        ////hungerScore = Score.hungerScore;
    }

    public void IsItDyingYet()
    {
        hungerScore = myScore.hungerScore;
        energyScore = myScore.energyScore;

        if (hungerScore <= 0 || energyScore <= 0 || hitByShark == true)
        {
            SceneManager.LoadScene("LoseScene", LoadSceneMode.Single);
        }
    }
}