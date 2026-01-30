using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.HID;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    private SceneController _sceneController;
    public Canvas mobileCanvas;
    public string levelToLoad;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if we press the escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //pause the game
            Time.timeScale = 0;
            //show our pause menu canvas
            GetComponent<Canvas>().enabled = true;
        }
    }

    public void ResumeGame()
    {
        //continue playing the game... somehow?
        Time.timeScale = 1;
        GetComponent<Canvas>().enabled = false;
        if (GameObject.FindGameObjectWithTag("GameOptions").GetComponent<MainMenuOptions>().mobile == 1)
        {
            mobileCanvas.enabled = true;
        }
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1;
        _sceneController.LoadScene(levelToLoad);
    }
    public void PauseGame()
    {
        //pause the game
        Time.timeScale = 0;
        //show our pause menu canvas
        GetComponent<Canvas>().enabled = true;
        mobileCanvas.GetComponent<Canvas>().enabled = false;
        Debug.Log("here");
    }
}
