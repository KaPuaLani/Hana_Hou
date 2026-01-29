using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuOptions : MonoBehaviour
{
    //Create an empty game object and attach this script to it
    //create a tag called GameOptions and apply it to this object
    // public bool mobile = false;
    public int mobile = 0;
    public int difficulty = 0;
    //Create a toggle on a canvas, and assign it to this public field
    //On the toggle OnValueChanged field, set it to MainMenuOptions.SetMobile
    public Toggle toggle;
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameOptions");

        if (objs.Length > 1)
        {
            Destroy(transform.parent.gameObject);
            Debug.Log("foo");
        }

        DontDestroyOnLoad(transform.parent.gameObject);
    }
    public void Medium()
    {
        difficulty = 1;
    }
    public void Easy()
    {
        difficulty = 0;
    }
    public void Hard()
    {
        difficulty = 2;
    }

    public void PC()
    {
        mobile = 2;
    }

    public void MB()
    {
        mobile = 1;
    }
    // public void SetMobile()
    // {
    //   mobile = toggle.isOn;
    // }
}
