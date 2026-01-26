using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mbm : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed = 5f;
    [SerializeField] InputActionReference moveActionToUse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //when we press left or right, move the char left/right
        float moveX = moveActionToUse.action.ReadValue<Vector2>().x;//Input.GetAxis("Horizontal");
        float moveY = moveActionToUse.action.ReadValue<Vector2>().y;
        //Debug.Log(moveActionToUse.action.ReadValue<Vector2>());
        //maintain the integrity of our Y velocity
        Vector3 velocity = rb.velocity;
        velocity.x = moveX * moveSpeed;
        velocity.y = moveY * moveSpeed;
        rb.velocity = velocity;
    }
}
