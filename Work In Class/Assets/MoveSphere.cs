using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _rb;

    [SerializeField]
    private float _speed = 0;

    [SerializeField]
    private Vector3 _velocity = Vector3.zero;

    void Update()
    {
        _velocity = new Vector3(Input.acceleration.x * _speed * Time.deltaTime, 0, -Input.acceleration.z * _speed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        _rb.AddForce(_velocity, ForceMode.Force);
    }
}
