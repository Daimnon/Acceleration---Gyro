using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationDebug : MonoBehaviour
{
    [SerializeField]
    private float _speed = 0, _rotationSpeed = 0;

    [SerializeField]
    private Vector3 _velocity = Vector3.zero, _rotation = Vector3.zero;
    void Update()
    {
        Debug.Log(Input.acceleration);

        _velocity = new Vector3(Input.acceleration.x * _speed * Time.deltaTime, 0, -Input.acceleration.z * _speed * Time.deltaTime);
        _rotation = new Vector3(0, Input.acceleration.y * _rotationSpeed * Time.deltaTime, 0);

        transform.Translate(_velocity);
        transform.Rotate(_rotation);
    }
}
