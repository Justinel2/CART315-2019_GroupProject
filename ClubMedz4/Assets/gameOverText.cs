using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverText : MonoBehaviour
{
    public Font myF;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            print("r");
            SceneManager.LoadScene("ClubMed", LoadSceneMode.Single);
        }
    }


    private void OnGUI()
    {

        GUIStyle boardStyle = new GUIStyle(GUI.skin.button);
        boardStyle.font = myF;
        GUI.backgroundColor = new Color(0f, 0f, 0f, 0f);
        boardStyle.fontSize = 50;
        GUI.Box(new Rect(Screen.width / 2 - 350, 20, 700, 400), "RIP", boardStyle);
        //boardStyle.alignment = TextAnchor.UpperLeft;
        boardStyle.fontSize = 30;
        GUI.color = new Color(0.5f, 0.5f, 0.5f, 0.7f);
        GUI.Box(new Rect(Screen.width / 2 - 350, Screen.height / 2, 700, 400), "youd died \npress (R) to restart", boardStyle);
    }

}
