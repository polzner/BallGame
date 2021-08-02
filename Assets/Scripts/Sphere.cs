using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Sphere : MonoBehaviour
{
    private Vector3 _startPosition;

    public event UnityAction GameOver;

    private void Start()
    {
        _startPosition = transform.position;
    }

    public void ResetStats()
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        transform.position = _startPosition;
    }

    public void Die()
    {
        GameOver?.Invoke();
    }
}
