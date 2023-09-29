using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void Start()
    {
        // Make the screen landscape from the moment the game starts
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        // If the user presses Esc, quit the program
        if (Input.GetKeyDown(KeyCode.Escape)) { 
            Application.Quit();
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
