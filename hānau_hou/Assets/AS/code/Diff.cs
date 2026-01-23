using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class DD : MonoBehaviour // when use DD need v-awake
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}