using System.Collections;
using System.Collections.Generic;
using Boom.Utility;
using UnityEngine;

public class DontDestory : MonoBehaviour
{
    // Start is called before the first frame update
    private static DontDestory instance;

    void Awake()
    {
        if (instance == null) 
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        // DontDestroyOnLoad(this);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
