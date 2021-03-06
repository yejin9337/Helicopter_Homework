using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HInput : MonoBehaviour
{

    public float X { get; private set; }
    public float Y { get; private set; }
    public bool EngineStart { get; private set; }

    // Update is called once per frame
    void Update()
    {
        X = 0f;
        Y = 0f;
        EngineStart = false;

        X = Input.GetAxis("Horizontal");
        Y = Input.GetAxis("Vertical");
        EngineStart = Input.GetKeyUp(KeyCode.R);
    }
}
