using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerMove : MonoBehaviour
{
    private HInput _input;
    private Rigidbody _rigid;
    public bool turnOn = false;

    float Speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        _rigid = GetComponent<Rigidbody>();
        _input = GetComponent<HInput>();
     
    }

    // Update is called once per frame
    void Update()
    {
        if (_input.EngineStart)
        {
            turnOn = !turnOn;
        }

        if (turnOn)
        {
            TurnOn();
        }

    }

    private void TurnOn()
    {
        gameObject.transform.Rotate(0, Speed, 0);
    }
}
