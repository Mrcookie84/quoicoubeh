using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    [SerializeField] private KeyCode _keyCodeZ = KeyCode.W;
    [SerializeField] private KeyCode _keyCodeQ = KeyCode.A;
    [SerializeField] private KeyCode _keyCodeS = KeyCode.S;
    [SerializeField] private KeyCode _keyCodeD = KeyCode.D;
    [SerializeField] private float _speed = 0.2f;
    void Update()
    {
        if (Input.GetKey(_keyCodeZ))
        {
            transform.position += Vector3.forward * _speed;
        }

        if (Input.GetKey(_keyCodeQ))
        {
            transform.position += Vector3.left * _speed;
        }

        if (Input.GetKey(_keyCodeS))
        {
            transform.position += Vector3.back * _speed;
        }

        if (Input.GetKey(_keyCodeD))
        {
            transform.position += Vector3.right * _speed;
        }
    }
}
