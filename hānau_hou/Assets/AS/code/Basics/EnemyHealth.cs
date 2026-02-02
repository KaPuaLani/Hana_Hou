using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 3;
    [SerializeField] public int herbs = 0;
    // Start is called before the first frame update
    void Start()
    {
        int temp = GameObject.FindGameObjectWithTag("GameOptions").GetComponent<MainMenuOptions>().difficulty;
        if(temp == 0)
        {
            health = 3;
        }
        if (temp == 1)
        {
            health = 6;
        }
        if (temp == 2)
        {
            health = 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //when I am hit by a player bullet
        if (collision.gameObject.tag == "PlayerBullet")
        {
            //destroy the bullet
            Destroy(collision.gameObject);
            //reduce my hp
            health--;
            //destroy myself if I get too low in health
            if(health <= 0)
            {
                herbs++;
                Destroy(gameObject);
            }
        }
    }
}
