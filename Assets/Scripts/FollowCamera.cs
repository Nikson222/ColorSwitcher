using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class FollowCamera : MonoBehaviour
{
    [SerializeField] private float _followSpeed;
    [SerializeField] private Transform _targetTransform;

    void Update()
    {
        FollowTarget();
    }

    private void FollowTarget()
    {
        Vector3 newPosition = new Vector3(_targetTransform.position.x, _targetTransform.position.y, transform.position.z);

        transform.position = Vector3.Slerp(transform.position, newPosition, _followSpeed * Time.deltaTime);
    }
}
