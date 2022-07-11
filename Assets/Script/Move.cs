using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private HInput _input;
    private Rigidbody _rigid;
    public float speed = 1.0f;
    public bool turnOn = false;

    private void Up() => _rigid.AddForce(0f, speed, 0f);
    private void Down() => _rigid.AddForce(0f, speed, 0f);

    // Start is called before the first frame update
    void Start()
    {
        _input = GetComponent<HInput>();
        _rigid = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (_input.Up)
        {
            if (speed >= 1.0f)
            {
                speed -= 0.1f;
            }
            speed += 0.1f;
        }
        else if (_input.Down)
        {
            if (speed <= 0.0f)
            {
                speed += 0.1f;
            }
            speed -= 0.1f;
            Down();
        }
        Up();
    }
}
