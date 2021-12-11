using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTable : MonoBehaviour
{
    [SerializeField]
    private float _rotationSpeed = 0;

    [SerializeField]
    private Vector3 _rotation = Vector3.zero;


    private void Start()
    {
        Input.gyro.enabled = true;
    }
    void Update()
    {
        Debug.Log(Input.gyro.rotationRate);
        Vector3 previousEulerAngles = transform.eulerAngles;
        Vector3 gyroInput = -Input.gyro.rotationRateUnbiased;

        Vector3 targetEulerAngles = previousEulerAngles + gyroInput * _rotationSpeed * Time.deltaTime * Mathf.Rad2Deg;
        targetEulerAngles.y = 0.0f;

        transform.eulerAngles = targetEulerAngles;
    }
}
