using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MBmovement : MonoBehaviour
{
    [SerializeField] private InputActionReference moveActionToUse;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveDir = moveActionToUse.action.ReadValue<Vector2>();
        transform.Translate(moveDir * speed * Time.deltaTime);
    }
}