using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectables : MonoBehaviour
{
    //store the number of collected items in a variable
    //whenever we collide with a new collectable, add to my variable
    //destroy the collected item so we can't spam collect 
    public int score = 0;
    public int targetScore = 12;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        //check to see if we hit a coin specifically
        if (collision.gameObject.tag == "COL")
        {
            score++;
            Destroy(collision.gameObject);

            if (score >= targetScore)
            {
                // Trigger Win Function
                Debug.Log("You Win!");
                SceneManager.LoadScene("W"); // Load your win scene
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
