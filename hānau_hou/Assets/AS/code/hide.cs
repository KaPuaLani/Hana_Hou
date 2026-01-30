using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide : MonoBehaviour
{
    // Drag and drop your Canvas GameObject onto this field in the Inspector
    public Canvas canvasToHide;

    public void HideCanvasComponent()
    {
        if (canvasToHide != null)
        {
            // This disables the rendering of the Canvas
            canvasToHide.enabled = false;
            Debug.Log("Canvas component hidden.");
        }
    }

    public void ShowCanvasComponent()
    {
        if (canvasToHide != null)
        {
            // This enables the rendering of the Canvas
            canvasToHide.enabled = true;
            Debug.Log("Canvas component shown.");
        }
    }

    void Start()
    {
        if (GameObject.FindGameObjectWithTag("GameOptions").GetComponent<MainMenuOptions>().hid == 1)
        {
            // This disables the rendering of the Canvas
            canvasToHide.enabled = false;
            Debug.Log("Canvas component hidden.");
        }
        if (GameObject.FindGameObjectWithTag("GameOptions").GetComponent<MainMenuOptions>().hid == 0)
        {
            // This enables the rendering of the Canvas
            canvasToHide.enabled = true;
            Debug.Log("Canvas component shown.");
        }
    }
}
