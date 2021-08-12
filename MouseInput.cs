using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    private float _lastFrameMousePositionX;
    private float _moveFactorX;
    public float MoveFactorX => _moveFactorX;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _lastFrameMousePositionX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButton(0))
        {
            _moveFactorX = Input.mousePosition.x - _lastFrameMousePositionX;
            _lastFrameMousePositionX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            _moveFactorX = 0;
        }
    }
}
