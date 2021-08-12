using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SurfaceSlider))]
public abstract class Movement : MonoBehaviour
{
    [SerializeField] protected float _speed;

    private Rigidbody _rigidbody;
    private SurfaceSlider _surfaceSlider;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _surfaceSlider = GetComponent<SurfaceSlider>();
    }

    public void Move(Vector3 direction)
    {
        Vector3 directionAlongSurface = _surfaceSlider.Project(direction.normalized);
        Vector3 offset = directionAlongSurface * (_speed * Time.deltaTime);

        _rigidbody.MovePosition(_rigidbody.position + offset);
    }
}
