using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HInput : MonoBehaviour
{

    public bool Up { get; private set; }
    public bool Down { get; private set; }


    // Update is called once per frame
    void Update()
    {
        Up = Down = false;

        Up = Input.GetKey(KeyCode.UpArrow);
        Down = Input.GetKey(KeyCode.DownArrow);
    }
}
