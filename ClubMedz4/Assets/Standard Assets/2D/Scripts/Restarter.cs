using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                print("r");
                SceneManager.LoadScene("ClubMed", LoadSceneMode.Single);
            }
        }
    }
}
