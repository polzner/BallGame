using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieFromFall : MonoBehaviour
{
    [SerializeField] private float _velocityToDie = -50;
    [SerializeField] private Sphere _sphere;
    private Rigidbody _sphereRigidBody;

    private void Start()
    {
        _sphereRigidBody = _sphere.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (_sphereRigidBody.velocity.y <= _velocityToDie)
            _sphere.Die();
    }
}
