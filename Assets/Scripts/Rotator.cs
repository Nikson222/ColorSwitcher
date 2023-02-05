using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Rotator : MonoBehaviour
{
    [Range(50f, 200f)]
    [SerializeField] private float _rotateSpeed;

    private Rigidbody2D _rigidBody;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Rotate();
    }

    private void Rotate()
    {
        _rigidBody.MoveRotation(_rigidBody.rotation + _rotateSpeed * Time.fixedDeltaTime);
    }
}
