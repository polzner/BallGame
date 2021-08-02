using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMoving : MonoBehaviour
{
    [SerializeField] private float _maxSped = 10;
    [SerializeField] private float _turnSpeed = 10;
    [SerializeField] private float _jumpForce = 100;
    [SerializeField] private AnimationCurve _normalizedSpeedByDistance;

    private bool _grounded;
    private Rigidbody _rigidBody;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rigidBody.velocity = new Vector3(_maxSped * _normalizedSpeedByDistance.Evaluate(transform.position.x), _rigidBody.velocity.y, _rigidBody.velocity.z);

        if (Input.GetKey(KeyCode.W))
        {
            _rigidBody.AddForce(Vector3.forward* _turnSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rigidBody.AddForce(-Vector3.forward * _turnSpeed);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        _grounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        _grounded = false;
    }

    private void Update()
    {        
        if (Input.GetKeyDown(KeyCode.Space) && _grounded)
        {
            _rigidBody.AddForce(Vector3.up * _jumpForce);
            _grounded = false;
        }
    }
}
