using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    private const int _lastKnownPositionSize = 3;
    private Vector3[] _lastKnownPositions = new Vector3[_lastKnownPositionSize] { new Vector3(0, 0, 0), new Vector3(0, 0, 0), new Vector3(0, 0, 0) };
    private int _lastPositionIndex = 2;
    private int _2ndlastPositionIndex = 1;
    private int _3rdlastPositionIndex = 0;

    public Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _lastPositionIndex = (_lastPositionIndex + 1) % _lastKnownPositionSize;
        _2ndlastPositionIndex = (_2ndlastPositionIndex + 1) % _lastKnownPositionSize;
        _3rdlastPositionIndex = (_3rdlastPositionIndex + 1) % _lastKnownPositionSize;

        _lastKnownPositions[_lastPositionIndex] = transform.position;
    }

    public void Throw()
    {
        if (_rigidbody != null)
        {
            Vector3 avgVelocity = (_lastKnownPositions[_lastPositionIndex] - _lastKnownPositions[_2ndlastPositionIndex]) / Time.fixedDeltaTime; // Average velocity over the last frame.
            float accelFactor = 0;
            float denominator = (_lastKnownPositions[_2ndlastPositionIndex] - _lastKnownPositions[_3rdlastPositionIndex]).magnitude;
            if (denominator != 0)
                accelFactor = (_lastKnownPositions[_lastPositionIndex] - _lastKnownPositions[_2ndlastPositionIndex]).magnitude / denominator;
            _rigidbody.velocity = avgVelocity * accelFactor;
        }
    }
}
