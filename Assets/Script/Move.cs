using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1.0f;
    public float RotationSpeed = 1.5f;
    public float GoUpSpeed = 1.2f;


    private HInput _input;
    private Rigidbody _rigid;
    public bool turnOn = false;

    // Start is called before the first frame update
    void Awake()
    {
        _input = GetComponent<HInput>();
        _rigid = GetComponent<Rigidbody>();
        
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
            onTurnOn();
        }
    }

    private void onTurnOn()
    {
        if (_rigid.useGravity)
        {
            _rigid.useGravity = false;
        }

        if (_input.Y == 0)
        {
            _rigid.velocity = Vector3.zero;
        }
        else
        {
            _rigid.AddForce(0f, _input.Y * GoUpSpeed, 0f);
        }

        transform.Rotate(0f, _input.X * RotationSpeed, 0f);
    }
}
